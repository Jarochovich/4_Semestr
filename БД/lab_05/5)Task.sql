use UNIVER;

Select FACULTY.FACULTY as ���������
	From FACULTY
	Where not EXISTS (Select * from PULPIT
		Where FACULTY.FACULTY = PULPIT.FACULTY) 