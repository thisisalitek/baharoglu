

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_056_EkFiyat')
    DROP TABLE SipDetayParam_056_EkFiyat

GO

CREATE TABLE SipDetayParam_056_EkFiyat (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[Aciklama] [varchar] (50) NULL DEFAULT '' ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[BedenArtis] [float] NULL DEFAULT 0 ,
	[bStatik] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_057_EkOzellikler')
    DROP TABLE SipDetayParam_057_EkOzellikler

GO

CREATE TABLE SipDetayParam_057_EkOzellikler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[Aciklama] [varchar] (250) NULL DEFAULT '',
	[bStatik] [int] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_057_EkOzellikler')
    DROP TABLE KategoriParam_057_EkOzellikler

GO

CREATE TABLE KategoriParam_057_EkOzellikler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Aciklama] [varchar] (250) NULL DEFAULT '' 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayUretimBilgi')
    DROP TABLE SipDetayUretimBilgi

GO

CREATE TABLE SipDetayUretimBilgi (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayID] [int] NULL DEFAULT 0 ,
	[GrupKod] [varchar] (30) NULL DEFAULT '',
	[GrupIsmi] [varchar] (50) NULL DEFAULT '',
	[Aciklama] [varchar] (250) NULL DEFAULT ''
)
GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim1'))
ALTER TABLE Kategoriler ADD Resim1 IMAGE  NULL
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim2'))
ALTER TABLE Kategoriler ADD Resim2 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim3'))
ALTER TABLE Kategoriler ADD Resim3 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim4'))
ALTER TABLE Kategoriler ADD Resim4 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim5'))
ALTER TABLE Kategoriler ADD Resim5 IMAGE  NULL
GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype in (N'FN', N'IF', N'TF') and name='fnListe_SipDetayBedenler')
    DROP FUNCTION fnListe_SipDetayBedenler

GO

CREATE FUNCTION fnListe_SipDetayBedenler ( @SipDetayID INT) RETURNS VARCHAR(4000)
AS
BEGIN


DECLARE @BedenKod VARCHAR(10)
DECLARE @Miktar FLOAT
DECLARE @Desc VARCHAR(4000)
SET @DESC=''


DECLARE Employee_Cursor CURSOR FOR
SELECT BedenKod + ':',Miktar FROM SipDetayFiyatlar WHERE  Deleted = 0 AND SipDetayID = @SipDetayID
OPEN Employee_Cursor

FETCH NEXT FROM Employee_Cursor
INTO @BedenKod,@Miktar
IF @@FETCH_STATUS = 0 BEGIN
	SET @DESC=@DESC + SUBSTRING(@BedenKod,1,5) + SPACE(5-LEN(SUBSTRING(@BedenKod,1,5)))  + CAST(@Miktar as VARCHAR(5)) + CHAR(13) + CHAR(10)
END
WHILE @@FETCH_STATUS = 0
BEGIN
   FETCH NEXT FROM Employee_Cursor
	INTO @BedenKod,@Miktar
	IF @@FETCH_STATUS = 0 BEGIN
		SET @DESC=@DESC + SUBSTRING(@BedenKod,1,5) + SPACE(5-LEN(SUBSTRING(@BedenKod,1,5)))  + CAST(@Miktar as VARCHAR(5)) + CHAR(13) + CHAR(10)
	END
END
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor

RETURN @DESC

END

GO

