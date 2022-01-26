
----ESTE PROCEDIMIENTO ALMACENADO AGREGA UN CLIENTE EN LA BASE DE DATOS------------------
ALTER PROCEDURE SP_INSERTAR_CLIENTES
(
	@prmIdentidad		VARCHAR(50),
	@prmNombre			NVARCHAR(350),
	@prmDireccion		NVARCHAR(400),
	@prmTelefono		VARCHAR(50),
	@prmCorreo			VARCHAR(50),
	@prmMunicipio		VARCHAR(50),
	@prmFecha_Nacimineto DATE,
	@UsuarioCreacion	VARCHAR(50),
	@RESULT INT = NULL OUTPUT
)
AS
BEGIN

		BEGIN TRY
			BEGIN TRANSACTION
				DECLARE @NewId int=0

				SELECT @NewId = ISNULL(MAX(ID),0)+1 FROM CLIENTES

				INSERT INTO CLIENTES(ID, IDENTIDAD, NOMBRE, DIRECCION, TELEFONO, CORREO, MUNICIPIO, FECHA_NACIMIENTO, FECHA_CREACION, USUARIO_CREACION)
				VALUES(@NewId, @prmIdentidad, @prmNombre, @prmDireccion, @prmTelefono, @prmCorreo, @prmMunicipio, @prmFecha_Nacimineto, GETDATE(), @UsuarioCreacion)
			COMMIT
			Set @RESULT = 1
		END TRY

		BEGIN CATCH
			ROLLBACK
			Set @RESULT = 0
		END CATCH

		RETURN @RESULT
END
GO

----ESTE PROCEDIMIENTO ALMACENADO MODIFICA UN CLIENTE EN LA BASE DE DATOS------------------
CREATE PROCEDURE SP_ACTUALIZAR_CLIENTES
(
	@prmID				INT,
	@prmIdentidad		VARCHAR(50),
	@prmNombre			NVARCHAR(350),
	@prmDireccion		NVARCHAR(400),
	@prmTelefono		VARCHAR(50),
	@prmCorreo			VARCHAR(50),
	@prmMunicipio		VARCHAR(50),
	@prmFecha_Nacimineto DATE,
	@UsuarioCreacion	VARCHAR(50),
	@RESULT INT = NULL OUTPUT
)
AS
BEGIN
		SET @RESULT=0
				UPDATE CLIENTES SET IDENTIDAD=@prmIdentidad, NOMBRE=@prmNombre, DIRECCION=@prmDireccion, TELEFONO=@prmTelefono, CORREO=@prmCorreo, 
									MUNICIPIO=@prmMunicipio, FECHA_NACIMIENTO=@prmFecha_Nacimineto, FECHA_MODIFICACION=GETDATE(),
									USUARIO_MODIFICACION=@UsuarioCreacion
									
				WHERE ID = @prmID
		SET @RESULT=1
		RETURN @RESULT
END

GO

----ESTE PROCEDIMIENTO ALMACENADO DESHABILITA/ANULA UN CLIENTE EN LA BASE DE DATOS------------------
CREATE PROCEDURE SP_ANULAR_CLIENTES
(
	@prmID				INT,
	@RESULT INT = NULL OUTPUT
)
AS
BEGIN
		SET @RESULT=0
				UPDATE CLIENTES SET ID = 0
									
				WHERE ID = @prmID
		SET @RESULT=1
		RETURN @RESULT
END

GO

----ESTE PROCEDIMIENTO ALMACENADO DEVUELVE LISTADO DE CLIENTES EN LA BASE DE DATOS------------------
CREATE PROCEDURE SP_LISTAR_CLIENTES
AS
BEGIN
	SELECT * FROM CLIENTES
END
GO