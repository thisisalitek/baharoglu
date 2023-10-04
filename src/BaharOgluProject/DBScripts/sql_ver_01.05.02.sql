IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SiparisAlanlar')
    DROP TABLE SiparisAlanlar

GO

CREATE TABLE SiparisAlanlar (
	[SiparisAlanID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SipAlanIsmi] VARCHAR(100) NULL DEFAULT '',
	[IntCode] VARCHAR(50) NULL DEFAULT ''
)

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'SiparisAlanID'))
ALTER TABLE Siparis ADD SiparisAlanID INT NULL DEFAULT 0
GO

UPDATE Siparis SET SiparisAlanID=0 WHERE SiparisAlanID IS NULL

GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Boyahaneler')
    DROP TABLE Boyahaneler

GO

CREATE TABLE Boyahaneler (
	[BoyahaneID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[Boyahane] VARCHAR(100) NULL DEFAULT '',
	[IntCode] VARCHAR(50) NULL DEFAULT ''
)

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'BoyahaneID'))
ALTER TABLE SipDetay ADD BoyahaneID INT NULL DEFAULT 0
GO

UPDATE SipDetay SET BoyahaneID=0 WHERE BoyahaneID IS NULL

GO
