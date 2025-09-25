

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'VadeFarkiOran'))
ALTER TABLE Siparis ADD VadeFarkiOran FLOAT NULL DEFAULT 0
GO

UPDATE Siparis SET VadeFarkiOran=0 WHERE VadeFarkiOran IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'VadeFarkiTutar'))
ALTER TABLE Siparis ADD VadeFarkiTutar FLOAT NULL DEFAULT 0
GO

UPDATE Siparis SET VadeFarkiTutar=0 WHERE VadeFarkiTutar IS NULL

GO

