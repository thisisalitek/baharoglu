
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='KategoriEkFiyat')
    DROP TABLE KategoriEkFiyat

GO

CREATE TABLE KategoriEkFiyat (
	[KategoriEkFiyatID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[KategoriID] [int] NOT NULL ,
	[MasrafKod] [varchar] (10) NULL DEFAULT '' ,
	[MasrafIsmi] [varchar] (50) NULL DEFAULT '' ,
	[Fiyat] [float] NULL DEFAULT 0 ,
	[BedenArtis] [float] NULL DEFAULT 0 
)
GO





-- Piconn_ReportDesigns --
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Piconn_ReportDesigns')
    DROP TABLE Piconn_ReportDesigns

GO

CREATE TABLE Piconn_ReportDesigns(
    ReportID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT (NEWID())  , 
    RowID INT IDENTITY(1,1) , 
    Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0  , AuthCode NVARCHAR(15) DEFAULT '' ,  
    ApplicationCode NVARCHAR(30) NULL DEFAULT ''  , 
    FormCode NVARCHAR(30) NULL DEFAULT ''  , 
    ReportName NVARCHAR(100) NULL DEFAULT ''  , 
    ReportData IMAGE NULL  , 
    ReportSQL IMAGE NULL  , 
    bDefault INT NULL DEFAULT 0  , 
    ReportType INT NULL DEFAULT 0  , 
    IntCode NVARCHAR(50) NULL DEFAULT '', Transferred INT NULL DEFAULT 0  , 
    TransferDate DATETIME NULL DEFAULT 0 ,
	Locked INT NULL DEFAULT 0  , 
	LockedBy INT NULL DEFAULT 0 
)

GO



IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Users')
    DROP TABLE Users

GO

CREATE TABLE Users (
	[UserID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	[UserName] [varchar] (30) NULL DEFAULT '' ,
	[Password] [varchar] (50) NULL DEFAULT '' ,
	[FullName] [varchar] (50) NULL DEFAULT '' ,
	[bAdmin] [int] NULL DEFAULT 0
)
GO


INSERT INTO Users (Deleted,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate, UserName, Password, FullName, bAdmin)
VALUES (0,0,GETDATE(),0,GETDATE(), 'admin', '', 'Admin User', 1)

GO


