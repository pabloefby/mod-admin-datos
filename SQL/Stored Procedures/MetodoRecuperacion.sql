
CREATE PROCEDURE sp_MetodoRecuperacion
@Op CHAR(1),
@Preg VARCHAR(100),
@Resp VARCHAR(30),
@Usuario VARCHAR(100)
AS
	BEGIN

	IF(@Op='A') --se agrega el metodo de recuperacion
		BEGIN
			INSERT INTO MetodoRecuperacion(Pregunta,Respuesta,Usuario)
				VALUES(@Preg,@Resp,@Usuario)
		END
	
	IF(@Op='M')-- traer metodo de recuperacion
			BEGIN
				SELECT * FROM dbo.fnGetPregRespRecu(@Usuario);
			END
	END