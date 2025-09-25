

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Piconn_ReportDesigns') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'AfterPrintSQL'))
ALTER TABLE Piconn_ReportDesigns ADD AfterPrintSQL IMAGE NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'Iskonto'))
ALTER TABLE SipDetay ADD Iskonto FLOAT NULL DEFAULT 0

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'NakitIskonto'))
ALTER TABLE SipDetay ADD NakitIskonto FLOAT NULL DEFAULT 0

GO

UPDATE SipDetay SET Iskonto=SDF.Iskonto,NakitIskonto= SDF.NakitIskonto   FROM SipDetay INNER JOIN
(SELECT SipDetayID, Iskonto, NakitIskonto FROM SipDetayFiyatlar 
GROUP BY SipDetayID, Iskonto, NakitIskonto) SDF ON SDF.SipDetayID = SipDetay.SipDetayID

GO
