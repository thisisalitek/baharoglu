
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Hazirlanan'))
ALTER TABLE SipDetayFiyatlar ADD Hazirlanan Float DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET Hazirlanan=0 WHERE Hazirlanan IS NULL

GO




IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'TeslimMiktar'))
ALTER TABLE SipDetay ADD TeslimMiktar Float DEFAULT 0
GO

UPDATE SipDetay SET TeslimMiktar=0 WHERE TeslimMiktar IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Hazirlanan'))
ALTER TABLE SipDetay ADD Hazirlanan Float DEFAULT 0
GO

UPDATE SipDetay SET Hazirlanan=0 WHERE Hazirlanan IS NULL

GO

