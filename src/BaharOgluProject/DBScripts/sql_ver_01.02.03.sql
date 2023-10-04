
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='FasonFis')
    DROP TABLE FasonFis

GO

CREATE TABLE FasonFis (
	[FasonFisID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[FasonTuru] VARCHAR(50) NULL DEFAULT 0,
	[Tarih] [datetime] NULL DEFAULT 0,
	[FasonTermin] [datetime] NULL DEFAULT 0,
	[FasonEvrakSeri] varchar(10) NULL DEFAULT '',
	[FasonEvrakSira] INT NULL DEFAULT 0,
	[FasonBelgeNo] varchar(30) NULL DEFAULT '',
	[CariKod] varchar(50) NULL DEFAULT '',
	[CariUnvan] varchar(100) NULL DEFAULT '',
	[Aciklama1] varchar(100) NULL DEFAULT '',
	[Aciklama2] varchar(100) NULL DEFAULT '',
	[Aciklama3] varchar(100) NULL DEFAULT '',
	[SiparisID] [int] NULL DEFAULT 0,
	[SipDetayID] [int] NULL DEFAULT 0,	
	[Adet] float NULL DEFAULT 0,
	[Agirlik] float NULL DEFAULT 0,
	[Iptal] INT NULL DEFAULT 0,
	[Kapali] INT NULL DEFAULT 0,
	[KapanmaTarihi] [datetime] NULL DEFAULT 0
)

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'FasondaMi'))
ALTER TABLE SipDetay ADD FasondaMi INT NULL DEFAULT 0
GO

UPDATE SipDetay SET FasondaMi=0 WHERE FasondaMi IS NULL

GO




