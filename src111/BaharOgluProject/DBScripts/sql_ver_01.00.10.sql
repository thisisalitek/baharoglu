

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Arma'))
ALTER TABLE KategoriParam_055_Secenek ADD Arma INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET Arma = 0 WHERE Arma IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'OzelEtiket'))
ALTER TABLE KategoriParam_055_Secenek ADD OzelEtiket INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET OzelEtiket = 0 WHERE OzelEtiket IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Fason'))
ALTER TABLE KategoriParam_055_Secenek ADD Fason INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET Fason = 0 WHERE Fason IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam_055_Secenek') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'FasonID'))
ALTER TABLE KategoriParam_055_Secenek ADD FasonID INT  NULL DEFAULT 0
GO

UPDATE KategoriParam_055_Secenek SET FasonID = 0 WHERE FasonID IS NULL

GO


---- ESKI TABLOYU DUSUR
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_053_DigerSecenek')
    DROP TABLE SipDetayParam_053_DigerSecenek

GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_055_Secenek')
    DROP TABLE SipDetayParam_055_Secenek

GO


CREATE TABLE SipDetayParam_055_Secenek (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NOT NULL ,
	[SourceID] [int] NOT NULL ,
	[KategoriParamID] [int] NOT NULL ,
	[ModelFarki] [int] NULL DEFAULT 0 ,
	[ParcaModel] [int] NULL DEFAULT 0 ,
	[Astar] [int] NULL DEFAULT 0 ,
	[Femuar] [int] NULL DEFAULT 0 ,
	[OmuzRecme] [int] NULL DEFAULT 0 ,
	[Arma] [int] NULL DEFAULT 0 ,
	[OzelEtiket] [int] NULL DEFAULT 0 ,
	[Fason] [int] NULL DEFAULT 0 ,
	[FasonID] [int] NULL DEFAULT 0 
)
GO
