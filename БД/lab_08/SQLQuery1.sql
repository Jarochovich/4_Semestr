CREATE VIEW [���������� ������]
	as select FACULTY.FACULTY [���������],
	   count(PULPIT.PULPIT) [���������� ������]
	FROM FACULTY join PULPIT
	 on FACULTY.FACULTY = PULPIT.FACULTY
group by FACULTY.FACULTY;