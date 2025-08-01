use UNIVER;

-- 1-Task--
go
create function COUNT_STUDENTS (@faculty varchar(20)) returns int
as
begin
	declare @rc int = 0;
	set @rc = (select count(*) from 
				STUDENT s join GROUPS g on s.IDGROUP = g.IDGROUP 
				where g.FACULTY = @faculty);
	return @rc;
end

go

declare @f int = dbo.COUNT_STUDENTS('IT');
print 'Количество студентов на факультете = ' + cast(@f as varchar(5));

go

ALTER function COUNT_STUDENTS(
    @faculty varchar(20) = NULL, 
    @prof varchar(20) = NULL
) returns int
as 
begin 
    declare @rc int = 0;
    
    set @rc = (
        select count(STUDENT.NAME) 
        from STUDENT 
        join GROUPS on STUDENT.IDGROUP = GROUPS.IDGROUP
        join FACULTY on FACULTY.FACULTY = GROUPS.FACULTY 
        where (FACULTY.FACULTY = @faculty OR @faculty IS NULL)
          AND (GROUPS.PROFESSION = @prof OR @prof IS NULL)
    );
    
    return @rc;
end;
go

declare @f int=dbo.COUNT_STUDENTS('IT','1-40 01 02')
print 'Студенты (шт): '+cast(@f as varchar(10));
go
        
SELECT 
    FACULTY.FACULTY,
    GROUPS.PROFESSION,
    dbo.COUNT_STUDENTS(FACULTY.FACULTY, GROUPS.PROFESSION)
FROM FACULTY
JOIN GROUPS ON FACULTY.FACULTY = GROUPS.FACULTY;

-- 2-Task --
go

create function FSUBJECTS (@p varchar(20)) returns varchar(300)
as
begin
	declare @buff char(20);
	declare @result varchar(300) = 'Дисциплины: ';
	declare ListSubj CURSOR LOCAL
		for select SUBJECT.SUBJECT from SUBJECT
									where SUBJECT.PULPIT = @p;
	open ListSubj;
	fetch ListSubj into @buff;
	while @@FETCH_STATUS = 0
	begin
		set @result = @result + ',' + RTRIM(@buff);
		fetch ListSubj into @buff;
	end;

	return @result;
end;

go

select PULPIT, dbo.FSUBJECTS(PULPIT) from PULPIT;


-- 3-Task--
go

create function FFACPUL(@f varchar(50) null ,@p varchar(50) null) returns table
as return 
select FACULTY.FACULTY, PULPIT.PULPIT from FACULTY inner join PULPIT 
on FACULTY.FACULTY = PULPIT.FACULTY WHERE 
        (@f IS NULL OR FACULTY.FACULTY = @f) AND
        (@p IS NULL OR PULPIT.PULPIT = @p);

		go

SELECT * FROM dbo.FFACPUL(DEFAULT, DEFAULT);

SELECT * FROM dbo.FFACPUL('TTLP', NULL);

SELECT * FROM dbo.FFACPUL(NULL, 'ISIT');

SELECT * FROM dbo.FFACPUL('IT', 'ISIT');

SELECT * FROM dbo.FFACPUL('HTIT', 'ISIT');


-- 4-Task--
go

create function FCTEACHER (@p varchar (20)) returns int
as
begin
	declare @rc int = (select count(TEACHER.TEACHER) from TEACHER
		where TEACHER.PULPIT = isnull(@p, TEACHER));
	return @rc;
end

--drop function FCTEACHER;
go

select PULPIT, dbo.FCTEACHER(PULPIT) [Количество преподавателей] from PULPIT;
select dbo.FCTEACHER(NULL) [Всего преподавателей];

-- 5-Task --
-- в своей бд

-- 6-Task--
go
create function GET_GROUP_SIZE(@group_name varchar(10)) returns int
as begin declare @rc int =0
set @rc=(select count(STUDENT.NAME) from STUDENT inner join GROUPS
on STUDENT.IDGROUP=GROUPS.IDGROUP where (GROUPS.PROFESSION=@group_name));
return @rc;
end;
go

SELECT dbo.GET_GROUP_SIZE('1-37 06 01') AS [count of stud];


go
create function GET_TEACHERS_BY_PULPIT(@pulpit_name varchar(50) null) returns table
as return
select TEACHER.TEACHER_NAME from TEACHER inner join PULPIT
on TEACHER.PULPIT=PULPIT.PULPIT where PULPIT.PULPIT=isnull(@pulpit_name,PULPIT.PULPIT)
go

SELECT * FROM dbo.GET_TEACHERS_BY_PULPIT('ISIT');
SELECT * FROM dbo.GET_TEACHERS_BY_PULPIT(NULL);

go
create function GET_SUBJECTS_LIST( @teacher varchar(100)) returns varchar(300)
as begin
declare @tv varchar(30)
declare @t varchar(300)='Subj: ';

declare KL CURSOR LOCAL 
for SELECT SUBJECT.SUBJECT from SUBJECT inner join TEACHER 
on TEACHER.PULPIT=SUBJECT.PULPIT where TEACHER.TEACHER=@teacher
open KL
fetch KL into @tv;
while @@FETCH_STATUS=0
begin
set @t= @t+', '+rtrim(@tv)
fetch KL into @tv;
end;
return @t;
end;
go

 SELECT dbo.GET_SUBJECTS_LIST('GRN')

  drop Function GET_SUBJECTS_LIST