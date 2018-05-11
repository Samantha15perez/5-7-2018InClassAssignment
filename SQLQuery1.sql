USE MASTER;

IF (Select COUNT(*) from sys.databases where name = 'DateConversion') >0

 BEGIN
 DROP DATABASE DateConversion
 END

 CREATE DATABASE DateConversion;
 
 GO

 Use DateConversion;

  IF (Select COUNT(*) from INFORMATION_SCHEMA.tables t where t.TABLE_NAME = 'MembersTable') > 0 
 BEGIN
 DROP TABLE MembersTable
 END 

 CREATE TABLE MembersTable
 (
 FirstName Nvarchar(40) NOT NULL,
 LastName Nvarchar(40) NOT NULL,
 BirthDate Nvarchar(40) NOT NULL,
 City Nvarchar(40) NOT NULL,
 [State] Nvarchar(40) NOT NULL,
 JoinDate Nvarchar(40) NOT NULL,
 )

 CREATE TABLE MembersTableConverted
(FirstName VARCHAR(40),
LastName VARCHAR(50),
BirthDate DATE,
City VARCHAR(50),
[State] VARCHAR(50),
JoinDate DATE
)
 
 BULK INSERT Memberstable
FROM 'C:\Users\CyberAdmin\Desktop\MemberSort.csv'
WITH
(
FIRSTROW = 1, -- secopnd row if header row in file
FIELDTERMINATOR = ',',  --CSV field delimiter
ROWTERMINATOR = '\n',   --Use to shift the control to next row
ERRORFILE = 'C:\Users\Cyberadmin\Desktop\memberserr.csv',
TABLOCK
)

go
create function [dbo].[Date_Fixer_Upper]
(@inputDate AS Varchar(50))
RETURNS DATE
AS
BEGIN

DECLARE @Result DATE = NULL;
DECLARE @YearLength INT = 0;
DECLARE @YearValue INT = 0;


IF LEN(@inputDate) > 0
BEGIN

set @inputDate = LTRIM(RTRIM(@Inputdate))

IF LEFT(@Inputdate, 1) = '0'
BEGIN
SET @inputDate = RIGHT(@inputDate, LEN(@inputDate) - 1);
END

--set delimiters to all the same character
SET @inputDate = REPLACE(@inputDate, ' ', '/');
SET @inputDate = REPLACE(@inputDate, '-', '/');
SET @inputDate = REPLACE(@inputDate, '.', '/');

WHILE CHARINDEX('//', @inputDate) != 0
BEGIN
SET @inputDate = REPLACE(@inputDate, '//', '/')
END

DECLARE @reverseIn VARCHAR(255) = REVERSE(@inputDate); 
SET @yearLength = CHARINDEX('/', @reverseIn) - 1;

SET @YearValue = convert(int, reverse(left(@reverseIn, 2)));

IF @yearlength > 0 and @YearLength < 4
BEGIN

if @yearvalue < 10
begin













Select SUBSTRING(joindate, 1, 2) from MembersTable

--use string split on laptop, wont work on desktop. if there's time, make a version without the string_Split command
--INFO LINK: https://docs.microsoft.com/en-us/sql/t-sql/functions/string-split-transact-sql?view=sql-server-2017

Select STRING_SPLIT(joindate, '/')

--ok its pseudocode time

--look through the files and find the symbols used as delimiters

--replace all delimiters with "/"

--use stringsplit to verify whether or not the first part of the date (before the delimiter) is 4 characters, if so, thats the year.

--once the date types have been verified, use stringsplit to convert from XX/XX/XX to X/Y/Z

--use variables to switch the date into the proper order, ie: 31/04/18 >> X/Y/Z >> Y/X/Z >> 04/31/18

--then verify if the first part of the date is greater than or less than 12. this is a good way (though not perfect) to verify
--whether or not the date is MM/DD or DD/MM

--if any of the variables are 4 characters, automatically move it to last

--figure out how to put in the full year ie: 4/31/18 >> 4/31/2018

