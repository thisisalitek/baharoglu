
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'KategoriParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'StokIsmi'))
ALTER TABLE SipDetay ADD StokIsmi VARCHAR(200)  NULL DEFAULT 0
GO

UPDATE SipDetay SET StokIsmi = '' WHERE StokIsmi IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Okullar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'IntCode'))
ALTER TABLE Okullar ADD IntCode VARCHAR(50)  NULL DEFAULT 0
GO

UPDATE Okullar SET IntCode = '' WHERE IntCode IS NULL

GO
