IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_011_LakosKumas')
    DROP TABLE KategoriParam_011_LakosKumas

GO

CREATE TABLE KategoriParam_011_LakosKumas (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[OrguTip] [int] NULL DEFAULT 0 ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[KumasGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_011_LakosKumas')
    DROP TABLE SipDetayParam_011_LakosKumas

GO

CREATE TABLE SipDetayParam_011_LakosKumas (
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
	[OrguTip] [int] NULL DEFAULT 0 ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[KumasGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 


)
GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'OrguTipleri') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bLakos'))
ALTER TABLE OrguTipleri ADD bLakos INT  NULL DEFAULT 0
GO

UPDATE OrguTipleri SET bLakos = 0 WHERE bLakos IS NULL

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_012_LakosYaka')
    DROP TABLE KategoriParam_012_LakosYaka

GO

CREATE TABLE KategoriParam_012_LakosYaka (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[YakaTip] [int] NULL DEFAULT 0 ,   -- 0 NORMAL   1 SIMIT
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 ,
	[SimitKumasYuzde] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_012_LakosYaka')
    DROP TABLE SipDetayParam_012_LakosYaka

GO

CREATE TABLE SipDetayParam_012_LakosYaka (
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


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_012_LakosYaka_Cizgiler')
    DROP TABLE SipDetayParam_012_LakosYaka_Cizgiler

GO

CREATE TABLE SipDetayParam_012_LakosYaka_Cizgiler (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[LakosYakaID] [int] NULL DEFAULT 0 ,
	[CizgiNo] [int] NULL DEFAULT 0,
	[RenkID] [int] NULL DEFAULT 0
)
GO

