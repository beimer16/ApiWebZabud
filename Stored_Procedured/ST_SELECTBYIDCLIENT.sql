IF OBJECT_ID(N'ST_SELECTBYIDCLIENT',N'P') IS NOT NULL
     DROP PROCEDURE ST_SELETBYIDCLIENT;
GO
CREATE PROCEDURE ST_SELETBYIDCLIENT
     @Id bigint	 
 As
 BEGIN
   SELECT * FROM dbo.Client WHERE Client.Id=@Id;
 END
 