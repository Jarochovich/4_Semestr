use UNIVER;

-- 1 Task --
SET NOCOUNT ON   
if  exists (select * from  SYS.OBJECTS
        where OBJECT_ID= object_id(N'DBO.X'))              
drop table Tabl_1;
declare @argument int, @flag char = 'a';  

SET IMPLICIT_TRANSACTIONS  ON   
CREATE table Tabl_1(a char );                        
  INSERT Tabl_1 values ('a'),('b'),('c');
  set @argument = (select count(*) from Tabl_1);
  print N'количество строк в таблице: ' + cast( @argument as varchar(2));
  if @flag = 'a'  commit;                   
          else   rollback;                                
SET IMPLICIT_TRANSACTIONS  OFF
  
if  exists (select * from  SYS.OBJECTS      
          where OBJECT_ID= object_id(N'DBO.Tabl_1') )
print N'таблица X есть';  
    else print N'таблицы X нет'

-- 2 Task --
select * from FACULTY
--delete Faculty Where FACULTY = 'ISITi'
begin try
  begin transaction
  delete FACULTY Where FACULTY = 'ISITT';
  insert FACULTY values('PI', 'ProgerPI');
  insert FACULTY values('ISIT', 'ProgerISIT');
  commit transaction;
  end try
  begin catch
  print N'Ошибка: ' + case
  when error_number() = 2627
  then N'Дублирование'
  else N'Неизвестная ошибка' + cast(error_number() as varchar(5)) + error_message()
  end;
  if @@trancount > 0 rollback transaction;
  end catch;

-- 3 Task --
select * from FACULTY
delete Faculty Where FACULTY = 'ISIT'
declare @point varchar(32);
begin try
  begin transaction

  delete FACULTY Where FACULTY = 'ISITT';
  set @point = 'p1'; 
  save transaction @point;

  insert FACULTY values('PI3', 'ProgerPI');
  set @point = 'p2'; 
  save transaction @point;

  insert FACULTY values('ISIT', 'ProgerISIT');
  commit transaction;
  end try
  begin catch
  print N'Ошибка: ' + case
  when error_number() = 2627
  then N'Дублирование'
  else N'Неизвестная ошибка' + cast(error_number() as varchar(5)) + error_message()
  end;
  if @@trancount > 0
  begin 
  print N'Контрольная точка: ' + @point;
  rollback transaction @point;
  commit transaction;
  end;
  end catch;


-- 4 Task --
-- A
set transaction isolation level READ UNCOMMITTED
begin transaction
  -------------------------- t1 --------------------
select @@SPID, 'insert AUDITORIUM' N'Результат', * from AUDITORIUM
where AUDITORIUM.AUDITORIUM = '413-1';
select @@SPID, 'update AUDITORIUM' N'Результат', * from AUDITORIUM_TYPE 
where AUDITORIUM_TYPE.AUDITORIUM_TYPENAME = 'Computer Lab';
SELECT * FROM AUDITORIUM;
commit; 
  -------------------------- t2 --------------------

select * from AUDITORIUM;
--delete AUDITORIUM where AUDITORIUM.AUDITORIUM  =  '413-1'; 


-- 5 Task --

-- A
set transaction isolation level READ COMMITTED 
begin transaction 
select count(*) from AUDITORIUM where AUDITORIUM_TYPE = 'LB-K';
select * from AUDITORIUM
-------------------------- t1 ------------------ 
-------------------------- t2 ------------------
select count(*) from AUDITORIUM where AUDITORIUM_TYPE = 'LB-K';
commit;
select * from AUDITORIUM

update AUDITORIUM set AUDITORIUM_TYPE = 'LK'  where AUDITORIUM= '408-2'


-- 6 Task --
-- A
set transaction isolation level REPEATABLE READ 
begin transaction 
select AUDITORIUM_NAME from AUDITORIUM where AUDITORIUM_TYPE = 'LB-K';
-------------------------- t1 ------------------ 
-------------------------- t2 -----------------
COMMIT;
select AUDITORIUM_NAME from AUDITORIUM where AUDITORIUM_TYPE = 'LB-K';


-- 7 Task --
-- A
set transaction isolation level SERIALIZABLE 
begin transaction 
delete AUDITORIUM where AUDITORIUM_NAME = '418-2';  
    insert AUDITORIUM values ('418-2','LK', 90,  '418-2');
    update AUDITORIUM set AUDITORIUM_NAME = '423-1' where AUDITORIUM_NAME = '423-2';
    select  AUDITORIUM_NAME from AUDITORIUM  where AUDITORIUM_TYPE = 'LK';
-------------------------- t1 -----------------

select  * from AUDITORIUM;
-------------------------- t2 ------------------ 
commit;

-- 8 Task --
      
begin tran
insert AUDITORIUM values ('413-2','LK', 90,  '413-2');
begin tran
update AUDITORIUM_TYPE set AUDITORIUM_TYPENAME='Lek' where AUDITORIUM_TYPE='LK';
commit;
print @@TRANCOUNT;
if @@TRANCOUNT = 0 rollback;
select
(select count(*) from AUDITORIUM where  AUDITORIUM='413-2')'AUDITORIUM',
(select count(*) from AUDITORIUM_TYPE where  AUDITORIUM_TYPENAME='Lek')'AUDITORIUM_TYPENAME'

select * from AUDITORIUM;

delete AUDITORIUM where AUDITORIUM='413-2'