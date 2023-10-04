IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Sevk')
    DROP TABLE Sevk

GO

CREATE TABLE Sevk (
	[SevkID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SevkTipi] [int] NULL DEFAULT 0,
	[Tarih] [datetime] NULL DEFAULT 0,
	[SevkEvrakSeri] varchar(10) NULL DEFAULT '',
	[SevkEvrakSira] INT NULL DEFAULT 0,
	[SevkBelgeNo] varchar(30) NULL DEFAULT '',
	[CariKod] varchar(50) NULL DEFAULT '',
	[CariUnvan] varchar(100) NULL DEFAULT '',
	[Aciklama1] varchar(100) NULL DEFAULT '',
	[Aciklama2] varchar(100) NULL DEFAULT '',
	[Aciklama3] varchar(100) NULL DEFAULT '',
	[TasimaTuru] VARCHAR(50) NULL DEFAULT '',
	[KargoID] [int] NULL DEFAULT 0,
	[KargoEvrakNo] varchar(50) NULL DEFAULT '',
	[YurtDisi] [int] NULL DEFAULT 0,
	[Onayli] int NULL DEFAULT 0,
	[Onaylayan] int NULL DEFAULT 0,
	[OnayTarihi] [datetime] NULL DEFAULT 0,
	[Iptal] [int] NULL DEFAULT 0,
	[IptalNedeni] varchar(50) NULL DEFAULT '',
	[Depo] varchar(50) NULL DEFAULT '',
	[Depo2] varchar(50) NULL DEFAULT '',
	[ToplamAdet] float NULL DEFAULT 0,
	[ToplamPaket] float NULL DEFAULT 0,
	[CekiListesiUygula] [int] NULL 
)

GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SevkSipDetay')
    DROP TABLE SevkSipDetay

GO

CREATE TABLE SevkSipDetay (
	[SevkSipDetayID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SevkID] [int] NULL DEFAULT 0,
	[SiparisID] INT NULL DEFAULT 0,
	[SipDetayID] INT NULL DEFAULT 0
)

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SevkPaket')
    DROP TABLE SevkPaket

GO

CREATE TABLE SevkPaket (
	[SevkPaketID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SevkID] [int] NULL DEFAULT 0,
	[PaketNo] INT NULL DEFAULT 0, 
	[NetAgirlik] float NULL DEFAULT 0,
	[Dara] float NULL DEFAULT 0,
	[BrutAgirlik] float NULL DEFAULT 0,
	[En] float NULL DEFAULT 0,
	[Boy] float NULL DEFAULT 0,
	[Yukseklik] float NULL DEFAULT 0

)

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SevkDetay')
    DROP TABLE SevkDetay

GO

CREATE TABLE SevkDetay (
	[SevkDetayID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SevkID] [int] NULL DEFAULT 0,
	[SipDetayID] [int] NULL DEFAULT 0,
	[SipDetayFiyatAdetID] [int] NULL DEFAULT 0,
	[SevkPaketID] VARCHAR(50) NULL DEFAULT '',
	[PaketNo] INT NULL DEFAULT 0, 
	[BedenKod] varchar(10) NULL DEFAULT '',
	[Adet] [float] NULL DEFAULT 0,
	[DetayAciklama] varchar(50) NULL DEFAULT '',
	[RenkKod] varchar(200) NULL DEFAULT ''
	
)

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sip_RECno'))
ALTER TABLE SipDetayFiyatlar ADD sip_RECno INT DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET sip_RECno=0 WHERE sip_RECno IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sip_evrakno_seri'))
ALTER TABLE SipDetayFiyatlar ADD sip_evrakno_seri VARCHAR(10) DEFAULT ''
GO

UPDATE SipDetayFiyatlar SET sip_evrakno_seri='' WHERE sip_evrakno_seri IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sip_evrakno_sira'))
ALTER TABLE SipDetayFiyatlar ADD sip_evrakno_sira INT DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET sip_evrakno_sira=0 WHERE sip_evrakno_sira IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sip_satirno'))
ALTER TABLE SipDetayFiyatlar ADD sip_satirno INT DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET sip_satirno=0 WHERE sip_satirno IS NULL

GO




IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SevkDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sth_RECno'))
ALTER TABLE SevkDetay ADD sth_RECno INT DEFAULT 0
GO

UPDATE SevkDetay SET sth_RECno=0 WHERE sth_RECno IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SevkDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sth_evrakno_seri'))
ALTER TABLE SevkDetay ADD sth_evrakno_seri VARCHAR(10) DEFAULT ''
GO

UPDATE SevkDetay SET sth_evrakno_seri='' WHERE sth_evrakno_seri IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SevkDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sth_evrakno_sira'))
ALTER TABLE SevkDetay ADD sth_evrakno_sira INT DEFAULT 0
GO

UPDATE SevkDetay SET sth_evrakno_sira=0 WHERE sth_evrakno_sira IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SevkDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'sth_satirno'))
ALTER TABLE SevkDetay ADD sth_satirno INT DEFAULT 0
GO

UPDATE SevkDetay SET sth_satirno=0 WHERE sth_satirno IS NULL

GO
