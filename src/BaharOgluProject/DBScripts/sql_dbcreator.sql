

-- Piconn_Variants --
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Piconn_Variants')
    DROP TABLE Piconn_Variants

GO

CREATE TABLE Piconn_Variants(
    VariantID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID())  , 
    RowID INT IDENTITY(1,1) , 
    Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0  , AuthCode NVARCHAR(15) DEFAULT '' ,  
    VariantName NVARCHAR(100) NULL DEFAULT ''  , 
    VariantValue NVARCHAR(255) NULL DEFAULT ''  , 
    IntCode NVARCHAR(50) NULL DEFAULT '', Transferred INT NULL DEFAULT 0  , 
    TransferDate DATETIME NULL DEFAULT 0 
)

GO


INSERT INTO Piconn_Variants(Deleted,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,VariantName,VariantValue) VALUES (
0,0,GETDATE(),0,GETDATE(),'Version','1.0.1')

GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='CizgiRenkKafa')
    DROP TABLE CizgiRenkKafa

GO

CREATE TABLE CizgiRenkKafa (
	[CizgiRKafaID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Tip] [varchar] (30)  NULL DEFAULT '' ,
	[Aciklama] [varchar] (50)  NULL DEFAULT '' ,
	[CizgiSayisi] [int] NULL DEFAULT 0 ,
	[RKafa] [varchar] (200)  NULL DEFAULT '' 
) 
GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='CizgiRenkKafaLakos')
    DROP TABLE CizgiRenkKafaLakos

GO

CREATE TABLE CizgiRenkKafaLakos (
	[CizgiRKafaLakosID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY  ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Aciklama] [varchar] (50)  NULL DEFAULT '' ,
	[CizgiSayisi] [int]  NULL DEFAULT 0 ,
	[Gramaj] [float]  NULL DEFAULT 0 
) 
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Fason')
    DROP TABLE Fason

GO

CREATE TABLE Fason (
	[FasonID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[FasonAciklama] [varchar] (50) NULL DEFAULT '' ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[BedenFark] [float] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Il')
    DROP TABLE Il

GO

CREATE TABLE Il (
	[IlID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[IlKod] [varchar] (5) NULL DEFAULT '' ,
	[IlIsmi] [varchar] (50) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Ilce')
    DROP TABLE Ilce

GO

CREATE TABLE Ilce (
	[IlceID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[IlID] [int] NULL DEFAULT 0 ,
	[IlceIsmi] [varchar] (50) NULL DEFAULT '' 
)
GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Iplikler')
    DROP TABLE Iplikler

GO

CREATE TABLE Iplikler (
	[IplikID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[IplikKod] [nvarchar] (30) NULL DEFAULT '' ,
	[IplikIsmi] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[Pasif] [int] NULL DEFAULT 0 ,
	[StokFiltre] [nvarchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriFiyat')
    DROP TABLE KategoriFiyat

GO

CREATE TABLE KategoriFiyat (
	[KategoriFiyatID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriID] [int] NOT NULL ,
	[BedenNo] [int] NULL DEFAULT 0 ,
	[BedenKod] [varchar] (10) NULL DEFAULT '' ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[BazBedenMi] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam')
    DROP TABLE KategoriParam

GO

CREATE TABLE KategoriParam (
	[KategoriParamID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriID] [int] NOT NULL ,
	[ParamType] [nvarchar] (30) NULL DEFAULT '' ,
	[Secmeli] [int] NULL DEFAULT 0 ,
	[HammaddeID] [int] NULL DEFAULT 0 ,
	[Tur] [float] NULL DEFAULT 0 ,
	[TurArtis] [float] NULL DEFAULT 0 ,
	[BelTur] [float] NULL DEFAULT 0 ,
	[BelTurArtis] [float] NULL DEFAULT 0 ,
	[KolTur] [float] NULL DEFAULT 0 ,
	[KolTurArtis] [float] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[IpGramajArtis] [float] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_001_Kumas')
    DROP TABLE KategoriParam_001_Kumas

GO

CREATE TABLE KategoriParam_001_Kumas (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[KumasGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_002_Lastik')
    DROP TABLE KategoriParam_002_Lastik

GO

CREATE TABLE KategoriParam_002_Lastik (
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

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_003_Yaka')
    DROP TABLE KategoriParam_003_Yaka

GO

CREATE TABLE KategoriParam_003_Yaka (
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

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_004_DubleLastikCep')
    DROP TABLE KategoriParam_004_DubleLastikCep

GO

CREATE TABLE KategoriParam_004_DubleLastikCep (
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

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_005_DubleLastikPilotYaka')
    DROP TABLE KategoriParam_005_DubleLastikPilotYaka

GO

CREATE TABLE KategoriParam_005_DubleLastikPilotYaka (
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


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_006_DubleLastik')
    DROP TABLE KategoriParam_006_DubleLastik

GO

CREATE TABLE KategoriParam_006_DubleLastik (
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


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_007_DubleYaka')
    DROP TABLE KategoriParam_007_DubleYaka

GO

CREATE TABLE KategoriParam_007_DubleYaka (
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



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_008_TorbaliBant')
    DROP TABLE KategoriParam_008_TorbaliBant

GO

CREATE TABLE KategoriParam_008_TorbaliBant (
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

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_009_Kumas2')
    DROP TABLE KategoriParam_009_Kumas2

GO

CREATE TABLE KategoriParam_009_Kumas2 (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ParcaNo] [int] NULL DEFAULT 0,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[BedenKod] [varchar] (10) NULL DEFAULT '' ,
	[Miktar] [float] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_009_Kumas2_Detay')
    DROP TABLE KategoriParam_009_Kumas2_Detay

GO

CREATE TABLE KategoriParam_009_Kumas2_Detay (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
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


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_051_Tip')
    DROP TABLE KategoriParam_051_Tip

GO

CREATE TABLE KategoriParam_051_Tip (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Tip] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_055_Secenek')
    DROP TABLE KategoriParam_055_Secenek

GO

CREATE TABLE KategoriParam_055_Secenek (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[ModelFarki] [int] NULL DEFAULT 0 ,
	[ParcaModel] [int] NULL DEFAULT 0 ,
	[Astar] [int] NULL DEFAULT 0 ,
	[Femuar] [int] NULL DEFAULT 0 ,
	[OmuzRecme] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_056_EkFiyat')
    DROP TABLE KategoriParam_056_EkFiyat

GO

CREATE TABLE KategoriParam_056_EkFiyat (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Aciklama] [varchar] (50) NULL DEFAULT '' ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[BedenArtis] [float] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Kategoriler')
    DROP TABLE Kategoriler

GO

CREATE TABLE Kategoriler (
	[KategoriID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[UstKategoriID] [int] NULL DEFAULT 0 ,
	[KategoriKod] [nvarchar] (30) NULL DEFAULT '' ,
	[KategoriIsim] [nvarchar] (50) NULL DEFAULT '' ,
	[StokKodFormat] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[tempGrup] [varchar] (50) NULL DEFAULT '' 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='OkulTurleri')
    DROP TABLE OkulTurleri

GO

CREATE TABLE OkulTurleri  (
	[OkulTurID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[OkulTuru] [varchar] (50) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Okullar')
    DROP TABLE Okullar

GO

CREATE TABLE Okullar (
	[OkulID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[OkulKod] [varchar] (20) NULL DEFAULT '' ,
	[OkulIsmi] [varchar] (100) NULL DEFAULT '' ,
	[IlceID] [int] NULL DEFAULT 0 ,
	[IlID] [int] NULL DEFAULT 0 ,
	[Tel] [varchar] (20) NULL DEFAULT '' ,
	[Fax] [varchar] (20) NULL DEFAULT '' ,
	[Adres] [varchar] (200) NULL DEFAULT '' ,
	[OkulTurID] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='OrguTipleri')
    DROP TABLE OrguTipleri

GO

CREATE TABLE OrguTipleri (
	[OrguTipID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[OrguTipKod] [nvarchar] (20) NULL DEFAULT '' ,
	[OrguTipIsmi] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[Pasif] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Renkler')
    DROP TABLE Renkler

GO

CREATE TABLE Renkler (
	[RenkID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[RenkKod] [nvarchar] (20) NULL DEFAULT '' ,
	[RenkIsmi] [nvarchar] (50) NULL DEFAULT '' ,
	[IntCode] [nvarchar] (50) NULL DEFAULT '' ,
	[Pasif] [int] NULL DEFAULT 0 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetay')
    DROP TABLE SipDetay

GO

CREATE TABLE SipDetay (
	[SipDetayID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SiparisID] [int] NULL DEFAULT 0 ,
	[StokKod] [varchar] (50) NULL DEFAULT '' ,
	[StokRecNo] [int] NULL DEFAULT 0 ,
	[SiparisAciklama] [varchar] (100) NULL DEFAULT '' ,
	[OkulID] [int] NULL DEFAULT 0 ,
	[BolumKod] [varchar] (30) NULL DEFAULT '' ,
	[KategoriID] [int] NULL DEFAULT 0 ,
	[Miktar] [float] NULL DEFAULT 0 ,
	[Maliyet] [float] NULL DEFAULT 0 ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[Tutar] [float] NULL DEFAULT 0 ,
	[Tarih] [datetime] NULL ,
	[TerminTarihi] [datetime] NULL ,
	[MusteriSipNo] [varchar] (50) NULL DEFAULT '' ,
	[SiparisiAlan] [varchar] (50) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayFiyatlar')
    DROP TABLE SipDetayFiyatlar

GO

CREATE TABLE SipDetayFiyatlar (
	[SipDetayFiyatAdetID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayID] [int] NULL DEFAULT 0 ,
	[BedenKod] [varchar] (10) NULL DEFAULT '' ,
	[BazFiyat] [float] NULL DEFAULT 0 ,
	[BrutFiyat] [float] NULL DEFAULT 0 ,
	[Iskonto] [float] NULL DEFAULT 0 ,
	[NakitIskonto] [float] NULL DEFAULT 0 ,
	[NetFiyat] [float] NULL DEFAULT 0 ,
	[Miktar] [float] NULL DEFAULT 0 ,
	[Tutar] [float] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam')
    DROP TABLE SipDetayParam

GO

CREATE TABLE SipDetayParam (
	[SipDetayParamID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayID] [int] NULL DEFAULT 0 ,
	[ParamType] [varchar] (30) NULL DEFAULT '' ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[HammaddeID] [int] NULL DEFAULT 0 ,
	[Tur] [float] NULL DEFAULT 0 ,
	[TurArtis] [float] NULL DEFAULT 0 ,
	[BelTur] [float] NULL DEFAULT 0 ,
	[BelTurArtis] [float] NULL DEFAULT 0 ,
	[KolTur] [float] NULL DEFAULT 0 ,
	[KolTurArtis] [float] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 ,
	[CizgiSayisi] [int] NULL DEFAULT 0 ,
	[IntParam1] [int] NULL DEFAULT 0 ,
	[RenkID2] [int] NULL DEFAULT 0 ,
	[CizgiSayisi2] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_001_Kumas')
    DROP TABLE SipDetayParam_001_Kumas

GO

CREATE TABLE SipDetayParam_001_Kumas (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NULL DEFAULT 0 ,
	[SourceID] [int] NULL DEFAULT 0 ,
	[KategoriParamID] [int] NULL DEFAULT 0 ,
	[ParcaIsmi] [varchar] (30) NULL DEFAULT '' ,
	[Iplik] [int] NULL DEFAULT 0 ,
	[IpGramaj] [float] NULL DEFAULT 0 ,
	[KumasGramaj] [float] NULL DEFAULT 0 ,
	[GramajArtis] [float] NULL DEFAULT 0 ,
	[RenkID] [int] NULL DEFAULT 0 ,
	[OrguTip] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_002_Lastik')
    DROP TABLE SipDetayParam_002_Lastik

GO

CREATE TABLE SipDetayParam_002_Lastik (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_002_Lastik_Kol')
    DROP TABLE SipDetayParam_002_Lastik_Kol

GO

CREATE TABLE SipDetayParam_002_Lastik_Kol (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_003_Yaka')
    DROP TABLE SipDetayParam_003_Yaka

GO

CREATE TABLE SipDetayParam_003_Yaka (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_004_DubleLastikCep')
    DROP TABLE SipDetayParam_004_DubleLastikCep

GO


CREATE TABLE SipDetayParam_004_DubleLastikCep (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_005_DubleLastikPilotYaka')
    DROP TABLE SipDetayParam_005_DubleLastikPilotYaka

GO


CREATE TABLE SipDetayParam_005_DubleLastikPilotYaka (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_006_DubleLastik')
    DROP TABLE SipDetayParam_006_DubleLastik

GO

CREATE TABLE SipDetayParam_006_DubleLastik (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_007_DubleYaka')
    DROP TABLE SipDetayParam_007_DubleYaka

GO

CREATE TABLE SipDetayParam_007_DubleYaka (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_008_TorbaliBant')
    DROP TABLE SipDetayParam_008_TorbaliBant

GO

CREATE TABLE SipDetayParam_008_TorbaliBant (
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
	[RKafa] [varchar] (100) NULL DEFAULT '' 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_052_KazakYaka')
    DROP TABLE SipDetayParam_052_KazakYaka

GO

CREATE TABLE SipDetayParam_052_KazakYaka (
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
	[RenkID] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_053_DigerSecenek')
    DROP TABLE SipDetayParam_053_DigerSecenek

GO

CREATE TABLE SipDetayParam_053_DigerSecenek (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Arma] [int] NULL DEFAULT 0 ,
	[OzelEtiket] [int] NULL DEFAULT 0 ,
	[Fason] [int] NULL DEFAULT 0 ,
	[FasonID] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_054_GarniDikis')
    DROP TABLE SipDetayParam_054_GarniDikis

GO


CREATE TABLE SipDetayParam_054_GarniDikis (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[GarniDikis] [int] NULL DEFAULT 0 
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Siparis')
    DROP TABLE Siparis

GO

CREATE TABLE Siparis (
	[SiparisID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[Tarih] [datetime] NULL ,
	[SipEvrakSeri] [varchar] (10) NULL DEFAULT '' ,
	[SipEvrakSira] [int] NULL DEFAULT 0 ,
	[SiparisNo] [varchar] (20) NULL DEFAULT '' ,
	[CariKod] [varchar] (50) NULL DEFAULT '' ,
	[CariUnvan] [varchar] (100) NULL DEFAULT '' ,
	[Aciklama1] [varchar] (50) NULL DEFAULT '' ,
	[Aciklama2] [varchar] (50) NULL DEFAULT '' ,
	[Aciklama3] [varchar] (50) NULL DEFAULT '' 
)
GO

