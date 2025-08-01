use UNIVER;

select PULPIT.PULPIT as Кафедра,
	   isnull (TEACHER.TEACHER_NAME, '***') as Преподаватель
from PULPIT Left Outer Join TEACHER
	on PULPIT.PULPIT = TEACHER.PULPIT