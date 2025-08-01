USE UNIVER1;

CREATE TABLE AUDITORIUM 
          (     AUDITORIUM   char(20)  primary key,              
      AUDITORIUM_TYPE  char(20) foreign key references  
                                                 AUDITORIUM_TYPE(AUDITORIUM_TYPE), 
                AUDITORIUM_CAPACITY  int default 1  
                                            check  (AUDITORIUM_CAPACITY between 1 and 300),  
                AUDITORIUM_NAME  varchar(50)                                     
          ) on FG1;
