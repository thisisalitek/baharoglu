
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'sip_Guid'))
ALTER TABLE SipDetay ADD sip_Guid uniqueidentifier NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayFiyatlar') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'sip_Guid'))
ALTER TABLE SipDetayFiyatlar ADD sip_Guid uniqueidentifier NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SevkDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'sth_Guid'))
ALTER TABLE SevkDetay ADD sth_Guid uniqueidentifier NULL

GO
