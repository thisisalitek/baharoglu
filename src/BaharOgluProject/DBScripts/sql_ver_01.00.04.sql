
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Onayli'))
ALTER TABLE Siparis ADD Onayli INT  NULL DEFAULT 0
GO

UPDATE Siparis SET Onayli = 0 WHERE Onayli IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Onaylayan'))
ALTER TABLE Siparis ADD Onaylayan INT  NULL DEFAULT 0
GO

UPDATE Siparis SET Onaylayan = 0 WHERE Onaylayan IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'OnayTarihi'))
ALTER TABLE Siparis ADD OnayTarihi DATETIME  NULL DEFAULT 0
GO

UPDATE Siparis SET OnayTarihi = '1900-1-1' WHERE OnayTarihi IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Iptal'))
ALTER TABLE Siparis ADD Iptal INT  NULL DEFAULT 0
GO

UPDATE Siparis SET Iptal = 0 WHERE Iptal IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IptalNedeni'))
ALTER TABLE Siparis ADD IptalNedeni VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE Siparis SET IptalNedeni = '' WHERE IptalNedeni IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Iptal'))
ALTER TABLE SipDetay ADD Iptal INT  NULL DEFAULT 0
GO

UPDATE SipDetay SET Iptal = 0 WHERE Iptal IS NULL

GO

