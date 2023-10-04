

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_009_Kumas2')
    DROP TABLE SipDetayParam_009_Kumas2

GO

CREATE TABLE SipDetayParam_009_Kumas2 (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[KumasKatalogID] [int] NULL DEFAULT 0 ,
	[KumasID] [int] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 
)
GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KumasKatalogu')
    DROP TABLE KumasKatalogu

GO

CREATE TABLE KumasKatalogu (
	[KumasKatalogID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KatalogKod] [nvarchar] (20) NULL DEFAULT '' ,
	[KatalogIsmi] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[Pasif] [int] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Kumaslar')
    DROP TABLE Kumaslar

GO

CREATE TABLE Kumaslar (
	[KumasID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Tip] [nvarchar] (20) NULL DEFAULT '' ,
	[KumasKod] [nvarchar] (30) NULL DEFAULT '' ,
	[KumasIsmi] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[Pasif] [int] NULL DEFAULT 0 
)
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'AraToplam'))
ALTER TABLE Siparis ADD AraToplam FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET AraToplam = 0 WHERE AraToplam IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'KdvOran'))
ALTER TABLE Siparis ADD KdvOran FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET KdvOran = 0 WHERE KdvOran IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'KdvTutar'))
ALTER TABLE Siparis ADD KdvTutar FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET KdvTutar = 0 WHERE KdvTutar IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'GenelToplam'))
ALTER TABLE Siparis ADD GenelToplam FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET GenelToplam = 0 WHERE GenelToplam IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'DovizTipi'))
ALTER TABLE Siparis ADD DovizTipi VARCHAR(5)  NULL DEFAULT ''
GO

UPDATE Siparis SET DovizTipi ='TL' WHERE DovizTipi IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'DovizKuru'))
ALTER TABLE Siparis ADD DovizKuru FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET DovizKuru = 0 WHERE DovizKuru IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'DovizliTutar'))
ALTER TABLE Siparis ADD DovizliTutar FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET DovizliTutar = 0 WHERE DovizliTutar IS NULL

GO


