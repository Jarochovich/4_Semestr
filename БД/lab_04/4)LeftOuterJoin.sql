use UNIVER;

select PULPIT.PULPIT as �������,
	   isnull (TEACHER.TEACHER_NAME, '***') as �������������
from PULPIT Left Outer Join TEACHER
	on PULPIT.PULPIT = TEACHER.PULPIT