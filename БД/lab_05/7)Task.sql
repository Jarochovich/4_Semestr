use UNIVER;

Select NOTE, SUBJECT From PROGRESS
	Where NOTE >=all (Select NOTE From PROGRESS
				   Where NOTE = 6);