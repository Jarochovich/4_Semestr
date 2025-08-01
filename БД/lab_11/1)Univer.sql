USE UNIVER;

--1-Task--
DECLARE @sub char(20), @result char(300) = '';

DECLARE SBJCT CURSOR 
	for SELECT SUBJECT.SUBJECT from SUBJECT;

OPEN SBJCT;
FETCH SBJCT into @sub;
print 'Дисциплины на кафедре ИСиТ';
while @@FETCH_STATUS = 0
	begin
		set @result = RTRIM(@sub) + ',' + @result;
		FETCH SBJCT into @sub;
	end;
print @result;
DEALLOCATE SBJCT;
CLOSE SBJCT;

--2-Task--
DECLARE Students CURSOR LOCAL 
				 for SELECT STUDENT.IDSTUDENT, STUDENT.NAME from STUDENT;
DECLARE @id int;
DECLARE @name char(30);      
	OPEN Students;	  
	fetch  Students into  @id, @name; 	
      print cast(@id as varchar(20)) + ': ' + @name;   
      go
 DECLARE @name char(20), @id int;     	
	fetch  Students into @id, @name ; 	
      print @name+cast(@id as varchar(6));  
  go



DECLARE Students CURSOR GLOBAL 
				 for SELECT STUDENT.IDSTUDENT, STUDENT.NAME from STUDENT;
DECLARE @id int, @name char(30);
	OPEN Students;	  
	fetch  Students into  @id, @name; 	
      print cast(@id as varchar(20)) + ': ' + @name;   
      go
 DECLARE @name char(30), @id int;     	
	fetch  Students into  @id, @name; 	
      print cast(@id as varchar(20)) + ': ' + @name;   
	  CLOSE Students;
	  deallocate Students;
  go

--3-Task--
DECLARE @tid char(10), @tnm char(20), @tgn char(30);  
	DECLARE Studak CURSOR LOCAL STATIC                              
		 for SELECT STUDENT.IDGROUP, STUDENT.IDSTUDENT, STUDENT.NAME 
		       FROM dbo.STUDENT where STUDENT.IDGROUP = 4;				   
	open Studak;
	print 'Количество строк : '+cast(@@CURSOR_ROWS as varchar(5)); 
    UPDATE STUDENT set NAME='Мамба-Стасямба' where IDSTUDENT = 1009;
	DELETE STUDENT where IDSTUDENT = 1010;
	INSERT STUDENT (IDGROUP, NAME,    
                                BDAY, STAMP, INFO, FOTO) 
	                 values (4, 'General Gaws', ('22-03-2023'), null, null, null); 
	FETCH  Studak into @tid, @tnm, @tgn;     
	while @@fetch_status = 0                                    
      begin 
          print @tid + ' '+ @tnm + ' '+ @tgn;      
          fetch Studak into @tid, @tnm, @tgn; 
       end;          
   CLOSE  Studak;

   go

   DECLARE @tid char(10), @tnm char(20), @tgn char(30);  
	DECLARE Studak CURSOR LOCAL DYNAMIC                              
		 for SELECT STUDENT.IDGROUP, STUDENT.IDSTUDENT, STUDENT.NAME 
		       FROM dbo.STUDENT where STUDENT.IDGROUP = 4;				   
	open Studak;
	print 'Количество строк : '+cast(@@CURSOR_ROWS as varchar(5)); 
    UPDATE STUDENT set NAME='Мамба-Стасямба' where IDSTUDENT = 1009;
	DELETE STUDENT where IDSTUDENT = 1010;
	INSERT STUDENT (IDGROUP, NAME,    
                                BDAY, STAMP, INFO, FOTO) 
	                 values (4, 'General Gaws', ('22-03-2023'), null, null, null); 
	FETCH  Studak into @tid, @tnm, @tgn;     
	while @@fetch_status = 0                                    
      begin 
          print @tid + ' '+ @tnm + ' '+ @tgn;      
          fetch Studak into @tid, @tnm, @tgn; 
       end;          
   CLOSE  Studak;
   go

--4-Task--
DECLARE  @tc int, @rn char(50);  
         DECLARE Primer1 cursor local dynamic SCROLL                               
               for SELECT row_number() over (order by STUDENT.NAME) N,
	                           STUDENT.NAME FROM dbo.STUDENT 
									where STUDENT.IDGROUP = 2 
	OPEN Primer1;
	FETCH  Primer1 into  @tc, @rn;                 
	print 'следующая строка: ' + cast(@tc as varchar(3))+ ' '+ rtrim(@rn);

	FETCH  NEXT from  Primer1 into @tc, @rn;       
	print 'Еще следующая строка: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);

	FETCH  ABSOLUTE 3 from  Primer1 into @tc, @rn;       
	print '3 строка: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);

	FETCH  ABSOLUTE -2 from  Primer1 into @tc, @rn;       
	print '2-ая с конца строка: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);  

	FETCH  LAST from  Primer1 into @tc, @rn;       
	print 'последняя строка: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);      

	FETCH  RELATIVE -2 from  Primer1 into @tc, @rn;       
	print '2 строки назад от текущей: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);  

	FETCH  PRIOR from  Primer1 into @tc, @rn;       
	print 'Предыдущая строка от текущей: ' +  cast(@tc as varchar(3))+ ' ' + rtrim(@rn);  

    CLOSE Primer1;
	go

--5-AND-6-Task--
DECLARE @ti char(20), @tc int, @tk int;
DECLARE Primer2 CURSOR local dynamic
	for select PROGRESS.IDSTUDENT, STUDENT.NAME, PROGRESS.NOTE from PROGRESS
	inner join STUDENT on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
	inner join GROUPS on GROUPS.IDGROUP = STUDENT.IDGROUP
	WHERE PROGRESS.NOTE < 4 FOR UPDATE;

OPEN Primer2;
FETCH Primer2 into @tc, @ti, @tk;
DELETE PROGRESS where CURRENT OF Primer2;

FETCH Primer2 into @tc, @ti, @tk;
UPDATE PROGRESS set NOTE = NOTE + 1 where IDSTUDENT = 1020;

CLOSE Primer2;
