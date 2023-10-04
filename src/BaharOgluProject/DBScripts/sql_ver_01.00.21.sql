
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Bagli'))
ALTER TABLE SipDetay ADD Bagli INT  NULL DEFAULT 0
GO

UPDATE SipDetay SET Bagli=0 WHERE Bagli IS NULL

GO



IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'BagliSipDetayID'))
ALTER TABLE SipDetay ADD BagliSipDetayID INT  NULL DEFAULT 0
GO

UPDATE SipDetay SET BagliSipDetayID=0 WHERE BagliSipDetayID IS NULL

GO




