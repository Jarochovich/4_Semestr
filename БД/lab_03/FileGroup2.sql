use master  
create database UNIVER1 on primary
( name = N'UNIVER1_mdf', filename = N'D:\DB\UNIVER1_mdf.mdf', 
   size = 10240Kb, maxsize=UNLIMITED, filegrowth=1024Kb),
( name = N'UNIVER1_ndf', filename = N'D:\DB\UNIVER1_ndf.ndf', 
   size = 10240KB, maxsize=1Gb, filegrowth=25%),
filegroup FG1
( name = N'UNIVER1_fg1_1', filename = N'D:\DB\UNIVER1_fgq-1.ndf', 
   size = 10240Kb, maxsize=1Gb, filegrowth=25%),
( name = N'UNIVER1_fg1_2', filename = N'D:\DB\UNIVER1_fgq-2.ndf', 
   size = 10240Kb, maxsize=1Gb, filegrowth=25%)
log on
( name = N'UNIVER1_log', filename=N'D:\DB\UNIVER1_log.ldf',       
   size=10240Kb,  maxsize=2048Gb, filegrowth=10%)
