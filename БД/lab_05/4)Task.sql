use UNIVER;

Select AUDITORIUM_NAME as ���������, AUDITORIUM_CAPACITY as �����������, AUDITORIUM_TYPE as ���
	From AUDITORIUM a
	where AUDITORIUM_CAPACITY = (select top(1) AUDITORIUM_CAPACITY from AUDITORIUM aa
											where a.AUDITORIUM_TYPE = aa.AUDITORIUM_TYPE
																				order by AUDITORIUM_CAPACITY desc);