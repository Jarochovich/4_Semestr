use UNIVER;

Select NOTE, SUBJECT From PROGRESS
	Where NOTE >=any (Select NOTE From PROGRESS
				   Where NOTE = 6);