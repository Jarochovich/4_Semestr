use UNIVER;

--1-Task--
SELECT AUDITORIUM.AUDITORIUM_TYPE		   [��� ���������],
	   MAX(AUDITORIUM.AUDITORIUM_CAPACITY) [������������ �����������],
	   MIN(AUDITORIUM.AUDITORIUM_CAPACITY) [����������� �����������],
	   AVG(AUDITORIUM.AUDITORIUM_CAPACITY) [������� �����������],
	   SUM(AUDITORIUM.AUDITORIUM_CAPACITY) [��������� �����������],
	   COUNT(*)							   [���������� ���������]
FROM AUDITORIUM INNER JOIN AUDITORIUM_TYPE
	ON AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
		GROUP BY AUDITORIUM.AUDITORIUM_TYPE;

--3-Task--
SELECT *
FROM (select Case 
	  when NOTE between 1 and 4 then '������ 4 � ������'
	  when NOTE between 5 and 8 then '������ ����� 5 � 8'
	  else '������ 9 � ����' 
	  end [������� ������], COUNT(*) [���������� ������]
FROM PROGRESS GROUP by Case
	  when NOTE between 1 and 4 then '������ 4 � ������'
	  when NOTE between 5 and 8 then '������ ����� 5 � 8'
	  else '������ 9 � ����'
	  end) as T
			ORDER by Case [������� ������]
			when '������ 4 � ������' then 3
			when '������ ����� 5 � 8' then 2
			when '������ 9 � ����' then 1
			else 0
			end

--4-Task--
SELECT f.FACULTY, g.PROFESSION, g.YEAR_FIRST,round(avg(cast(p.NOTE as float)), 2) as [������� ������]
FROM FACULTY f inner join GROUPS g
	on f.FACULTY = g.FACULTY
	inner join STUDENT s 
	on s.IDGROUP = g.IDGROUP
	inner join PROGRESS p
	on s.IDSTUDENT = p.IDSTUDENT
GROUP BY f.FACULTY, g.PROFESSION, g.YEAR_FIRST

--5-Task--
SELECT f.FACULTY, g.PROFESSION, g.YEAR_FIRST,round(avg(cast(p.NOTE as float(4))), 2) as [������� ������]
FROM FACULTY f inner join GROUPS g
	on f.FACULTY = g.FACULTY
	inner join STUDENT s 
	on s.IDGROUP = g.IDGROUP
	inner join PROGRESS p
	on s.IDSTUDENT = p.IDSTUDENT
WHERE p.SUBJECT IN ('OAP', 'DB')
GROUP BY f.FACULTY, g.PROFESSION, g.YEAR_FIRST

--6-Task--
SELECT GROUPS.PROFESSION, PROGRESS.SUBJECT, AVG(PROGRESS.NOTE) as [������� ������]
FROM FACULTY inner join GROUPS
	on FACULTY.FACULTY = GROUPS.FACULTY
	inner join STUDENT
	on STUDENT.IDGROUP = GROUPS.IDGROUP
	inner join PROGRESS
	on PROGRESS.IDSTUDENT = STUDENT.IDSTUDENT
WHERE FACULTY.FACULTY = 'TOV'
GROUP BY GROUPS.PROFESSION, PROGRESS.SUBJECT

--7-Task--
SELECT p1.SUBJECT,
	(select COUNT(*) from PROGRESS p2
	 WHERE p2.SUBJECT = p1.SUBJECT
	 and p2.NOTE = p1.NOTE) [���-�� ���������]
FROM PROGRESS p1
	GROUP BY p1.SUBJECT, p1.NOTE
	HAVING NOTE = 8 OR NOTE = 9