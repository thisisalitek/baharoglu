
IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'IskontoTutar'))
ALTER TABLE SipDetay ADD IskontoTutar FLOAT NULL DEFAULT 0

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'NakitIskontoTutar'))
ALTER TABLE SipDetay ADD NakitIskontoTutar FLOAT NULL DEFAULT 0

GO

UPDATE SipDetay SET IskontoTutar=SDF.IskontoTutar,NakitIskontoTutar= SDF.NakitIskontoTutar   FROM SipDetay INNER JOIN
(SELECT SipDetayID, SUM(BrutFiyat*Miktar * Iskonto/100) as IskontoTutar,SUM(Miktar*(BrutFiyat - BrutFiyat * Iskonto/100)*NakitIskonto/100) as  NakitIskontoTutar FROM SipDetayFiyatlar 
GROUP BY SipDetayID) SDF ON SDF.SipDetayID = SipDetay.SipDetayID

GO

UPDATE SipDetay SET Miktar=SDF.TMiktar,Tutar=SDF.TTutar , Fiyat= CASE WHEN SDF.TMiktar>0 THEN SDF.TTutar/SDF.TMiktar ELSE 0 END   FROM SipDetay INNER JOIN
(SELECT SipDetayID, SUM(Miktar) as TMiktar, SUM(Tutar) as TTutar FROM SipDetayFiyatlar
WHERE Deleted=0 
GROUP BY SipDetayID) SDF ON SDF.SipDetayID=SipDetay.SipDetayID
WHERE SipDetay.Deleted=0 AND SipDetay.Miktar=0 AND SipDetay.Fiyat=0

GO
