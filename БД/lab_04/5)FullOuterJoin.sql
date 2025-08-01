use UNIVER;

select isnull(STUDENT.NAME, '***') as Имя,
	   GROUPS.IDGROUP as Группа
from  STUDENT Full Outer Join GROUPS  on STUDENT.IDGROUP = GROUPS.IDGROUP
where STUDENT.IDGROUP is not Null

select isnull(STUDENT.NAME, '***') as Имя,
		GROUPS.IDGROUP as Группа
from GROUPS left outer join STUDENT on STUDENT.IDGROUP = GROUPS.IDGROUP

select isnull(STUDENT.NAME, '***') as Имя,
		GROUPS.IDGROUP as Группа
from STUDENT right outer join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP