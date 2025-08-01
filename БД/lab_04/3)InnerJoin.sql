use UNIVER;

select FACULTY.FACULTY as ���������,
	   PULPIT.PULPIT_NAME as �������,
	   GROUPS.PROFESSION as �������������,
	   SUBJECT.SUBJECT_NAME as ����������,
	   STUDENT.NAME as �������,
	Case 
	when (PROGRESS.NOTE = 6) then '�����'
	when (PROGRESS.NOTE = 7) then '����'
	when (PROGRESS.NOTE = 8) then '������'
	end ������
from PROGRESS
	Inner Join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
	Inner Join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
	Inner Join SUBJECT on PROGRESS.SUBJECT = SUBJECT.SUBJECT
	Inner Join PULPIT on SUBJECT.PULPIT = PULPIT.PULPIT
	Inner Join FACULTY on PULPIT.FACULTY = FACULTY.FACULTY

where PROGRESS.NOTE between 6 AND 8
order by PROGRESS.NOTE DESC