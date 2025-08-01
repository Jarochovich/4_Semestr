use UNIVER;

-- 1 Task --
go
DECLARE @p varchar(20) = 'ISIT';
DECLARE @c int = 0;
DECLARE @quantityRows INT;
EXEC @quantityRows = PSUBJECT @p, @c OUTPUT;
PRINT 'КОЛИЧЕСТВО СТРОК = ' + cast(@quantityRows as nvarchar(10));

-- 2 Task --
-- СДЕЛАЛЬ

-- 3 - Task --
alter procedure PSUBJECT 
			@p varchar(20)
as
begin
	declare @k int = (select COUNT(*) from SUBJECT )
	select * from SUBJECT where  PULPIT=@p;
end;

go

create table #SUBJECT
	(Subject nvarchar(10),Subject_name nvarchar(100),Pulpit nvarchar(10))
	insert into #SUBJECT exec PSUBJECT @p='ISIT';
select * from #SUBJECT

drop table  #SUBJECT

-- 4-Task --
create procedure PAUDITORIUM_INSERT
			@a char(20),
			@n varchar(50),
			@c int = 0,
			@t char(10)
as
begin
	begin try
		insert AUDITORIUM values (@a, @t, @c, @n);
		select * from AUDITORIUM;
		return 1;
	end try
	begin catch
		print 'номер ошибки: ' + cast(error_number() as varchar(6));
		print 'сообщение:' +error_message();
		print 'уровень:' +cast(error_severity() as varchar(6));
		print 'метка:' +cast(error_state() as varchar(6));
		print 'номер строки:' +cast(error_line() as varchar(8));
		if ERROR_PROCEDURE() is not null
		print 'имя процедуры:' +error_procedure()
		return -1;
	end catch
end
go
declare @rc int;
exec @rc = PAUDITORIUM_INSERT @a = '100-1', @n = '100-1', @c = 90, @t = 'LK';

if @rc = -1
begin
	print 'error message: ' + cast(@rc as varchar(5));
end;
drop procedure PAUDITORIUM_INSERT;

-- 5-Task --

create procedure SUBJECT_REPORT	
			@p char(10)
as
begin try
	declare @buf varchar(20);
	declare @result varchar(300) = '';
	declare @count int = 0;

	declare ListSubject cursor for
		select SUBJECT from SUBJECT where PULPIT = @p;
	print 'Список дисциплин';
	open ListSubject;
	fetch ListSubject into @buf;

	while @@FETCH_STATUS = 0
	begin
		set @result = RTRIM(@buf) + ',' + @result;
		set @count = @count + 1;
		fetch ListSubject into @buf;
	end
	print @result;
	close ListSubject;
	DEALLOCATE ListSubject;

	return @count;
end try
begin catch
	print 'ошибка в параметрах'
	if ERROR_PROCEDURE() is not null
		print 'имя процедуры: ' + error_procedure();
	return @count;
end catch;

drop procedure SUBJECT_REPORT;

go

declare @rc int;
exec @rc = SUBJECT_REPORT @p = 'ISIT';
print 'Количество дисциплин: ' + cast(@rc as varchar (5));



-- 6-Task --
create procedure PAUDITORIUM_INSERTX
			@a char(20),
			@n varchar(50),
			@c int = 0,
			@t char(10),
			@tn varchar(50)
as declare @rc int = 1;
begin try
	insert AUDITORIUM_TYPE values (@t, @tn);
	exec @rc = PAUDITORIUM_INSERT @a, @n, @c, @t;

	return @rc;
end try
begin catch
	print 'номер строки: ' + cast(error_number() as varchar(6))
	print 'сообщение: ' + error_message();
	print 'уровень' + cast(error_severity() as varchar(6));
	print 'метка' + cast(error_state() as varchar(8));
	print 'номер строки' + cast(error_line() as varchar(8));
	return -1;
end catch

go

drop procedure PAUDITORIUM_INSERTX;

declare @rc int;
exec @rc = PAUDITORIUM_INSERTX @a = '500-1', @n = '500-1', @c = 90, @t = 'LK-s', @tn = 'Lection s rang';