

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriParam_010_GomlekParams')
    DROP TABLE KategoriParam_010_GomlekParams

GO

CREATE TABLE KategoriParam_010_GomlekParams (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriParamID] [int] NOT NULL ,
	[Pensli] [int] NULL DEFAULT 0 ,
	[Yaka] [int] NULL DEFAULT 0 ,
	[Cepli] [int] NULL DEFAULT 0
)
GO

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayParam_010_GomlekParams')
    DROP TABLE SipDetayParam_010_GomlekParams

GO


CREATE TABLE SipDetayParam_010_GomlekParams (
	[nID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[SipDetayParamID] [int] NOT NULL ,
	[SourceID] [int] NOT NULL ,
	[KategoriParamID] [int] NOT NULL ,
	[Pensli] [int] NULL DEFAULT 0 ,
	[Yaka] [int] NULL DEFAULT 0 ,
	[Cepli] [int] NULL DEFAULT 0
)
GO

