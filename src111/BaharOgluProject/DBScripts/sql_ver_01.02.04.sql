
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'FasonFis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Parca'))
ALTER TABLE FasonFis ADD Parca VARCHAR(50) NULL DEFAULT ''
GO

UPDATE FasonFis SET Parca='' WHERE Parca IS NULL

GO




