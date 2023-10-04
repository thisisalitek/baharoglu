
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'KategoriFiyatID'))
ALTER TABLE SipDetayFiyatlar ADD KategoriFiyatID INT  NULL DEFAULT 0
GO

UPDATE SipDetayFiyatlar SET KategoriFiyatID = 0 WHERE KategoriFiyatID IS NULL

GO

