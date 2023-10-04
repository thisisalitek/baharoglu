

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fnSipDetay_AnaRenk]') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
DROP FUNCTION [dbo].[fnSipDetay_AnaRenk]
GO


CREATE FUNCTION [dbo].[fnSipDetay_AnaRenk](@SipDetayID INT) RETURNS VARCHAR(4000)
AS
BEGIN
DECLARE @ParcaIsmi VARCHAR(50)
DECLARE @RenkKod VARCHAR(50)

DECLARE @Desc VARCHAR(4000)
SET @DESC=''

DECLARE Employee_Cursor CURSOR FOR
SELECT ParcaIsmi,RenkKod FROM (
SELECT 1000000 + SipDetayParam_001_Kumas.nID as nID, SipDetayParam_001_Kumas.ParcaIsmi,Renkler.RenkKod FROM SipDetayParam INNER JOIN
SipDetayParam_001_Kumas ON SipDetayParam.SipDetayParamID = SipDetayParam_001_Kumas.SipDetayParamID INNER JOIN
Renkler ON SipDetayParam_001_Kumas.RenkID =Renkler.RenkID 
WHERE SipDetayParam.Deleted = 0 AND SipDetayParam.ParamType='001' AND SipDetayParam.SipDetayID = @SipDetayID 
AND SipDetayParam_001_Kumas.Deleted = 0 

UNION ALL
SELECT 2000000 + SipDetayParam_009_Kumas2.nID as nID, SipDetayParam_009_Kumas2.ParcaIsmi,Renkler.RenkKod FROM SipDetayParam INNER JOIN
SipDetayParam_009_Kumas2 ON SipDetayParam.SipDetayParamID = SipDetayParam_009_Kumas2.SipDetayParamID INNER JOIN
Renkler ON SipDetayParam_009_Kumas2.RenkID =Renkler.RenkID 
WHERE SipDetayParam.Deleted = 0 AND SipDetayParam.ParamType='009' AND SipDetayParam.SipDetayID = @SipDetayID 
AND SipDetayParam_009_Kumas2.Deleted = 0 

UNION ALL
SELECT 3000000 + SipDetayParam_011_LakosKumas.nID as nID, SipDetayParam_011_LakosKumas.ParcaIsmi,Renkler.RenkKod FROM SipDetayParam INNER JOIN
SipDetayParam_011_LakosKumas ON SipDetayParam.SipDetayParamID = SipDetayParam_011_LakosKumas.SipDetayParamID INNER JOIN
Renkler ON SipDetayParam_011_LakosKumas.RenkID =Renkler.RenkID 
WHERE SipDetayParam.Deleted = 0 AND SipDetayParam.ParamType='011' AND SipDetayParam.SipDetayID = @SipDetayID 
AND SipDetayParam_011_LakosKumas.Deleted = 0 
) X
ORDER BY nID

OPEN Employee_Cursor

FETCH NEXT FROM Employee_Cursor
INTO @ParcaIsmi,@RenkKod
IF @@FETCH_STATUS = 0 BEGIN
	SET @DESC=@DESC + @RenkKod
END
WHILE @@FETCH_STATUS = 0
BEGIN
   FETCH NEXT FROM Employee_Cursor
   INTO @ParcaIsmi,@RenkKod
	IF @@FETCH_STATUS = 0 BEGIN
		SET @DESC=@DESC + ' / ' + @ParcaIsmi + ':' + @RenkKod
	END
END
CLOSE Employee_Cursor
DEALLOCATE Employee_Cursor

RETURN @DESC
END

GO


IF NOT EXISTS(SELECT * FROM syscolumns INNER JOIN sysobjects ON syscolumns.id = sysobjects.id WHERE (sysobjects.name = N'SipDetay') AND (sysobjects.xtype = 'U') AND (syscolumns.name = N'Durumu'))
ALTER TABLE SipDetay ADD Durumu VARCHAR(50)  NULL DEFAULT ''
GO

UPDATE SipDetay SET Durumu='' WHERE Durumu IS NULL

GO

