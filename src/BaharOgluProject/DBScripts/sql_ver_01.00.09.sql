IF NOT  EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_009_Kumas2_Detay')
CREATE TABLE SipDetayParam_009_Kumas2_Detay (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NOT NULL ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[SolOnCep] [int] NULL DEFAULT 0 ,
	[SagOnCep] [int] NULL DEFAULT 0 ,
	[SolArkaCep] [int] NULL DEFAULT 0 ,
	[SagArkaCep] [int] NULL DEFAULT 0 ,
	[GizliCep] [int] NULL DEFAULT 0 ,
	[CepKumasArtis] [float] NULL DEFAULT 0 ,
	[OverlokNakis] [int] NULL DEFAULT 0 ,
	[FarkliKumas] [int] NULL DEFAULT 0 ,
	[Biye] [int] NULL DEFAULT 0 ,
	[BiyeDeger] [float] NULL DEFAULT 0 
)
GO



IF NOT EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayBilgi')
 
CREATE TABLE SipDetayBilgi (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayID] [int] NULL DEFAULT 0 ,
	[GrupKod] [varchar] (30) NULL DEFAULT '',
	[GrupIsmi] [varchar] (50) NULL DEFAULT '',
	[Aciklama] [varchar] (250) NULL DEFAULT ''
)
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_002_Lastik') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_002_Lastik ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_002_Lastik SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_002_Lastik_Kol') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_002_Lastik_Kol ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_002_Lastik_Kol SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_003_Yaka') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_003_Yaka ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_003_Yaka SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_004_DubleLastikCep') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_004_DubleLastikCep ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_004_DubleLastikCep SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_005_DubleLastikPilotYaka') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_005_DubleLastikPilotYaka ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_005_DubleLastikPilotYaka SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_006_DubleLastik') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_006_DubleLastik ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_006_DubleLastik SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_007_DubleYaka') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_007_DubleYaka ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_007_DubleYaka SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetayParam_008_TorbaliBant') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'CizgiRKafaID'))
ALTER TABLE SipDetayParam_008_TorbaliBant ADD CizgiRKafaID INT  NULL DEFAULT 0
GO

UPDATE SipDetayParam_008_TorbaliBant SET CizgiRKafaID = 0 WHERE CizgiRKafaID IS NULL

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype in (N'FN', N'IF', N'TF') and name='fnListe_SipDetayBilgi')
    DROP FUNCTION fnListe_SipDetayBilgi

GO

CREATE FUNCTION [dbo].[fnListe_SipDetayBilgi] ( @SipDetayID INT) RETURNS VARCHAR(4000)
AS
BEGIN
 
DECLARE @GrupIsmi VARCHAR(50)
DECLARE @Aciklama VARCHAR(250)

DECLARE @Desc VARCHAR(4000)
SET @DESC=''

DECLARE Employee_Cursor CURSOR FOR
SELECT GrupIsmi,Aciklama FROM SipDetayBilgi WHERE Deleted = 0 AND SipDetayID =@SipDetayID
OPEN Employee_Cursor

FETCH NEXT FROM Employee_Cursor
INTO @GrupIsmi,@Aciklama
IF @@FETCH_STATUS = 0 BEGIN
	SET @DESC=@DESC + @Aciklama + CHAR(13) + CHAR(10)
END
WHILE @@FETCH_STATUS = 0
BEGIN
   FETCH NEXT FROM Employee_Cursor
   INTO @GrupIsmi,@Aciklama
	IF @@FETCH_STATUS = 0 BEGIN
		SET @DESC=@DESC + @Aciklama + CHAR(13) + CHAR(10)
	END
END
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor

RETURN @DESC

END

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype in (N'P', N'PC') and name='spKategoriKopyala')
    DROP PROCEDURE spKategoriKopyala

GO


CREATE PROCEDURE [dbo].[spKategoriKopyala](@KaynakID INT,@HedefID INT , @UserID INT )
AS 
BEGIN
BEGIN TRANSACTION

DELETE FROM KategoriParam WHERE KategoriID = @HedefID
INSERT INTO KategoriParam (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, ParamType, Secmeli, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, IpGramaj, IpGramajArtis)
SELECT Deleted,@UserID as CreatedBy,GETDATE() as CreatedDate,@UserID as ModifiedBy,GETDATE() as ModifiedDate,@HedefID as KategoriID, ParamType, Secmeli, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, IpGramaj, IpGramajArtis
FROM KategoriParam WHERE Deleted = 0 AND KategoriID = @KaynakID



DELETE FROM KategoriParam_001_Kumas 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_001_Kumas (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, ParcaIsmi, Iplik, IpGramaj, KumasGramaj, GramajArtis)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='001' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ParcaIsmi, CNT.Iplik, CNT.IpGramaj, CNT.KumasGramaj, CNT.GramajArtis FROM KategoriParam_001_Kumas CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

DELETE FROM KategoriParam_002_Lastik 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_002_Lastik (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='002' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_002_Lastik CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_003_Yaka 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_003_Yaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='003' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_003_Yaka CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_004_DubleLastikCep 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_004_DubleLastikCep (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='004' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_004_DubleLastikCep CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_005_DubleLastikPilotYaka 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_005_DubleLastikPilotYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='005' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_005_DubleLastikPilotYaka CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_006_DubleLastik 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_006_DubleLastik (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='006' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_006_DubleLastik CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_007_DubleYaka 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_007_DubleYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='007' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_007_DubleYaka CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

DELETE FROM KategoriParam_008_TorbaliBant 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_008_TorbaliBant (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='008' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_008_TorbaliBant CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_009_Kumas2 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_009_Kumas2 (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, ParcaNo, ParcaIsmi, BedenKod, Miktar)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='009' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ParcaNo, CNT.ParcaIsmi, CNT.BedenKod, CNT.Miktar
FROM KategoriParam_009_Kumas2 CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

DELETE FROM KategoriParam_009_Kumas2_Detay 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_009_Kumas2_Detay (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, SolOnCep, SagOnCep, SolArkaCep, SagArkaCep, GizliCep, CepKumasArtis, OverlokNakis, FarkliKumas, Biye, BiyeDeger)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='009' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.SolOnCep, CNT.SagOnCep, CNT.SolArkaCep, CNT.SagArkaCep, CNT.GizliCep, CNT.CepKumasArtis, CNT.OverlokNakis, CNT.FarkliKumas, CNT.Biye, CNT.BiyeDeger
FROM KategoriParam_009_Kumas2_Detay CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

DELETE FROM KategoriParam_051_Tip 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_051_Tip (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Tip)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='051' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Tip
FROM KategoriParam_051_Tip CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_055_Secenek 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_055_Secenek (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, ModelFarki, ParcaModel, Astar, Femuar, OmuzRecme)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='055' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ModelFarki, CNT.ParcaModel, CNT.Astar, CNT.Femuar, CNT.OmuzRecme
FROM KategoriParam_055_Secenek CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_056_EkFiyat 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_056_EkFiyat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Aciklama, Fiyat, BedenArtis)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='056' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Aciklama, CNT.Fiyat, CNT.BedenArtis
FROM KategoriParam_056_EkFiyat CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID



DELETE FROM KategoriParam_057_EkOzellikler 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_057_EkOzellikler (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Aciklama)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='057' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Aciklama
FROM KategoriParam_057_EkOzellikler CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

IF @@ERROR<>0 BEGIN
	IF @@TRANCOUNT >0 ROLLBACK 
	RAISERROR ('Hata olustu', 16, 1)
END ELSE BEGIN
	IF @@TRANCOUNT >0 COMMIT TRANSACTION 
END
END

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'OrguTipleri') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Fiyat'))
ALTER TABLE OrguTipleri ADD Fiyat FLOAT  NULL DEFAULT 0
GO

UPDATE OrguTipleri SET Fiyat = 0 WHERE Fiyat IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'OrguTipleri') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'BedenArtis'))
ALTER TABLE OrguTipleri ADD BedenArtis FLOAT  NULL DEFAULT 0
GO

UPDATE OrguTipleri SET BedenArtis = 0 WHERE BedenArtis IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kumaslar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Fiyat'))
ALTER TABLE Kumaslar ADD Fiyat FLOAT  NULL DEFAULT 0
GO

UPDATE Kumaslar SET Fiyat = 0 WHERE Fiyat IS NULL

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Kumaslar') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'BedenArtis'))
ALTER TABLE Kumaslar ADD BedenArtis FLOAT  NULL DEFAULT 0
GO

UPDATE Kumaslar SET BedenArtis = 0 WHERE BedenArtis IS NULL

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim1'))
ALTER TABLE SipDetay ADD Resim1 IMAGE  NULL
GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim2'))
ALTER TABLE SipDetay ADD Resim2 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim3'))
ALTER TABLE SipDetay ADD Resim3 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim4'))
ALTER TABLE SipDetay ADD Resim4 IMAGE  NULL
GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Resim5'))
ALTER TABLE SipDetay ADD Resim5 IMAGE  NULL
GO




