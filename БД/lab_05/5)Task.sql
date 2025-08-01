use UNIVER;

Select FACULTY.FACULTY as Факультет
	From FACULTY
	Where not EXISTS (Select * from PULPIT
		Where FACULTY.FACULTY = PULPIT.FACULTY) 