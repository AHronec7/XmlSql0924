use sandbox
go

Create table XmlTable
(
	Firstname varchar(30) not null,
	Lastname varchar(30) not null,
	SSN      varchar(15) not null,
	Gender   varchar(10) not null,
	Email    varchar(40) not null
)
GO

Create proc InsertXml 
	@Firstname varchar(30),
	@Lastname  varchar(30),
	@SSN       varchar(15),
	@Gender    varchar(10),
	@Email      varchar(40)
AS 
BEGIN 
Insert into XmlTable
			(Firstname, Lastname, SSN, Gender, Email)
Values      (@Firstname, @Lastname, @SSN, @Gender, @Email)

END
