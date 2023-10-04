
DECLARE @KategoriID INT 
DECLARE @UstKategoriID INT 

DECLARE cursor1 CURSOR FOR  
SELECT KategoriID,UstKategoriID FROM Kategoriler WHERE NOT KategoriID IN (SELECT UstKategoriID FROM Kategoriler)


OPEN cursor1;  

FETCH NEXT FROM cursor1  
INTO @KategoriID, @UstKategoriID;  

WHILE @@FETCH_STATUS = 0  
BEGIN  
	IF NOT EXISTS(SELECT * FROM KategoriFiyat WHERE KategoriID=@KategoriID)
		INSERT INTO KategoriFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, BedenNo, BedenKod, Fiyat, BazBedenMi)
		SELECT Deleted, -99, GETDATE(), -99,  GETDATE(), @KategoriID, BedenNo, BedenKod, Fiyat, BazBedenMi
		FROM KategoriFiyat
		WHERE Deleted = 0 AND KategoriID = @UstKategoriID 

	IF NOT EXISTS(SELECT * FROM KategoriEkFiyat WHERE KategoriID=@KategoriID)
		INSERT INTO KategoriEkFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, MasrafKod, MasrafIsmi, Fiyat, BedenArtis)
		SELECT Deleted, -99, GETDATE(), -99,  GETDATE(), @KategoriID, MasrafKod, MasrafIsmi, Fiyat, BedenArtis
		FROM KategoriEkFiyat
		WHERE Deleted = 0 AND KategoriID = @UstKategoriID 

   FETCH NEXT FROM cursor1  
   INTO @KategoriID, @UstKategoriID;  
END  

CLOSE cursor1;  
DEALLOCATE cursor1;  

GO




IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_019_Kaskorse')
    DROP TABLE KategoriParam_019_Kaskorse

GO

CREATE TABLE KategoriParam_019_Kaskorse (
	nID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Deleted int NULL DEFAULT 0,
	CreatedBy int NULL DEFAULT 0,
	CreatedDate datetime NULL DEFAULT 0,
	ModifiedBy int NULL DEFAULT 0,
	ModifiedDate datetime NULL DEFAULT 0,
	KategoriParamID INT NULL DEFAULT 0,
	Iplik INT NULL DEFAULT 0,
	IpGramaj INT NULL DEFAULT 0,
	GramajArtis INT NULL DEFAULT 0
)

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_019_Kaskorse')
    DROP TABLE SipDetayParam_019_Kaskorse

GO

CREATE TABLE SipDetayParam_019_Kaskorse (
	nID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Deleted int NULL DEFAULT 0,
	CreatedBy int NULL DEFAULT 0,
	CreatedDate datetime NULL DEFAULT 0,
	ModifiedBy int NULL DEFAULT 0,
	ModifiedDate datetime NULL DEFAULT 0,
	SipDetayParamID INT NULL DEFAULT 0,
	SourceID INT NULL DEFAULT 0,
	KategoriParamID INT NULL DEFAULT 0,
	RenkID INT NULL DEFAULT 0,
	Iplik INT NULL DEFAULT 0,
	IpGramaj INT NULL DEFAULT 0,
	GramajArtis INT NULL DEFAULT 0
)

GO




IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_020_GogusManset')
    DROP TABLE KategoriParam_020_GogusManset

GO

CREATE TABLE KategoriParam_020_GogusManset (
	nID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Deleted int NULL DEFAULT 0,
	CreatedBy int NULL DEFAULT 0,
	CreatedDate datetime NULL DEFAULT 0,
	ModifiedBy int NULL DEFAULT 0,
	ModifiedDate datetime NULL DEFAULT 0,
	KategoriParamID INT NULL DEFAULT 0,
	Iplik INT NULL DEFAULT 0,
	IpGramaj INT NULL DEFAULT 0,
	GramajArtis INT NULL DEFAULT 0
)

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_020_GogusManset')
    DROP TABLE SipDetayParam_020_GogusManset

GO

CREATE TABLE SipDetayParam_020_GogusManset (
	nID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Deleted int NULL DEFAULT 0,
	CreatedBy int NULL DEFAULT 0,
	CreatedDate datetime NULL DEFAULT 0,
	ModifiedBy int NULL DEFAULT 0,
	ModifiedDate datetime NULL DEFAULT 0,
	SipDetayParamID INT NULL DEFAULT 0,
	SourceID INT NULL DEFAULT 0,
	KategoriParamID INT NULL DEFAULT 0,
	RenkID INT NULL DEFAULT 0,
	CizgiRKafaLakosID INT NULL DEFAULT 0,
	CizgiSayisi INT NULL DEFAULT 0,
	Iplik INT NULL DEFAULT 0,
	IpGramaj INT NULL DEFAULT 0,
	GramajArtis INT NULL DEFAULT 0
)

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_020_GogusManset_Cizgiler')
    DROP TABLE SipDetayParam_020_GogusManset_Cizgiler

GO

CREATE TABLE SipDetayParam_020_GogusManset_Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[GogusMansetID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO

