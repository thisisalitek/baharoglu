IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='Saticilar')
    DROP TABLE Saticilar

GO

CREATE TABLE Saticilar (
	[SaticiID] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Deleted] [int] NULL DEFAULT 0,
	[CreatedBy] [int] NULL DEFAULT 0,
	[CreatedDate] [datetime] NULL DEFAULT 0,
	[ModifiedBy] [int] NULL DEFAULT 0,
	[ModifiedDate] [datetime] NULL DEFAULT 0,
	[SaticiIsmi] VARCHAR(100) NULL DEFAULT '',
	[IntCode] VARCHAR(50) NULL DEFAULT ''
)

GO

IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'SaticiID'))
ALTER TABLE Siparis ADD SaticiID INT NULL DEFAULT 0
GO

UPDATE Siparis SET SaticiID=0 WHERE SaticiID IS NULL

GO

