
-- 2 cm manset

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bGarni1'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD bGarni1 INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET bGarni1=0 WHERE bGarni1 IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_RenkID'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_RenkID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_RenkID=0 WHERE Garni1_RenkID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_CizgiRKafaLakosID'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_CizgiRKafaLakosID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_CizgiRKafaLakosID=0 WHERE Garni1_CizgiRKafaLakosID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_CizgiSayisi'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_CizgiSayisi INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_CizgiSayisi=0 WHERE Garni1_CizgiSayisi IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bGarni2'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD bGarni2 INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET bGarni2=0 WHERE bGarni2 IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_RenkID'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_RenkID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_RenkID=0 WHERE Garni2_RenkID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_CizgiRKafaLakosID'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_CizgiRKafaLakosID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_CizgiRKafaLakosID=0 WHERE Garni2_CizgiRKafaLakosID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_CizgiSayisi'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_CizgiSayisi INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_CizgiSayisi=0 WHERE Garni2_CizgiSayisi IS NULL

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_013_Manset2cm_Garni1Cizgiler')
    DROP TABLE SipDetayParam_013_Manset2cm_Garni1Cizgiler

GO

CREATE TABLE SipDetayParam_013_Manset2cm_Garni1Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[Manset2cmID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_013_Manset2cm_Garni2Cizgiler')
    DROP TABLE SipDetayParam_013_Manset2cm_Garni2Cizgiler

GO

CREATE TABLE SipDetayParam_013_Manset2cm_Garni2Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[Manset2cmID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO


-- 6 cm manset

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bGarni1'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD bGarni1 INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET bGarni1=0 WHERE bGarni1 IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_RenkID'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_RenkID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_RenkID=0 WHERE Garni1_RenkID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_CizgiRKafaLakosID'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_CizgiRKafaLakosID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_CizgiRKafaLakosID=0 WHERE Garni1_CizgiRKafaLakosID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_CizgiSayisi'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_CizgiSayisi INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_CizgiSayisi=0 WHERE Garni1_CizgiSayisi IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bGarni2'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD bGarni2 INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET bGarni2=0 WHERE bGarni2 IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_RenkID'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_RenkID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_RenkID=0 WHERE Garni2_RenkID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_CizgiRKafaLakosID'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_CizgiRKafaLakosID INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_CizgiRKafaLakosID=0 WHERE Garni2_CizgiRKafaLakosID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_CizgiSayisi'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_CizgiSayisi INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_CizgiSayisi=0 WHERE Garni2_CizgiSayisi IS NULL

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_014_Manset6cm_Garni1Cizgiler')
    DROP TABLE SipDetayParam_014_Manset6cm_Garni1Cizgiler

GO

CREATE TABLE SipDetayParam_014_Manset6cm_Garni1Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[Manset6cmID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_014_Manset6cm_Garni2Cizgiler')
    DROP TABLE SipDetayParam_014_Manset6cm_Garni2Cizgiler

GO

CREATE TABLE SipDetayParam_014_Manset6cm_Garni2Cizgiler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[Manset6cmID] INT NULL DEFAULT 0,
	[CizgiNo] INT NULL DEFAULT 0,
	[RenkID] INT NULL DEFAULT 0
)

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Iplik'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Iplik=0 WHERE Iplik IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IpGramaj'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET IpGramaj=0 WHERE IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'GramajArtis'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET GramajArtis=0 WHERE GramajArtis IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_Iplik'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_Iplik=0 WHERE Garni1_Iplik IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_IpGramaj'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_IpGramaj=0 WHERE Garni1_IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_GramajArtis'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni1_GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni1_GramajArtis=0 WHERE Garni1_GramajArtis IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_Iplik'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_Iplik=0 WHERE Garni2_Iplik IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_IpGramaj'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_IpGramaj=0 WHERE Garni2_IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_013_Manset2cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_GramajArtis'))
ALTER TABLE SipDetayParam_013_Manset2cm ADD Garni2_GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_013_Manset2cm SET Garni2_GramajArtis=0 WHERE Garni2_GramajArtis IS NULL

GO


-- 6 cm icin



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Iplik'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Iplik=0 WHERE Iplik IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IpGramaj'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET IpGramaj=0 WHERE IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'GramajArtis'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET GramajArtis=0 WHERE GramajArtis IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_Iplik'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_Iplik=0 WHERE Garni1_Iplik IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_IpGramaj'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_IpGramaj=0 WHERE Garni1_IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni1_GramajArtis'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni1_GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni1_GramajArtis=0 WHERE Garni1_GramajArtis IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_Iplik'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_Iplik INT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_Iplik=0 WHERE Garni2_Iplik IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_IpGramaj'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_IpGramaj FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_IpGramaj=0 WHERE Garni2_IpGramaj IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_014_Manset6cm') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Garni2_GramajArtis'))
ALTER TABLE SipDetayParam_014_Manset6cm ADD Garni2_GramajArtis FLOAT NULL DEFAULT 0
GO

UPDATE SipDetayParam_014_Manset6cm SET Garni2_GramajArtis=0 WHERE Garni2_GramajArtis IS NULL

GO


