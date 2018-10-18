USE AdventureWorks2014
GO
CREATE PROCEDURE sp_crearReseña(
    @idProducto INT,
	@name NVARCHAR(50),
	@fechaReseña DATETIME,
    @correo NVARCHAR(50),
	@valoracion INT,
    @comentario NVARCHAR(3850),
	@fechaModificacion DATETIME
)
AS
BEGIN
    INSERT INTO Production.ProductReview(ProductID,ReviewerName, ReviewDate,EmailAddress,Rating,Comments, ModifiedDate)
            VALUES(@idProducto,@name,@fechaReseña,@correo,@valoracion,@comentario,@fechaModificacion)
    RETURN 1
END