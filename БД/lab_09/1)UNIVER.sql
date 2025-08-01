use UNIVER;

--1-Task--

DECLARE @c char = 'S',
		@v varchar(4) = '����',
		@d datetime,
		@t time(2)
		
SET @d = getdate();
SET @t = '12:34:54';

SELECT @c c, @v v, @d d

DECLARE @h TABLE
			(i int default 2147483647,
			 s smallint default 32767,
			 tint tinyint default 255,
			 n numeric(12, 5) default 123.15
			);
INSERT @h default values; -- ���������� ������ � ��������� ����������

SELECT * FROM @h;

print 'v = ' + cast(@v as varchar(10));

--2-Task--

DECLARE @���������� int = (select sum(AUDITORIUM.AUDITORIUM_CAPACITY) from AUDITORIUM);
DECLARE @y int = (select cast(COUNT(*) as numeric) from AUDITORIUM)
DECLARE @y1 int = (select cast(AVG(AUDITORIUM_CAPACITY) as numeric) from AUDITORIUM)
DECLARE @y2 int = (select cast(COUNT(*) as numeric) from AUDITORIUM where AUDITORIUM.AUDITORIUM_CAPACITY < @y1);
DECLARE @y3 float = (@y2 * 100.0) /  @y;

IF @���������� > 200
	begin
		SELECT @y '���������� ���������', 
			   @y1 '������� �����������', 
			   @y2 '���������� ���������, ����������� ������� ������ �������',
			   @y3 '������� ���������, ����������� ������� ������ �������';
	end
ELSE print '����������� ���������: ' + cast(@���������� as varchar(10));

--3--Task--

print '����� ������������ ����� = ' + cast(@@ROWCOUNT as varchar);
print '������ SQL Server = '  + cast(@@VERSION as varchar); ;
print '��������� ������������� ��������, ����������� �������� �������� ����������� = ' + cast(@@SPID as varchar);
print '��� ��������� ������ = ' + cast(@@ERROR as varchar);
print '��� ������� = ' + cast(@@SERVERNAME as varchar);
print '������� ����������� ���������� = ' + cast(@@TRANCOUNT  as varchar);
print '��������� ���������� ����� ��������������� ������ = ' + cast(@@FETCH_STATUS  as varchar);
print '������� ����������� ������� ��������� = ' + cast(@@NESTLEVEL  as varchar);

--4--Task--

--a)
DECLARE @tt float = 1, @x float = 1, @z float;
	IF (@tt > @x)		SET @z = power(sin(@tt), 2);
	else if (@tt < @x)	SET @z = 4*(@tt+@x);
	else if (@tt = @x)	SET @z = 1 - exp(@x - 2);
PRINT 'Z = ' + cast(@z as varchar(10));

--�)
SELECT 
    LEFT(STUDENT.NAME, CHARINDEX(' ', STUDENT.NAME) - 1) + ' ' + 
    LEFT(SUBSTRING(STUDENT.NAME, CHARINDEX(' ', STUDENT.NAME) + 1, LEN(STUDENT.NAME)), 1) + '.' +
    LEFT(RIGHT(STUDENT.NAME, CHARINDEX(' ', REVERSE(STUDENT.NAME)) - 1), 1) + '.' AS ���
FROM dbo.STUDENT;

--�)
--DECLARE @date date = getdate();

SELECT STUDENT.NAME as ���, 
	   DATENAME(YEAR, STUDENT.BDAY) as �������,
	   STUDENT.BDAY as [���� ��������]
FROM STUDENT
  where DATENAME(MONTH, STUDENT.BDAY) = '���';

--�)
SELECT STUDENT.NAME as �������,
	   STUDENT.IDGROUP ������,
	   PROGRESS.SUBJECT �������,
	   PROGRESS.PDATE [���� �����],
	   DATENAME(WEEKDAY, PROGRESS.PDATE) as [���� ������]
FROM STUDENT inner join PROGRESS
	on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
	WHERE STUDENT.IDGROUP = 5;

--5--Task--

DECLARE @����������_1 int = (select sum(AUDITORIUM.AUDITORIUM_CAPACITY) from AUDITORIUM);
DECLARE @y_1 int = (select cast(COUNT(*) as numeric) from AUDITORIUM);
DECLARE @y1_1 int = (select cast(AVG(AUDITORIUM_CAPACITY) as numeric) from AUDITORIUM);
DECLARE @y2_1 int = (select cast(COUNT(*) as numeric) from AUDITORIUM where AUDITORIUM.AUDITORIUM_CAPACITY < @y1_1);
DECLARE @y3_1 float = (@y2_1 * 100.0) /  @y_1;

IF @����������_1 > 200
	begin
		SELECT @y_1 '���������� ���������', 
			   @y1_1 '������� �����������', 
			   @y2_1 '���������� ���������, ����������� ������� ������ �������',
			   @y3_1 '������� ���������, ����������� ������� ������ �������';
	end
ELSE print '����������� ���������: ' + cast(@����������_1 as varchar(10));

--6--Task--

SELECT CASE 
	when PROGRESS.NOTE between 4 and 6 then '���'
	when PROGRESS.NOTE between 6 and 8 then '����'
	when PROGRESS.NOTE between 8 and 10 then '��� ��...'
	else '���� �������'
	end '������', STUDENT.NAME, PROGRESS.NOTE
	FROM PROGRESS inner join STUDENT
	on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT inner join GROUPS 
	on GROUPS.IDGROUP = STUDENT.IDGROUP;

--7--Task--

CREATE TABLE #EXPLRER (
    TIND INT,
    TFIELD VARCHAR(100),
    TDATE DATE
);

SET NOCOUNT ON;
DECLARE @i INT = 1;

WHILE @i <= 10
BEGIN
    INSERT INTO #EXPLRER (TIND, TFIELD, TDATE)
    VALUES (FLOOR(30000 * RAND()), REPLICATE('������', 10), GETDATE());

    SET @i = @i + 1;
END;

SELECT * FROM #EXPLRER;

--8--Task--

DECLARE @xxx int = 0
	print @xxx+1
	print @xxx+2
	RETURN
	print @xxx+3

--9--Task--

begin TRY
	DECLARE @aa int = 1/0;
end try
begin CATCH
	print ERROR_NUMBER()
	print ERROR_MESSAGE()
	print ERROR_LINE()
	print ERROR_PROCEDURE()
	print ERROR_SEVERITY()
	print ERROR_STATE()
end catch