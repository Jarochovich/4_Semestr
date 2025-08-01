CREATE VIEW [Количество кафедр]
	as select FACULTY.FACULTY [Факультет],
	   count(PULPIT.PULPIT) [Количество кафедр]
	FROM FACULTY join PULPIT
	 on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY.FACULTY;