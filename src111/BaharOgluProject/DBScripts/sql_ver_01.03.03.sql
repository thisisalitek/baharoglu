

IF EXISTS (SELECT * FROM sysobjects WHERE xtype='U' and name='DovizKurlari')
    DROP TABLE DovizKurlari

GO

CREATE TABLE DovizKurlari(
	ID INT IDENTITY(1,1) PRIMARY KEY  , 
	CreatedBy INT NULL DEFAULT 0,
    CreatedDate DATETIME NULL DEFAULT 0  , 
	ModifiedBy INT NULL DEFAULT 0,
    ModifiedDate DATETIME NULL DEFAULT 0  ,
	CurrDate DATETIME NULL DEFAULT 0  ,
	Curr NVARCHAR(5) DEFAULT '' , 
	Rate1 FLOAT NULL DEFAULT 0,
	Rate2 FLOAT NULL DEFAULT 0,
	Rate3 FLOAT NULL DEFAULT 0,
	Rate4 FLOAT NULL DEFAULT 0
)

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'Siparis') AND (sysobjects.xtype = 'U') AND (syscolumns.name like N'DovizGuncelleme'))
ALTER TABLE Siparis ADD DovizGuncelleme DATETIME NULL DEFAULT '1900-01-01'
GO

UPDATE Siparis SET DovizGuncelleme='1900-01-01' WHERE DovizGuncelleme IS NULL

GO


IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[spAcikSiparisDovizleriniGuncelle]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[spAcikSiparisDovizleriniGuncelle]

GO

SET ANSI_NULLS ON

GO

SET QUOTED_IDENTIFIER ON

GO


CREATE PROCEDURE [dbo].[spAcikSiparisDovizleriniGuncelle] 
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @USDKur as FLOAT;
	DECLARE @EURKur as FLOAT;
	DECLARE @GBPKur as FLOAT;
	DECLARE @RUBKur as FLOAT;
	DECLARE @Bugun as DATE;
	DECLARE @Dun as DATE;

	SET @Bugun=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME);
	SET @Dun=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1)-1 as DATETIME);

	SELECT TOP 1 @USDKur=Rate2 FROM DovizKurlari WHERE Curr='USD' AND CurrDate<=@Dun ORDER BY CurrDate DESC;
	SELECT TOP 1 @EURKur=Rate2 FROM DovizKurlari WHERE Curr='EUR' AND CurrDate<=@Dun ORDER BY CurrDate DESC;
	SELECT TOP 1 @GBPKur=Rate2 FROM DovizKurlari WHERE Curr='GBP' AND CurrDate<=@Dun ORDER BY CurrDate DESC;
	SELECT TOP 1 @RUBKur=Rate2 FROM DovizKurlari WHERE Curr='RUB' AND CurrDate<=@Dun ORDER BY CurrDate DESC;


	UPDATE Siparis SET DovizKuru=@USDKur, DovizliTutar = @USDKur*GenelToplam,DovizGuncelleme=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) FROM Siparis INNER JOIN
	SipDetay ON Siparis.SiparisID = SipDetay.SiparisID 
	WHERE Siparis.Deleted=0 AND SipDetay.Deleted=0 
	AND Siparis.Iptal=0 AND SipDetay.Durumu<>'BITTI'  
	AND (SipDetay.TeslimMiktar<=0 OR SipDetay.Miktar>SipDetay.TeslimMiktar)
	AND LTRIM(RTRIM(Siparis.DovizTipi)) = 'USD'
	AND Siparis.DovizGuncelleme<CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME);

	UPDATE Siparis SET DovizKuru=@EURKur, DovizliTutar = @EURKur*GenelToplam,DovizGuncelleme=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) FROM Siparis INNER JOIN
	SipDetay ON Siparis.SiparisID = SipDetay.SiparisID 
	WHERE Siparis.Deleted=0 AND SipDetay.Deleted=0 
	AND Siparis.Iptal=0 AND SipDetay.Durumu<>'BITTI'  
	AND (SipDetay.TeslimMiktar<=0 OR SipDetay.Miktar>SipDetay.TeslimMiktar)
	AND LTRIM(RTRIM(Siparis.DovizTipi)) = 'EUR'
	AND Siparis.DovizGuncelleme<CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME);

	UPDATE Siparis SET DovizKuru=@GBPKur, DovizliTutar = @GBPKur*GenelToplam,DovizGuncelleme=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) FROM Siparis INNER JOIN
	SipDetay ON Siparis.SiparisID = SipDetay.SiparisID 
	WHERE Siparis.Deleted=0 AND SipDetay.Deleted=0 
	AND Siparis.Iptal=0 AND SipDetay.Durumu<>'BITTI'  
	AND (SipDetay.TeslimMiktar<=0 OR SipDetay.Miktar>SipDetay.TeslimMiktar)
	AND LTRIM(RTRIM(Siparis.DovizTipi)) = 'GBP'
	AND Siparis.DovizGuncelleme<CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME);

	UPDATE Siparis SET DovizKuru=@RUBKur, DovizliTutar = @RUBKur*GenelToplam,DovizGuncelleme=CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME) FROM Siparis INNER JOIN
	SipDetay ON Siparis.SiparisID = SipDetay.SiparisID 
	WHERE Siparis.Deleted=0 AND SipDetay.Deleted=0 
	AND Siparis.Iptal=0 AND SipDetay.Durumu<>'BITTI'  
	AND (SipDetay.TeslimMiktar<=0 OR SipDetay.Miktar>SipDetay.TeslimMiktar)
	AND LTRIM(RTRIM(Siparis.DovizTipi)) = 'RUB'
	AND Siparis.DovizGuncelleme<CAST(ROUND(CAST(GETDATE() as FLOAT),0,1) as DATETIME);

END

GO
