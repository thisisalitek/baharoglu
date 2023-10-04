IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='PlanlananTahsilatVeOdemeler')
    DROP TABLE PlanlananTahsilatVeOdemeler

GO

CREATE TABLE PlanlananTahsilatVeOdemeler (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	Turu INT NULL DEFAULT 0 , -- 0: Odeme , 1: tahsilat
	Tarih DATETIME NULL DEFAULT 0,
	CariKod VARCHAR(50) NULL DEFAULT '',
	CariUnvan VARCHAR(100) NULL DEFAULT '',
	DigerUnvan VARCHAR(100) NULL DEFAULT '',
	Hesap VARCHAR(100) NULL DEFAULT '',
	TerminTarihi DATETIME NULL DEFAULT 0,
	PersonelID INT NULL DEFAULT 0,
	Tutar FLOAT NULL DEFAULT 0 ,
	GelenTutar FLOAT NULL DEFAULT 0 ,
	DovizTipi varchar(5) NULL DEFAULT '',
	DovizKuru	float NULL DEFAULT 0 ,
	TutarTL float NULL DEFAULT 0 ,
	Aciklama VARCHAR(100) NULL DEFAULT '',
	Kapali INT NULL DEFAULT 0,
	KapanmaTarihi DATETIME NULL DEFAULT 0 ,
	Iptal INT NULL DEFAULT 0,
	IntCode VARCHAR(50) NULL DEFAULT ''
)

GO


