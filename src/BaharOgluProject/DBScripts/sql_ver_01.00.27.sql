


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TeslimMiktar'))
ALTER TABLE SipDetay ADD TeslimMiktar FLOAT  NULL DEFAULT 0
GO

UPDATE SipDetay SET TeslimMiktar=0 WHERE TeslimMiktar IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TeslimMiktar'))
ALTER TABLE SipDetayFiyatlar ADD TeslimMiktar FLOAT  NULL DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET TeslimMiktar=0 WHERE TeslimMiktar IS NULL

GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Kargolar')
    DROP TABLE Kargolar

GO


CREATE TABLE Kargolar (
	KargoID [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	KargoIsmi VARCHAR(50) NULL DEFAULT '',
	KargoWebLink VARCHAR(100) NULL DEFAULT '',
	Pasif INT NULL DEFAULT 0
) 
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'AnaRenk'))
ALTER TABLE SipDetay ADD AnaRenk VARCHAR(200)  NULL DEFAULT ''
GO

UPDATE SipDetay SET AnaRenk='' WHERE AnaRenk IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Bedenler'))
ALTER TABLE SipDetay ADD Bedenler VARCHAR(400)  NULL DEFAULT ''
GO

UPDATE SipDetay SET Bedenler='' WHERE Bedenler IS NULL

GO



