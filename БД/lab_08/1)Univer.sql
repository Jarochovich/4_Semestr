use UNIVER;

--1-Task--
--SELECT TEACHER.TEACHER [Код], 
--	   TEACHER.TEACHER_NAME [Имя преподавателя], 
--	   TEACHER.GENDER [Пол], 
--	   TEACHER.PULPIT [Код кафедры]
--FROM TEACHER;
--go
--CREATE VIEW [Преподаватель]
--	as select TEACHER.TEACHER [Код], 
--			  TEACHER.TEACHER_NAME [Имя преподавателя], 
--			  TEACHER.GENDER [Пол], 
--			  TEACHER.PULPIT [Код кафедры]
--	FROM TEACHER;

--2-Task--
--SELECT FACULTY.FACULTY [Факультет],
--	   count(PULPIT.PULPIT) [Количество кафедр]
--FROM FACULTY join PULPIT
--	 on FACULTY.FACULTY = PULPIT.FACULTY
--group by FACULTY.FACULTY;
--go
--CREATE VIEW [Количество кафедр]
--	as select FACULTY.FACULTY [Факультет],
--	   count(PULPIT.PULPIT) [Количество кафедр]
--	FROM FACULTY join PULPIT
--	 on FACULTY.FACULTY = PULPIT.FACULTY
--group by FACULTY.FACULTY;

--3-Task--

--SELECT AUDITORIUM.AUDITORIUM_TYPE [Код],
--	   AUDITORIUM.AUDITORIUM_NAME [Наименование аудитории]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE LIKE 'LK%'


--go
--create VIEW Аудитории(Код, [Наименование аудитории])
--	as select AUDITORIUM.AUDITORIUM_TYPE [Код],
--	   AUDITORIUM.AUDITORIUM [Наименование аудитории]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE IN ('LK');


--INSERT Аудитории values('LK', '200-3а');
--select * from Аудитории



--4-Task--
--SELECT AUDITORIUM.AUDITORIUM_TYPE [Код],
--	   AUDITORIUM.AUDITORIUM_NAME [Наименование аудитории]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE in ('LK')

--go
--alter VIEW [Лекционные_аудитории](Код, [Наименование аудитории])
--	as select AUDITORIUM.AUDITORIUM_TYPE [Код],
--	   AUDITORIUM.AUDITORIUM [Наименование аудитории]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE IN ('LK')
--WITH CHECK OPTION;


--INSERT [Лекционные_аудитории] values ('LK', '200-3');
--select * from [Лекционные_аудитории]

--5-Task--
--select  SUBJECT.PULPIT, SUBJECT.SUBJECT_NAME, SUBJECT.SUBJECT
--from SUBJECT
--order by SUBJECT_NAME

--go
--alter view Дисциплины (Код, [Наименование дисциплины], [Код кафедры])
--	as select top 150 SUBJECT.PULPIT,
--	   SUBJECT.SUBJECT_NAME,
--	   SUBJECT.SUBJECT
--FROM SUBJECT
--order by SUBJECT_NAME

--6-Task--

go
alter VIEW [Количество кафедр] with schemabinding
	as select FACULTY.FACULTY [Факультет],
	   count(PULPIT.PULPIT) [Количество кафедр]
	FROM dbo.FACULTY inner join dbo.PULPIT
	 on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY.FACULTY;