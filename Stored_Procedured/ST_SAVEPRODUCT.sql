IF OBJECT_ID(N'ST_SAVEPRODUCT',N'P') IS NOT NULL
     DROP PROCEDURE ST_SAVEPRODUCT;
GO
CREATE PROCEDURE ST_SAVEPRODUCT
       @Name nvarchar(50)  null
      ,@Price decimal(18,6) null
      ,@Iva int
      ,@IvaValue  decimal(18,0) null
 As
 BEGIN TRY
    BEGIN TRAN
	 INSERT INTO Product 
	 (
	          Name
             ,Price
             ,Iva
             ,IvaValue
	 )
	      VALUES(
		      @Name
             ,@Price
             ,@Iva
             ,@IvaValue)
	COMMIT
 END TRY
 BEGIN CATCH
     ROLLBACK  TRAN
 END CATCH