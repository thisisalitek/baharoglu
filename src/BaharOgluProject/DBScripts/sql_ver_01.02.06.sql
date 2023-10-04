IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayRenkler')
    DROP TABLE SipDetayRenkler

GO

CREATE TABLE SipDetayRenkler (
	nID int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Deleted int NULL DEFAULT 0,
	CreatedBy int NULL DEFAULT 0,
	CreatedDate datetime NULL DEFAULT 0,
	ModifiedBy int NULL DEFAULT 0,
	ModifiedDate datetime NULL DEFAULT 0,
	SipDetayID INT NULL DEFAULT 0,
	R002_Lastik VARCHAR(50) NULL DEFAULT '',
	R002_LastikCizgiler VARCHAR(100) NULL DEFAULT '',
	R003_Yaka VARCHAR(50) NULL DEFAULT '',
	R003_YakaCizgiler VARCHAR(100) NULL DEFAULT '',
	R004_DubleLastikCep VARCHAR(50) NULL DEFAULT '',
	R004_DubleLastikCepCizgiler VARCHAR(100) NULL DEFAULT '',
	R005_DubleLastikPilotYaka VARCHAR(50) NULL DEFAULT '',
	R005_DubleLastikPilotYakaCizgiler VARCHAR(100) NULL DEFAULT '',
	R006_DubleLastik VARCHAR(50) NULL DEFAULT '',
	R006_DubleLastikCizgiler VARCHAR(100) NULL DEFAULT '',
	R007_DubleYaka VARCHAR(50) NULL DEFAULT '',
	R007_DubleYakaCizgiler VARCHAR(100) NULL DEFAULT '',
	R008_TorbaliBant VARCHAR(50) NULL DEFAULT '',
	R008_TorbaliBantCizgiler VARCHAR(100) NULL DEFAULT '',
	R012_LakosYaka VARCHAR(50) NULL DEFAULT '',
	R012_LakosYakaCizgiler VARCHAR(100) NULL DEFAULT '',
	R013_Manset2cm VARCHAR(50) NULL DEFAULT '',
	R013_Manset2cmCizgiler VARCHAR(100) NULL DEFAULT '',
	R014_Manset6cm VARCHAR(50) NULL DEFAULT '',
	R014_Manset6cmCizgiler VARCHAR(100) NULL DEFAULT '',
	R018_EtekManseti VARCHAR(50) NULL DEFAULT '',
	R018_EtekMansetiCizgiler VARCHAR(100) NULL DEFAULT ''
	
)

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_018_EtekManset')
    DROP TABLE KategoriParam_018_EtekManset

GO

CREATE TABLE KategoriParam_018_EtekManset (
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



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_018_EtekManset')
    DROP TABLE SipDetayParam_018_EtekManset

GO

CREATE TABLE SipDetayParam_018_EtekManset (
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


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_018_EtekManset_Cizgiler')
    DROP TABLE SipDetayParam_018_EtekManset_Cizgiler

GO

CREATE TABLE SipDetayParam_018_EtekManset_Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[EtekMansetID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO




