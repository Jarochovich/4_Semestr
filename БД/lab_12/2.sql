use UNIVER;

-- 4 Task --
-- B
set transaction isolation level READ UNCOMMITTED
begin transaction
select @@SPID
--insert dbo.AUDITORIUM values ('408-2','LB-K',20,'408-2');
update AUDITORIUM set AUDITORIUM.AUDITORIUM_NAME  =  '413-1' 
where AUDITORIUM.AUDITORIUM  =  '413-1'       
SELECT * FROM AUDITORIUM;

  -------------------------- t1 --------------------
  -------------------------- t2 --------------------
rollback;
 
--delete AUDITORIUM where AUDITORIUM.AUDITORIUM  =  '413-1'; 
--select * from AUDITORIUM;


-- 5 Task --
-- B
begin transaction     
-------------------------- t1 --------------------
update AUDITORIUM set AUDITORIUM_TYPE = 'LK' where AUDITORIUM.AUDITORIUM = '408-2' 
--commit;
ROLLBACK
--commit
select * from AUDITORIUM
-------------------------- t2 --------------------  
            
update AUDITORIUM set AUDITORIUM_TYPE = 'LB-K'  where AUDITORIUM= '408-2'
select * from AUDITORIUM


-- 6 Task --
-- B 
set transaction isolation level READ COMMITTED
begin transaction     
-------------------------- t1 --------------------
    --insert AUDITORIUM values ( '200-2',  'LB-K',  60,   '200-2');
	update AUDITORIUM set AUDITORIUM_NAME  =  '206-1' where AUDITORIUM_NAME= '206-2'
	select AUDITORIUM_NAME from AUDITORIUM where AUDITORIUM_TYPE = 'LB-K';
    commit; 
-------------------------- t2 --------------------

DELETE AUDITORIUM where AUDITORIUM= '200-2'


-- 7 Task --  
-- B
set transaction isolation level  READ COMMITTED 
begin transaction 
delete AUDITORIUM where AUDITORIUM_NAME = '419-2';
insert AUDITORIUM values ('419-2','LK', 90,  '419-2');
update AUDITORIUM set AUDITORIUM_NAME = '423-1' where AUDITORIUM_NAME = '423-2';
select  AUDITORIUM_NAME from AUDITORIUM  where AUDITORIUM_TYPE = 'LK';
--rollback
-------------------------- t1 --------------------
commit; 
select  AUDITORIUM_NAME from AUDITORIUM  where AUDITORIUM_TYPE = 'LK';
-------------------------- t2 --------------------
select * from AUDITORIUM

delete AUDITORIUM where AUDITORIUM='408-2'
delete AUDITORIUM where AUDITORIUM='419-2'