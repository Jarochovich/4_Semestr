use UNIVER;

--1-Task---------------------------------------------------------------------
exec SP_HELPINDEX 'AUDITORIUM';

Create TABLE #EXPLRER (
    TIND INT,
    TFIELD VARCHAR(100),
    TDATE DATE
);


--SET NOCOUNT ON;
DECLARE @i INT = 1;

WHILE @i <= 1000
BEGIN
    INSERT INTO #EXPLRER (TIND, TFIELD, TDATE)
    VALUES (FLOOR(30000 * RAND()), REPLICATE('строка', 10), GETDATE());

    SET @i = @i + 1;
END;

SELECT * FROM #EXPLRER;

 checkpoint;  --фиксация БД
 DBCC DROPCLEANBUFFERS;  --очистить буферный кэш


SELECT * FROM #EXPLRER where TIND between 0 and 5500 order by TIND
CREATE clustered index #EXPLRE_CL on #EXPLRER(TIND asc);

--2-Task--------------------------------------------------------------------
CREATE table #EX
(    TKEY int, 
     CC int identity(1, 1),
     TF varchar(100)
);
  set nocount on;           
  declare @i int = 0;
  while   @i < 20000       -- добавление в таблицу 20000 строк
  begin
       INSERT #EX(TKEY, TF) values(floor(30000*RAND()), replicate('строка ', 10));
        set @i = @i + 1; 
  end;
  SELECT count(*)[количество строк] from #EX;
  SELECT * from #EX

   checkpoint;  --фиксация БД
   DBCC DROPCLEANBUFFERS;  --очистить буферный кэш

  SELECT * from  #EX where  TKEY = 556 and  CC > 3
  CREATE index #EX_NONCLU on #EX(TKEY, CC)

--3-Task---------------------------------------------------------------------

SELECT CC from #EX where TKEY>15000 

CREATE  index #EX_TKEY_X on #EX(TKEY) INCLUDE (CC)

--4-Task---------------------------------------------------------------------

SELECT TKEY from  #EX where TKEY between 5000 and 19999; 
SELECT TKEY from  #EX where TKEY>15000 and  TKEY < 20000  
SELECT TKEY from  #EX where TKEY=17000

CREATE  index #EX_WHERE on #EX(TKEY) where (TKEY>=15000 and 
 TKEY < 20000);  

 --5-Task--------------------------------------------------------------------
 drop table if exists #EX
	CREATE table #EX
		(TKEY int,
		CC int identity(1,1),
		TF varchar(100));
	set nocount on;
	declare @iw int=0;
	while @iw<20000
		begin
			insert #ex(TKEY,TF)values (FLOOR(30000*RAND()),replicate('string',10));
			set @iw=@iw+1
		end;

CREATE   index #EX_TKEY ON #EX(TKEY); 
INSERT top(10000) #EX(TKEY, TF) select TKEY, TF from #EX;
SELECT name [index], avg_fragmentation_in_percent [fragmentation (%)]
FROM sys.dm_db_index_physical_stats(DB_ID(N'TEMPDB'), 
	OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;

ALTER index #EX_TKEY on #EX reorganize;
SELECT name [index], avg_fragmentation_in_percent [fragmentation (%)]
FROM sys.dm_db_index_physical_stats(DB_ID(N'TEMPDB'), 
	OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;

ALTER index #EX_TKEY on #EX rebuild with (online = off);
SELECT name [index], avg_fragmentation_in_percent [fragmentation (%)]
FROM sys.dm_db_index_physical_stats(DB_ID(N'TEMPDB'), 
	OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii on ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;



--6-Task---------------------------------------------------------------------

DROP index #EX_TKEY on #EX;
CREATE index #EX_TKEY on #EX(TKEY)
	with (fillfactor = 65);
INSERT top(50)percent INTO #EX(TKEY, TF) 
	SELECT TKEY, TF  FROM #EX;

SELECT name [Индекс], avg_fragmentation_in_percent [Фрагментация (%)]
	FROM sys.dm_db_index_physical_stats(DB_ID(N'TEMPDB'),    
	OBJECT_ID(N'#EX'), NULL, NULL, NULL) ss  JOIN sys.indexes ii 
	ON ss.object_id = ii.object_id and ss.index_id = ii.index_id  WHERE name is not null;
