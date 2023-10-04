

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_013_Manset2cm')
    DROP TABLE KategoriParam_013_Manset2cm

GO

CREATE TABLE KategoriParam_013_Manset2cm (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_013_Manset2cm')
    DROP TABLE SipDetayParam_013_Manset2cm

GO

CREATE TABLE SipDetayParam_013_Manset2cm (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0, 
	CizgiRKafaLakosID [int] NULL DEFAULT 0,
	CizgiSayisi [int] NULL DEFAULT 0
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_013_Manset2cm_Cizgiler')
    DROP TABLE SipDetayParam_013_Manset2cm_Cizgiler

GO

CREATE TABLE SipDetayParam_013_Manset2cm_Cizgiler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Manset2cmID] [int] NULL DEFAULT 0 ,
	[CizgiNo] [int] NULL DEFAULT 0,
	[RenkID] [int] NULL DEFAULT 0
)
GO




IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_014_Manset6cm')
    DROP TABLE KategoriParam_014_Manset6cm

GO

CREATE TABLE KategoriParam_014_Manset6cm (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_014_Manset6cm')
    DROP TABLE SipDetayParam_014_Manset6cm

GO

CREATE TABLE SipDetayParam_014_Manset6cm (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0, 
	CizgiRKafaLakosID [int] NULL DEFAULT 0,
	CizgiSayisi [int] NULL DEFAULT 0
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_014_Manset6cm_Cizgiler')
    DROP TABLE SipDetayParam_014_Manset6cm_Cizgiler

GO

CREATE TABLE SipDetayParam_014_Manset6cm_Cizgiler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Manset6cmID] [int] NULL DEFAULT 0 ,
	[CizgiNo] [int] NULL DEFAULT 0,
	[RenkID] [int] NULL DEFAULT 0
)
GO




IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'MansetFarki'))
ALTER TABLE KategoriParam_055_Secenek ADD MansetFarki INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET MansetFarki = 0 WHERE MansetFarki IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'UzunKolFarki'))
ALTER TABLE KategoriParam_055_Secenek ADD UzunKolFarki INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET UzunKolFarki = 0 WHERE UzunKolFarki IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'MansetFarki'))
ALTER TABLE SipDetayParam_055_Secenek ADD MansetFarki INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_055_Secenek SET MansetFarki = 0 WHERE MansetFarki IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'UzunKolFarki'))
ALTER TABLE SipDetayParam_055_Secenek ADD UzunKolFarki INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_055_Secenek SET UzunKolFarki = 0 WHERE UzunKolFarki IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'OkulFarki'))
ALTER TABLE Siparis ADD OkulFarki FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET OkulFarki = 0 WHERE OkulFarki IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'NAraToplam'))
ALTER TABLE Siparis ADD NAraToplam FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET NAraToplam = 0 WHERE NAraToplam IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'NKdvTutar'))
ALTER TABLE Siparis ADD NKdvTutar FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET NKdvTutar = 0 WHERE NKdvTutar IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'NGenelToplam'))
ALTER TABLE Siparis ADD NGenelToplam FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET NGenelToplam = 0 WHERE NGenelToplam IS NULL

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype in (N'FN', N'IF', N'TF') and name='fnListe_SipDetayEkFiyatlar')
    DROP FUNCTION fnListe_SipDetayEkFiyatlar

GO

CREATE FUNCTION fnListe_SipDetayEkFiyatlar ( @SipDetayID INT) RETURNS VARCHAR(4000)
AS
BEGIN
DECLARE @MasrafIsmi VARCHAR(100)
DECLARE @EkFiyat FLOAT
DECLARE @Desc VARCHAR(4000)
SET @DESC=''


DECLARE Employee_Cursor CURSOR FOR
SELECT     SipDetayEkFiyatlar.MasrafIsmi, SipDetayEkFiyatlar.EkFiyat *(1 + Siparis.OkulFarki/100) as EkFiyat
FROM         SipDetayEkFiyatlar INNER JOIN
                      SipDetay ON SipDetayEkFiyatlar.SipDetayID = SipDetay.SipDetayID INNER JOIN
                      Siparis ON SipDetay.SiparisID = Siparis.SiparisID
WHERE     (SipDetayEkFiyatlar.Deleted = 0) AND (SipDetayEkFiyatlar.SipDetayID = @SipDetayID)
OPEN Employee_Cursor

FETCH NEXT FROM Employee_Cursor
INTO @MasrafIsmi,@EkFiyat
IF @@FETCH_STATUS = 0 BEGIN
	SET @DESC=@DESC + SUBSTRING(@MasrafIsmi,1,30) + SPACE(30-LEN(SUBSTRING(@MasrafIsmi,1,30))) + CHAR(9) + CAST(@EkFiyat as VARCHAR(10)) + CHAR(13) + CHAR(10)
END
WHILE @@FETCH_STATUS = 0
BEGIN
   FETCH NEXT FROM Employee_Cursor
   INTO @MasrafIsmi,@EkFiyat
	IF @@FETCH_STATUS = 0 BEGIN
		SET @DESC=@DESC + SUBSTRING(@MasrafIsmi,1,30) + SPACE(30-LEN(SUBSTRING(@MasrafIsmi,1,30))) + CHAR(9) + CAST(@EkFiyat as VARCHAR(10)) + CHAR(13) + CHAR(10)
	END
END
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor

RETURN @DESC

END

GO