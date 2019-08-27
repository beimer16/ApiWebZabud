IF OBJECT_ID(N'ST_UPDATEPRODUCT',N'P') IS NOT NULL
     DROP PROCEDURE ST_UPDATEPRODUCT;

GO
CREATE PROCEDURE ST_UPDATEPRODUCT
       @Id bigint 
      ,@Name nvarchar(50)  null
      ,@Price decimal(18,6) null
      ,@Iva int
      ,@IvaValue decimal(18,6) null
  As
 BEGIN TRY
    BEGIN TRAN
	 UPDATE Product
       SET
	   [Name]=@Name 
      ,[Price]=@Price
      ,[Iva]=@Iva
      ,[IvaValue]=@IvaValue
      WHERE Product.Id =@Id

	COMMIT
 END TRY
 BEGIN CATCH
     ROLLBACK  TRAN
 END CATCH