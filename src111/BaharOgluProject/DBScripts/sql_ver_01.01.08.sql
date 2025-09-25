IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_006_DubleLastik_Kol')
    DROP TABLE SipDetayParam_006_DubleLastik_Kol

GO

CREATE TABLE SipDetayParam_006_DubleLastik_Kol (
	[nID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SipDetayParamID] [int] NOT NULL,
	[SourceID] [int] NULL,
	[KategoriParamID] [int] NULL,
	[CizgiSayisi] [int] NULL,
	[RenkID] [int] NULL,
	[RKafa] [varchar](100) NULL,
	[CizgiRKafaID] [int] NULL,
)

GO

UPDATE dbo.KategoriParam SET BelTur=Tur , BelTurArtis = TurArtis WHERE ParamType='006'

GO


