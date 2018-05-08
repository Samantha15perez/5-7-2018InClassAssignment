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
create proc DateConvert @Date Nvarchar
as
BEGIN
if ((Select SUBSTRING(joindate, 1, 2)) > 12)


END

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

