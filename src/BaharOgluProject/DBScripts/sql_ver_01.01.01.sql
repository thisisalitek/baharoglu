
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayUretimBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'AnaRenk'))
ALTER TABLE SipDetayUretimBilgi ADD AnaRenk VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayUretimBilgi SET AnaRenk='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayUretimBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve1'))
ALTER TABLE SipDetayUretimBilgi ADD Reserve1 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayUretimBilgi SET Reserve1='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayUretimBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve2'))
ALTER TABLE SipDetayUretimBilgi ADD Reserve2 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayUretimBilgi SET Reserve2='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayUretimBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve3'))
ALTER TABLE SipDetayUretimBilgi ADD Reserve3 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayUretimBilgi SET Reserve3='' WHERE AnaRenk IS NULL

GO




IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'AnaRenk'))
ALTER TABLE SipDetayBilgi ADD AnaRenk VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayBilgi SET AnaRenk='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve1'))
ALTER TABLE SipDetayBilgi ADD Reserve1 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayBilgi SET Reserve1='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve2'))
ALTER TABLE SipDetayBilgi ADD Reserve2 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayBilgi SET Reserve2='' WHERE AnaRenk IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayBilgi') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Reserve3'))
ALTER TABLE SipDetayBilgi ADD Reserve3 VARCHAR(100)  NULL DEFAULT ''
GO

UPDATE SipDetayBilgi SET Reserve3='' WHERE AnaRenk IS NULL

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_012_LakosYaka_Enler')
    DROP TABLE KategoriParam_012_LakosYaka_Enler

GO

CREATE TABLE KategoriParam_012_LakosYaka_Enler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[BedenKod] VARCHAR(10) NULL DEFAULT '',
	[En] FLOAT NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KumasGiris')
    DROP TABLE KumasGiris

GO


CREATE TABLE KumasGiris (
	KumasGirisID [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	IrsaliyeType INT NULL DEFAULT 0 ,
	IrsTarih DATETIME NULL DEFAULT 0 , 
	IrsEvrakSeri VARCHAR(10) NULL DEFAULT '',
	IrsEvrakSira INT NULL DEFAULT 0 ,
	IrsaliyeNo VARCHAR(20) NULL DEFAULT '',
	BelgeNo VARCHAR(30) NULL DEFAULT '',
	IsEmriNo VARCHAR(25) NULL DEFAULT '',
	CariKod VARCHAR(50) NULL DEFAULT '',
	CariUnvan VARCHAR(100) NULL DEFAULT '',
	Aciklama1 VARCHAR(50) NULL DEFAULT '',
	Aciklama2 VARCHAR(50) NULL DEFAULT '',
	Aciklama3 VARCHAR(50) NULL DEFAULT '',
	Depo VARCHAR(50) NULL DEFAULT '',
	Depo2 VARCHAR(50) NULL DEFAULT '',
	AraToplam FLOAT NULL DEFAULT 0,
	KdvOran FLOAT NULL DEFAULT 0,
	KdvTutar FLOAT NULL DEFAULT 0,
	GenelToplam FLOAT NULL DEFAULT 0,
	DovizTipi VARCHAR(5) DEFAULT '',
	DovizKuru FLOAT NULL DEFAULT 0,
	IntCode VARCHAR(50) NULL DEFAULT '',
	Transferred INT NULL DEFAULT 0,
	TransferDate DATETIME NULL DEFAULT 0,
	Pasif INT NULL DEFAULT 0
) 
GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KumasGirisDetay')
    DROP TABLE KumasGirisDetay

GO


CREATE TABLE KumasGirisDetay (
	KumasGirisDetayID [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	KumasGirisID INT NULL DEFAULT 0 ,
	StokKod VARCHAR(50) NULL DEFAULT '',
	StokIsmi VARCHAR(100) NULL DEFAULT '',
	Aciklama VARCHAR(50) NULL DEFAULT '',
	Miktar FLOAT NULL DEFAULT 0,
	Birim VARCHAR(20) NULL DEFAULT '',
	Fiyat FLOAT NULL DEFAULT 0,
	Tutar FLOAT NULL DEFAULT 0,
	Parti VARCHAR(50) NULL DEFAULT '',
	LotNo INT NULL DEFAULT 0,
	Field1 VARCHAR(50) NULL DEFAULT '',
	Field2 VARCHAR(50) NULL DEFAULT '',
	Field3 VARCHAR(50) NULL DEFAULT '',
	Field4 VARCHAR(50) NULL DEFAULT '',
	Field5 VARCHAR(50) NULL DEFAULT '',
	IntCode VARCHAR(50) NULL DEFAULT '',
	Transferred INT NULL DEFAULT 0,
	TransferDate DATETIME NULL DEFAULT 0
) 
GO




