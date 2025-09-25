
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'SiparisType'))
ALTER TABLE Siparis ADD SiparisType INT  NULL DEFAULT 0
GO

UPDATE Siparis SET SiparisType=0 WHERE SiparisType IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Depo'))
ALTER TABLE Siparis ADD Depo VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE Siparis SET Depo = '' WHERE Depo IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Depo2'))
ALTER TABLE Siparis ADD Depo2 VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE Siparis SET Depo2 = '' WHERE Depo2 IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'DetayAciklama'))
ALTER TABLE SipDetayFiyatlar ADD DetayAciklama VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE SipDetayFiyatlar SET DetayAciklama = '' WHERE DetayAciklama IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'RenkKod'))
ALTER TABLE SipDetayFiyatlar ADD RenkKod VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE SipDetayFiyatlar SET RenkKod = '' WHERE RenkKod IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'BdnHarNo'))
ALTER TABLE SipDetayFiyatlar ADD BdnHarNo INT  NULL DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET BdnHarNo = 0 WHERE BdnHarNo IS NULL

GO



