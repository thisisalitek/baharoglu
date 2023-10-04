
IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='SipDetayEkFiyatlar')
    DROP TABLE SipDetayEkFiyatlar

GO

CREATE TABLE SipDetayEkFiyatlar (
	[SipDetayEkFiyatID] [int] IDENTITY (1, 1) NOT NULL PRIMARY KEY ,
	Deleted INT NULL DEFAULT 0  , 
    CreatedBy INT NULL DEFAULT 0  , 
    CreatedDate DATETIME NULL DEFAULT 0  , 
    ModifiedBy INT NULL DEFAULT 0  , 
    ModifiedDate DATETIME NULL DEFAULT 0 , 
	SipDetayID INT NULL DEFAULT 0,
	[MasrafKod] [varchar] (30)  NULL DEFAULT '' ,
	[MasrafIsmi] [varchar] (100)  NULL DEFAULT '' ,
	[EkFiyat] [float] NULL DEFAULT 0, 
	[BedenArtis] [float] NULL DEFAULT 0
) 
GO


IF EXISTS (SELECT * FROM sysobjects WHERE xtype in (N'FN', N'IF', N'TF') and name='fnListe_SipDetayEkFiyatlar')
    DROP FUNCTION fnListe_SipDetayEkFiyatlar

GO

CREATE FUNCTION fnListe_SipDetayEkFiyatlar ( @SipDetayID INT) RETURNS VARCHAR(4000)
AS
BEGIN
DECLARE @MasrafIsmi VARCHAR(100)
DECLARE @EkFiyat FLOAT
DECLARE @Desc VARCHAR(4000)
SET @DESC=''


DECLARE Employee_Cursor CURSOR FOR
SELECT MasrafIsmi,EkFiyat FROM SipDetayEkFiyatlar WHERE Deleted = 0 AND SipDetayID = @SipDetayID
OPEN Employee_Cursor

FETCH NEXT FROM Employee_Cursor
INTO @MasrafIsmi,@EkFiyat
IF @@FETCH_STATUS = 0 BEGIN
	SET @DESC=@DESC + SUBSTRING(@MasrafIsmi,1,30) + SPACE(30-LEN(SUBSTRING(@MasrafIsmi,1,30))) + CHAR(9) + CAST(@EkFiyat as VARCHAR(10)) + CHAR(13) + CHAR(10)
END
WHILE @@FETCH_STATUS = 0
BEGIN
   FETCH NEXT FROM Employee_Cursor
   INTO @MasrafIsmi,@EkFiyat
	IF @@FETCH_STATUS = 0 BEGIN
		SET @DESC=@DESC + SUBSTRING(@MasrafIsmi,1,30) + SPACE(30-LEN(SUBSTRING(@MasrafIsmi,1,30))) + CHAR(9) + CAST(@EkFiyat as VARCHAR(10)) + CHAR(13) + CHAR(10)
	END
END
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor

RETURN @DESC

END

GO



