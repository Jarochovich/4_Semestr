use UNIVER;

Select top 1
	(select avg(Note) from PROGRESS
		where SUBJECT like 'OAP') [OAP],
	(select avg(Note) From PROGRESS
		where SUBJECT like 'DB') [DB],
	(select avg(Note) From PROGRESS
		where SUBJECT like 'KG') [KG];