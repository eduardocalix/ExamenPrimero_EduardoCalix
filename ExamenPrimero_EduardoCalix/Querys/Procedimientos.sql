USE AdventureWorks2014
GO
CREATE PROCEDURE sp_crearRese�a(
    @idProducto INT,
	@name NVARCHAR(50),
	@fechaRese�a DATETIME,
    @correo NVARCHAR(50),
	@valoracion INT,
    @comentario NVARCHAR(3850),
	@fechaModificacion DATETIME
)
AS
BEGIN
    INSERT INTO Production.ProductReview(ProductID,ReviewerName, ReviewDate,EmailAddress,Rating,Comments, ModifiedDate)
            VALUES(@idProducto,@name,@fechaRese�a,@correo,@valoracion,@comentario,@fechaModificacion)
    RETURN 1
END