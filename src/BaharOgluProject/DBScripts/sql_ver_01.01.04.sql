IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bSerbestFiyat'))
ALTER TABLE SipDetay ADD bSerbestFiyat INT DEFAULT 0
GO

UPDATE SipDetay SET bSerbestFiyat=0 WHERE bSerbestFiyat IS NULL

GO

