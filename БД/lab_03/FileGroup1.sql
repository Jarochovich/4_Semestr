USE master
go
CREATE DATABASE UNIVER
on primary
(name = N'UNIVER_mdf', filename = N'D:\DB\UNIVER_mdf.mdf',
size = 10240Kb, maxsize = UNLIMITED, filegrowth = 1024Kb)
log on
(name = N'UNIVER_log', filename = N'D:\DB\UNIVER_log.ldf',
size = 10240Kb, maxsize = 2048Gb, filegrowth = 10%)
go