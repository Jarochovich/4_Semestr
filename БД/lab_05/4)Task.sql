use UNIVER;

Select AUDITORIUM_NAME as Аудитория, AUDITORIUM_CAPACITY as Вместимость, AUDITORIUM_TYPE as Тип
	From AUDITORIUM a
	where AUDITORIUM_CAPACITY = (select top(1) AUDITORIUM_CAPACITY from AUDITORIUM aa
											where a.AUDITORIUM_TYPE = aa.AUDITORIUM_TYPE
																				order by AUDITORIUM_CAPACITY desc);