IF OBJECT_ID(N'ST_SAVECLIENT',N'P') IS NOT NULL
     DROP PROCEDURE ST_SAVECLIENT;
GO
CREATE PROCEDURE ST_SAVECLIENT
      @Name nvarchar(70)  null
      ,@LastName nvarchar(90) null
      ,@Address nvarchar(150) null
      ,@Telephone nvarchar(11) null
      ,@Cellphone  nvarchar(11) null
      ,@Identification nvarchar(15) null
      ,@Nit nvarchar(18)
 As
 BEGIN TRY
    BEGIN TRAN
	 INSERT INTO Client 
	       (
		     [Name]
			,[LastName]
			,[Address]
			,[Telephone]
			,[Cellphone]
			,[Identification]
			,[Nit]
		   )
	      VALUES(
		    @Name
			,@LastName
			,@Address
			,@Telephone
			,@Cellphone
			,@Identification
			,@Nit)
	COMMIT
 END TRY
 BEGIN CATCH
     ROLLBACK  TRAN
 END CATCH