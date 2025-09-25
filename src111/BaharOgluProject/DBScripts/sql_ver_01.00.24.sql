
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='ParamSira')
    DROP TABLE ParamSira

GO

CREATE TABLE ParamSira (
	[nID] [int] IDENTITY(1,1) NOT NULL  PRIMARY KEY ,
	[SiraNo] [int] NULL DEFAULT 0 ,
	[ParamType] [nvarchar](30) NULL DEFAULT ''
)
GO

INSERT INTO ParamSira (SiraNo, ParamType) VALUES (1,'001')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (2,'009')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (3,'011')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (4,'002')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (5,'003')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (6,'004')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (7,'005')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (8,'006')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (9,'007')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (10,'008')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (11,'010')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (12,'012')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (13,'013')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (14,'014')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (15,'015')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (16,'016')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (17,'017')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (18,'018')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (19,'019')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (20,'020')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (21,'051')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (22,'052')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (23,'053')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (24,'054')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (25,'055')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (26,'056')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (27,'057')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (28,'058')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (29,'059')
INSERT INTO ParamSira (SiraNo, ParamType) VALUES (30,'060')

