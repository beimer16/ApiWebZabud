IF OBJECT_ID(N'ST_SELECTCLIENT',N'P') IS NOT NULL
     DROP PROCEDURE ST_SELETCLIENT;

GO
CREATE PROCEDURE ST_SELETCLIENT

 As
 BEGIN
   SELECT * FROM dbo.Client;
 END
 