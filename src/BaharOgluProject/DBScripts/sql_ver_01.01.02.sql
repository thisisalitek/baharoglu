

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_017_DubleLastikIcCep')
    DROP TABLE KategoriParam_017_DubleLastikIcCep

GO

CREATE TABLE KategoriParam_017_DubleLastikIcCep (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[CizgiSayisi] [int] NULL DEFAULT 0 ,
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_017_DubleLastikIcCep')
    DROP TABLE SipDetayParam_017_DubleLastikIcCep

GO


CREATE TABLE SipDetayParam_017_DubleLastikIcCep (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NOT NULL ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[CizgiSayisi] [int] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 ,
	[RKafa] [varchar] (100) NULL DEFAULT '',
	CizgiRKafaID INT NULL DEFAULT 0
)
GO


DELETE FROM ParamSira

GO

INSERT INTO ParamSira (SiraNo, ParamType) VALUES (1,'001')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (2,'009')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (3,'011')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (4,'002')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (5,'003')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (6,'004')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (7,'017')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (8,'005')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (9,'006')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (10,'007')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (11,'008')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (12,'010')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (13,'012')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (14,'013')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (15,'014')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (16,'015')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (17,'016')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (18,'017')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (19,'018')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (20,'019')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (21,'020')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (22,'051')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (23,'052')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (24,'053')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (25,'054')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (26,'055')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (27,'056')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (28,'057')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (29,'058')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (30,'059')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (31,'060')

GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[spKategoriKopyala](@KaynakID INT,@HedefID INT , @UserID INT )
AS 
BEGIN
BEGIN TRANSACTION

DELETE FROM KategoriParam WHERE KategoriID = @HedefID
INSERT INTO KategoriParam (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriID, ParamType, Secmeli, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, IpGramaj, IpGramajArtis, IntParam1, IntParam2, IntParam3)
SELECT Deleted,@UserID as CreatedBy,GETDATE() as CreatedDate,@UserID as ModifiedBy,GETDATE() as ModifiedDate,@HedefID as KategoriID, ParamType, Secmeli, HammaddeID, Tur, TurArtis, BelTur, BelTurArtis, KolTur, KolTurArtis, IpGramaj, IpGramajArtis, IntParam1, IntParam2, IntParam3
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


DELETE FROM KategoriParam_010_GomlekParams
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_010_GomlekParams (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Pensli, Yaka, Cepli)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='010' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Pensli, CNT.Yaka, CNT.Cepli
FROM KategoriParam_010_GomlekParams CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_011_LakosKumas
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_011_LakosKumas (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, ParcaIsmi, OrguTip, Iplik, IpGramaj, KumasGramaj, GramajArtis)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='011' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ParcaIsmi, CNT.OrguTip, CNT.Iplik, CNT.IpGramaj, CNT.KumasGramaj, CNT.GramajArtis
FROM KategoriParam_011_LakosKumas CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_012_LakosYaka
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_012_LakosYaka (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, YakaTip, Iplik, IpGramaj, GramajArtis, SimitKumasYuzde)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='012' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.YakaTip, CNT.Iplik, CNT.IpGramaj, CNT.GramajArtis, CNT.SimitKumasYuzde
FROM KategoriParam_012_LakosYaka CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID

DELETE FROM KategoriParam_013_Manset2cm
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_013_Manset2cm (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Iplik, IpGramaj, GramajArtis)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='013' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Iplik, CNT.IpGramaj, CNT.GramajArtis
FROM KategoriParam_013_Manset2cm CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_014_Manset6cm
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_014_Manset6cm (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, Iplik, IpGramaj, GramajArtis)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='014' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.Iplik, CNT.IpGramaj, CNT.GramajArtis
FROM KategoriParam_014_Manset6cm CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_015_Fular
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_015_Fular (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID,ParcaIsmi, Iplik, IpGramaj)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='015' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ParcaIsmi,CNT.Iplik, CNT.IpGramaj
FROM KategoriParam_015_Fular CNT INNER JOIN
KategoriParam KP ON KP.KategoriParamID = CNT.KategoriParamID
WHERE KP.Deleted =0 AND KP.KategoriID = @KaynakID


DELETE FROM KategoriParam_016_Kravat
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_016_Kravat (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID,ParcaIsmi)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='016' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ParcaIsmi
FROM KategoriParam_016_Kravat CNT INNER JOIN
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

INSERT INTO KategoriParam_055_Secenek (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, ModelFarki, ParcaModel, Astar, Femuar, OmuzRecme, Arma, OzelEtiket, Fason, FasonID, MansetFarki, UzunKolFarki)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='055' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.ModelFarki, CNT.ParcaModel, CNT.Astar, CNT.Femuar, CNT.OmuzRecme, CNT.Arma, CNT.OzelEtiket, CNT.Fason, CNT.FasonID, CNT.MansetFarki, CNT.UzunKolFarki
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


DELETE FROM KategoriParam_017_DubleLastikIcCep 
WHERE KategoriParamID IN (SELECT KategoriParamID FROM KategoriParam WHERE KategoriID = @HedefID)

INSERT INTO KategoriParam_017_DubleLastikIcCep (Deleted, CreatedBy, CreatedDate, ModifiedBy, ModifiedDate, KategoriParamID, CizgiSayisi, RKafa)
SELECT CNT.Deleted, @UserID, GETDATE() as CreatedDate, @UserID, GETDATE() as ModifiedDate, 
(SELECT KategoriParamID FROM KategoriParam WHERE Deleted = 0 AND ParamType='017' AND KategoriID=@HedefID) as KategoriParamID, 
CNT.CizgiSayisi, CNT.RKafa FROM KategoriParam_017_DubleLastikIcCep CNT INNER JOIN
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
