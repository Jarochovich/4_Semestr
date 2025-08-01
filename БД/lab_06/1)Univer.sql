use UNIVER;

--1-Task--
SELECT AUDITORIUM.AUDITORIUM_TYPE		   [Тип аудитории],
	   MAX(AUDITORIUM.AUDITORIUM_CAPACITY) [Максимальная вместимость],
	   MIN(AUDITORIUM.AUDITORIUM_CAPACITY) [Минимальная вместимость],
	   AVG(AUDITORIUM.AUDITORIUM_CAPACITY) [Средняя вместимость],
	   SUM(AUDITORIUM.AUDITORIUM_CAPACITY) [Суммарная вместимость],
	   COUNT(*)							   [Количество аудиторий]
FROM AUDITORIUM INNER JOIN AUDITORIUM_TYPE
	ON AUDITORIUM.AUDITORIUM_TYPE = AUDITORIUM_TYPE.AUDITORIUM_TYPE
		GROUP BY AUDITORIUM.AUDITORIUM_TYPE;

--3-Task--
SELECT *
FROM (select Case 
	  when NOTE between 1 and 4 then 'Оценка 4 и меньше'
	  when NOTE between 5 and 8 then 'Оценка между 5 и 8'
	  else 'Оценка 9 и выше' 
	  end [Границы оценок], COUNT(*) [Количество оценок]
FROM PROGRESS GROUP by Case
	  when NOTE between 1 and 4 then 'Оценка 4 и меньше'
	  when NOTE between 5 and 8 then 'Оценка между 5 и 8'
	  else 'Оценка 9 и выше'
	  end) as T
			ORDER by Case [Границы оценок]
			when 'Оценка 4 и меньше' then 3
			when 'Оценка между 5 и 8' then 2
			when 'Оценка 9 и выше' then 1
			else 0
			end

--4-Task--
SELECT f.FACULTY, g.PROFESSION, g.YEAR_FIRST,round(avg(cast(p.NOTE as float)), 2) as [Средняя оценка]
FROM FACULTY f inner join GROUPS g
	on f.FACULTY = g.FACULTY
	inner join STUDENT s 
	on s.IDGROUP = g.IDGROUP
	inner join PROGRESS p
	on s.IDSTUDENT = p.IDSTUDENT
GROUP BY f.FACULTY, g.PROFESSION, g.YEAR_FIRST

--5-Task--
SELECT f.FACULTY, g.PROFESSION, g.YEAR_FIRST,round(avg(cast(p.NOTE as float(4))), 2) as [Средняя оценка]
FROM FACULTY f inner join GROUPS g
	on f.FACULTY = g.FACULTY
	inner join STUDENT s 
	on s.IDGROUP = g.IDGROUP
	inner join PROGRESS p
	on s.IDSTUDENT = p.IDSTUDENT
WHERE p.SUBJECT IN ('OAP', 'DB')
GROUP BY f.FACULTY, g.PROFESSION, g.YEAR_FIRST

--6-Task--
SELECT GROUPS.PROFESSION, PROGRESS.SUBJECT, AVG(PROGRESS.NOTE) as [Средние оценки]
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
	 and p2.NOTE = p1.NOTE) [Кол-во студентов]
FROM PROGRESS p1
	GROUP BY p1.SUBJECT, p1.NOTE
	HAVING NOTE = 8 OR NOTE = 9