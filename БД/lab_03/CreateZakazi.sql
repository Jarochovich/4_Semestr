USE Yarok_MyBASE;

CREATE TABLE ������
(�����_������ int primary key,
������������_������ nvarchar(20) foreign key references ������(������������),
����_������� real,
���������� int,
����_�������� date,
�������� nvarchar(20) foreign key references ���������(������������_�����)
);