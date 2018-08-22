CREATE TABLE[dbo].[People] (                                     ​ 
    [​Id​]​ INT IDENTITY​(​ 1​ ,​ ​ 1​ )​ NOT NULL,                                     ​ 
    [Name​]​ NVARCHAR​(​MAX​ )​ COLLATE Cyrillic_General_CI_AS​ NOT NULL,                                     ​
    [​Surname​]​ NVARCHAR​(​MAX​ )​ NULL,                                     ​ 
    [​Age]​    INTEGER​ NULL,                                     ​ 
    [Salary​]​    INTEGER​​ NULL,                                     
    CONSTRAINT​[​PK_dbo​.​People​]​ PRIMARY KEY CLUSTERED​([​Id​]​ ASC) 
    );