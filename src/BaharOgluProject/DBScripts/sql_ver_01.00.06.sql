
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'bVar'))
ALTER TABLE SipDetayParam ADD bVar INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam SET bVar = 0 WHERE bVar IS NULL

GO
