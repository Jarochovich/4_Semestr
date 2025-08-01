use UNIVER;

select FACULTY.FACULTY as Факультет,
	   PULPIT.PULPIT_NAME as Кафедра,
	   GROUPS.PROFESSION as Специальность,
	   SUBJECT.SUBJECT_NAME as Дисциплина,
	   STUDENT.NAME as Студент,
	Case 
	when (PROGRESS.NOTE = 6) then 'Шесть'
	when (PROGRESS.NOTE = 7) then 'Семь'
	when (PROGRESS.NOTE = 8) then 'Восемь'
	end Оценка
from PROGRESS
	Inner Join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
	Inner Join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
	Inner Join SUBJECT on PROGRESS.SUBJECT = SUBJECT.SUBJECT
	Inner Join PULPIT on SUBJECT.PULPIT = PULPIT.PULPIT
	Inner Join FACULTY on PULPIT.FACULTY = FACULTY.FACULTY

where PROGRESS.NOTE between 6 AND 8
order by PROGRESS.NOTE DESC