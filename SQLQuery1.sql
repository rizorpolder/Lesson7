CREATE TABLE[dbo].[People] (
[Id] INT IDENTITY(1, 1) NOT NULL,
[FIO] NVARCHAR(MAX) COLLATE
Cyrillic_General_CI_AS NOT NULL,
[Birthday] NVARCHAR(MAX) NULL,
[Email] NVARCHAR(100) NULL,
[Phone] NVARCHAR(MAX) NULL,
CONSTRAINT[PK_dbo.People] PRIMARY KEY
CLUSTERED([Id] ASC));


INSERT INTO People (FIO,
Birthday,Email,Phone) VALUES (N'Иванов Иван Иванович', '18.10.2001',
'somebody@gmail.com', '89164444444' );
INSERT INTO People(FIO, Birthday, Email,
Phone) VALUES(N'Петров Петр Петрович', '15.01.2001', 'somebody@mail.com',
'8916555555');



--SELECT 
--*
--FROM People