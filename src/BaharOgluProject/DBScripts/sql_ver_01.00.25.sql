
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'OkulFarki'))
ALTER TABLE SipDetay ADD OkulFarki FLOAT  NULL DEFAULT 0
GO

UPDATE SipDetay SET OkulFarki=0 WHERE OkulFarki IS NULL

GO




