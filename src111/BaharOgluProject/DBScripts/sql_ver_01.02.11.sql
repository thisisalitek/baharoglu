
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Okullar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Pasif'))
ALTER TABLE Okullar ADD Pasif INT  NULL DEFAULT 0
GO

UPDATE Okullar SET Pasif=0 WHERE Pasif IS NULL

GO
