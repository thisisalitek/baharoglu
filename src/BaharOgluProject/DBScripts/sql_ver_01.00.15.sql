IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_015_Fular')
    DROP TABLE KategoriParam_015_Fular

GO

CREATE TABLE KategoriParam_015_Fular (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_015_Fular')
    DROP TABLE SipDetayParam_015_Fular

GO

CREATE TABLE SipDetayParam_015_Fular (
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
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 
)
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntParam1'))
ALTER TABLE KategoriParam ADD IntParam1 INT  NULL DEFAULT 0
GO

UPDATE KategoriParam SET IntParam1 = 0 WHERE IntParam1 IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntParam2'))
ALTER TABLE KategoriParam ADD IntParam2 INT  NULL DEFAULT 0
GO

UPDATE KategoriParam SET IntParam2 = 0 WHERE IntParam2 IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntParam3'))
ALTER TABLE KategoriParam ADD IntParam3 INT  NULL DEFAULT 0
GO

UPDATE KategoriParam SET IntParam3 = 0 WHERE IntParam3 IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntParam2'))
ALTER TABLE SipDetayParam ADD IntParam2 INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam SET IntParam2 = 0 WHERE IntParam2 IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntParam3'))
ALTER TABLE SipDetayParam ADD IntParam3 INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam SET IntParam3 = 0 WHERE IntParam3 IS NULL

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_016_Kravat')
    DROP TABLE KategoriParam_016_Kravat

GO

CREATE TABLE KategoriParam_016_Kravat (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_016_Kravat')
    DROP TABLE SipDetayParam_016_Kravat

GO

CREATE TABLE SipDetayParam_016_Kravat (
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
	[RenkID] [int] NULL DEFAULT 0 
)

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CharParam1'))
ALTER TABLE SipDetayParam ADD CharParam1 VARCHAR(200)  NULL DEFAULT ''
GO

UPDATE SipDetayParam SET CharParam1 = 0 WHERE CharParam1 IS NULL

GO




