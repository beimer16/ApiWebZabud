IF OBJECT_ID(N'ST_UPDATECLIENT',N'P') IS NOT NULL
     DROP PROCEDURE ST_UPDATECLIENT;

GO
CREATE PROCEDURE ST_UPDATECLIENT
       @Id bigint 
      ,@Name nvarchar(70)  null
      ,@LastName nvarchar(90) null
      ,@Address nvarchar(150) null
      ,@Telephone nvarchar(11) null
      ,@Cellphone  nvarchar(11) null
      ,@Identification nvarchar(15) null
      ,@Nit nvarchar(18)
 As
 BEGIN TRY
    BEGIN TRAN
	 UPDATE Client
       SET
	   [Name]= @Name
      ,[LastName] = @LastName
      ,[Address] = @Address
      ,[Telephone] = @Telephone
      ,[Cellphone] = @Cellphone
      ,[Identification] = @Identification
      ,[Nit] = @Nit
      WHERE Client.Id =@Id

	COMMIT
 END TRY
 BEGIN CATCH
     ROLLBACK  TRAN
 END CATCH