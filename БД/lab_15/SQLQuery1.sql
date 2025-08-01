use UNIVER;

-- 1-Task --
go

drop table TR_AUDIT;
delete teacher where TEACHER='DGO'

go

create table TR_AUDIT(
ID int identity,	-- номер 
STMT varchar(20) check (STMT in ('INS','DEL','UPD')),	-- DML-оператор
TRNAME varchar(50),	-- имя тригера
CC varchar(300))	-- комментарий

go

create trigger TR_TEACHER_INS on TEACHER
	after INSERT
as declare @a1 varchar(20), @a2 varchar(60), @a3 varchar(1), @a4 varchar(60), @in varchar(300);
print 'ACTIVATE TRIGGER: INSERT';
set @a1 =(select [teacher] from INSERTED);
set @a2 =(select [TEACHER_NAME] from INSERTED);
set @a3 =(select [GENDER] from INSERTED);
set @a4 =(select [PULPIT] from INSERTED);
set @in= @a1 + ' ' + @a2 + ' ' + @a3 + ' ' + @a4
insert into TR_AUDIT (STMT,TRNAME,CC) values ('INS',' TR_TEACHER_INS',@in);
return;

drop trigger TR_TEACHER_INS

insert into TEACHER values ('DGO','David Gogings Olegovich','M','ISIT');
select * from TR_AUDIT;

-- 2-Task --
go

create trigger TR_TEACHER_DEL on TEACHER
	AFTER DELETE
as declare @a1 varchar(20), @a2 varchar(60), @a3 varchar(1), @a4 varchar(60), @in varchar(300);
begin
	print 'ACTIVATE TRIGGER: DELETE';
	set @a1 =(select [teacher] from deleted);
	set @a2 =(select [TEACHER_NAME] from deleted);
	set @a3 =(select [GENDER] from deleted);
	set @a4 =(select [PULPIT] from deleted);
	set @in= @a1 + ' ' + @a2 + ' ' + @a3 + ' ' + @a4;

	insert into TR_AUDIT (STMT,TRNAME,CC) values ('DEL',' TR_TEACHER_DEL',@in);
	return;
end;

drop trigger TR_TEACHER_DEL

delete from TEACHER where TEACHER.TEACHER = 'DGO';
select * from TR_AUDIT;


-- 3-Task --
go

create trigger TR_TEACHER_UPD on TEACHER
	AFTER UPDATE
as declare @a1 varchar(20), @a2 varchar(60), @a3 varchar(1), @a4 varchar(60), @in varchar(300);
begin
	print 'ACTIVATE TRIGGER: UPDATE';
	set @a1 =(select [teacher] from deleted);
	set @a2 =(select [TEACHER_NAME] from deleted);
	set @a3 =(select [GENDER] from deleted);
	set @a4 =(select [PULPIT] from deleted);
	set @in= @a1 + ' ' + @a2 + ' ' + @a3 + ' ' + @a4;

	insert into TR_AUDIT (STMT,TRNAME,CC) values ('UPD',' TR_TEACHER_UPD',@in);
	return;
end;

drop trigger TR_TEACHER_UPD

insert into TEACHER values ('DGO','David Gogings Olegovich','M','ISIT');
update TEACHER set TEACHER.TEACHER_NAME = 'David Gogings2 Olegovich3' where TEACHER.TEACHER = 'DGO';
select * from TR_AUDIT;

-- 4-Task--
go
create trigger TR_TEACHER on TEACHER after INSERT, DELETE, UPDATE  
as declare @a1 varchar(20),@a2 varchar(60),@a3 varchar(1),@a4 varchar(60),@in varchar(300);
declare @ins int = (select count(*) from inserted),
              @del int = (select count(*) from deleted); 
if  @ins > 0 and  @del = 0 
begin
print 'ACTIVATE TRIGGER: INSERT'
set @a1 =(select [teacher] from INSERTED);
set @a2 =(select [TEACHER_NAME] from INSERTED);
set @a3 =(select [GENDER] from INSERTED);
set @a4 =(select [PULPIT] from INSERTED);
set @in= @a1 + ' ' + @a2 + ' ' + @a3 + ' ' + @a4;
insert into TR_AUDIT (STMT,TRNAME,CC) values ('INS', ' TR_TEACHER', @in);
end
else
if 
@ins = 0 and  @del > 0  
begin 
print 'ACTIVATE TRIGGER: DELETE'
set @a1 =(select [teacher] from deleted);
set @a2 =(select [TEACHER_NAME] from deleted);
set @a3 =(select [GENDER] from deleted);
set @a4 =(select [PULPIT] from deleted);
set @in=@a1 +' ' +@a2 +' '+@a3 +' '+@a4
insert into TR_AUDIT (STMT,TRNAME,CC) values ('DEL',' TR_TEACHER',@in);
end;
else 
if @ins > 0 and  @del > 0  
begin
print 'ACTIVATE TRIGGER: UPDATE'
set @a1 =(select [teacher] from inserted);
set @a2 =(select [TEACHER_NAME] from inserted);
set @a3 =(select [GENDER] from inserted);
set @a4 =(select [PULPIT] from inserted);
set @in=@a1 +' ' +@a2 +' '+@a3 +' '+@a4
set @a1 =(select [teacher] from deleted);
set @a2 =(select [TEACHER_NAME] from deleted);
set @a3 =(select [GENDER] from deleted);
set @a4 =(select [PULPIT] from deleted);
set @in=@a1 +' ' +@a2 +' '+@a3 +' '+@a4+@in
insert into TR_AUDIT (STMT,TRNAME,CC) values ('UPD',' TR_TEACHER',@in);
end
return;

insert into TEACHER values ('TEST','Test Testing Testovich','M','ISIT')
update  TEACHER set TEACHER.TEACHER='TEST1' where TEACHER.TEACHER='TEST'
delete  TEACHER where  TEACHER.TEACHER='TEST1'
select * from TR_AUDIT
go


-- 5-Task --
alter table TEACHER  add constraint CHK_TEACHER_LENGTH  check (len(TEACHER.TEACHER)<=9)
go
insert into TEACHER values ('TEST','Test Testing Testovich','M','ISIT')
update  TEACHER set TEACHER.TEACHER='UPDATE TEST' where TEACHER.TEACHER='TEST'


-- 6-Task--
go

create trigger TR_TEACHER_DEL1 on
TEACHER after Delete
as declare @a1 varchar(20),@a2 varchar(60),@a3 varchar(1),@a4 varchar(60),@in varchar(300);
print 'ACTIVATE TRIGGER: DELETE 1'
set @a1 =(select [teacher] from deleted);
set @a2 =(select [TEACHER_NAME] from deleted);
set @a3 =(select [GENDER] from deleted);
set @a4 =(select [PULPIT] from deleted);
set @in=@a1 +' ' +@a2 +' '+@a3 +' '+@a4
insert into TR_AUDIT (STMT,TRNAME,CC) values ('DEL',' TR_TEACHER_DEL1',@in);
return;
go

create trigger TR_TEACHER_DEL2 on
TEACHER after Delete
as declare @a1 varchar(20),@a2 varchar(60),@a3 varchar(1),@a4 varchar(60),@in varchar(300);
print 'ACTIVATE TRIGGER: DELETE 2'
set @a1 =(select [teacher] from deleted);
set @a2 =(select [TEACHER_NAME] from deleted);
set @a3 =(select [GENDER] from deleted);
set @a4 =(select [PULPIT] from deleted);
set @in=@a1 +' ' +@a2 +' '+@a3 +' '+@a4
insert into TR_AUDIT (STMT,TRNAME,CC) values ('DEL',' TR_TEACHER_DEL2',@in);
return;

go

create trigger TR_TEACHER_DEL3 on
TEACHER after Delete
as declare @a1 varchar(20),@a2 varchar(60),@a3 varchar(1),@a4 varchar(60),@in varchar(300);
print 'ACTIVATE TRIGGER: DELETE 3'
set @a1 =(select [teacher] from deleted);
set @a2 =(select [TEACHER_NAME] from deleted);
set @a3 =(select [GENDER] from deleted);
set @a4 =(select [PULPIT] from deleted);
set @in = @a1 + ' ' + @a2 + ' ' + @a3 + ' ' + @a4
insert into TR_AUDIT (STMT,TRNAME,CC) values ('DEL',' TR_TEACHER_DEL3',@in);
return;

go

--drop trigger TR_TEACHER_DEL3;

select t.name,e.type_desc
from sys.triggers t join sys.trigger_events e
on
t.object_id =e.object_id
where OBJECT_NAME(t.parent_id)='TEACHER' and e.type_desc ='DELETE'

exec sp_settriggerorder @triggername='TR_TEACHER_DEL3', @order='First', @stmttype ='DELETE';
exec sp_settriggerorder @triggername='TR_TEACHER_DEL2', @order='Last', @stmttype ='DELETE';

delete  TEACHER where  TEACHER.TEACHER='TEST'

select * from TR_AUDIT


-- 7-Task --
go
alter trigger TEACH_TRAN
on teacher after insert, delete, update
as declare @c int =(select count(TEACHER) from TEACHER);
if @c>10
begin
raiserror('должно быть меньше преподавателей < 10',10,1);
rollback
end;
return;





update TEACHER set TEACHER = 'TSTST' where TEACHER='DGO'

--select * From TEACHER;

go


-- 8-Task--
go
create trigger Teach_INSTEAD_OF
on teacher instead of delete
as raiserror(N'Удаление запрещено!', 10, 1);
return;

go
delete TEACHER  from TEACHER where TEACHER='TEST'

-- удаление все триггеров
drop trigger TR_TEACHER_INS;
drop trigger TR_TEACHER_DEL;
drop trigger TR_TEACHER_UPD;
drop trigger TR_TEACHER;
drop trigger TR_TEACHER_DEL1
drop trigger TR_TEACHER_DEL2
drop trigger TR_TEACHER_DEL3
drop trigger Teach_INSTEAD_OF

-- 9-Task --
go
drop trigger DDL_STUDENT on database

go
create trigger DDL_STUDENT on database 
for DDL_DATABASE_LEVEL_EVENTS as
begin
  declare @t varchar(50)= EVENTDATA().value('(/EVENT_INSTANCE/EventType)[1]', 'varchar(50)');
  declare @t1 varchar(50) = EVENTDATA().value('(/EVENT_INSTANCE/ObjectName)[1]', 'varchar(50)');
  declare @t2 varchar(50) = EVENTDATA().value('(/EVENT_INSTANCE/ObjectType)[1]', 'varchar(50)'); 
  if @t1 = 'STUDENT' 
  begin
	print 'Тип события ' + @t;
	print 'Имя объекта ' + @t1;
	print 'Тип объекта ' + @t2;
	raiserror(N'операции с таблицей STUDENT запрещены! ', 16, 1);
	rollback;
   end;
end;

alter table STUDENT drop column FOTO;