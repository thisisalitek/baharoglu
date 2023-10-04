DELETE FROM KategoriFiyat WHERE CreatedBy=-99 AND CreatedDate>='2017-08-01';
DELETE FROM KategoriEkFiyat WHERE CreatedBy=-99 AND CreatedDate>='2017-08-01';

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'KendiFiyatBedenKullan'))
ALTER TABLE Kategoriler ADD KendiFiyatBedenKullan INT NULL DEFAULT 0
GO

UPDATE Kategoriler SET KendiFiyatBedenKullan=0 WHERE KendiFiyatBedenKullan IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kategoriler') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'KendiMasrafKullan'))
ALTER TABLE Kategoriler ADD KendiMasrafKullan INT NULL DEFAULT 0
GO

UPDATE Kategoriler SET KendiMasrafKullan=0 WHERE KendiMasrafKullan IS NULL

GO
