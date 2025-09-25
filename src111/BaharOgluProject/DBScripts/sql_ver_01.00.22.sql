
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'OdemeDurumu'))
ALTER TABLE Siparis ADD OdemeDurumu VARCHAR(30)  NULL DEFAULT ''
GO

UPDATE Siparis SET OdemeDurumu='' WHERE OdemeDurumu IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Odenen'))
ALTER TABLE Siparis ADD Odenen FLOAT  NULL DEFAULT 0
GO

UPDATE Siparis SET Odenen=0 WHERE Odenen IS NULL

GO




