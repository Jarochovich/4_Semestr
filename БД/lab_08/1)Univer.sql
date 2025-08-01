use UNIVER;

--1-Task--
--SELECT TEACHER.TEACHER [���], 
--	   TEACHER.TEACHER_NAME [��� �������������], 
--	   TEACHER.GENDER [���], 
--	   TEACHER.PULPIT [��� �������]
--FROM TEACHER;
--go
--CREATE VIEW [�������������]
--	as select TEACHER.TEACHER [���], 
--			  TEACHER.TEACHER_NAME [��� �������������], 
--			  TEACHER.GENDER [���], 
--			  TEACHER.PULPIT [��� �������]
--	FROM TEACHER;

--2-Task--
--SELECT FACULTY.FACULTY [���������],
--	   count(PULPIT.PULPIT) [���������� ������]
--FROM FACULTY join PULPIT
--	 on FACULTY.FACULTY = PULPIT.FACULTY
--group by FACULTY.FACULTY;
--go
--CREATE VIEW [���������� ������]
--	as select FACULTY.FACULTY [���������],
--	   count(PULPIT.PULPIT) [���������� ������]
--	FROM FACULTY join PULPIT
--	 on FACULTY.FACULTY = PULPIT.FACULTY
--group by FACULTY.FACULTY;

--3-Task--

--SELECT AUDITORIUM.AUDITORIUM_TYPE [���],
--	   AUDITORIUM.AUDITORIUM_NAME [������������ ���������]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE LIKE 'LK%'


--go
--create VIEW ���������(���, [������������ ���������])
--	as select AUDITORIUM.AUDITORIUM_TYPE [���],
--	   AUDITORIUM.AUDITORIUM [������������ ���������]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE IN ('LK');


--INSERT ��������� values('LK', '200-3�');
--select * from ���������



--4-Task--
--SELECT AUDITORIUM.AUDITORIUM_TYPE [���],
--	   AUDITORIUM.AUDITORIUM_NAME [������������ ���������]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE in ('LK')

--go
--alter VIEW [����������_���������](���, [������������ ���������])
--	as select AUDITORIUM.AUDITORIUM_TYPE [���],
--	   AUDITORIUM.AUDITORIUM [������������ ���������]
--FROM AUDITORIUM
--where AUDITORIUM.AUDITORIUM_TYPE IN ('LK')
--WITH CHECK OPTION;


--INSERT [����������_���������] values ('LK', '200-3');
--select * from [����������_���������]

--5-Task--
--select  SUBJECT.PULPIT, SUBJECT.SUBJECT_NAME, SUBJECT.SUBJECT
--from SUBJECT
--order by SUBJECT_NAME

--go
--alter view ���������� (���, [������������ ����������], [��� �������])
--	as select top 150 SUBJECT.PULPIT,
--	   SUBJECT.SUBJECT_NAME,
--	   SUBJECT.SUBJECT
--FROM SUBJECT
--order by SUBJECT_NAME

--6-Task--

go
alter VIEW [���������� ������] with schemabinding
	as select FACULTY.FACULTY [���������],
	   count(PULPIT.PULPIT) [���������� ������]
	FROM dbo.FACULTY inner join dbo.PULPIT
	 on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY.FACULTY;