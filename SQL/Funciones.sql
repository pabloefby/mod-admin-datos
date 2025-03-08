CREATE FUNCTION fnValidarCorreo
(
	@Email VARCHAR(MAX)
)
RETURNS BIT
AS 
BEGIN
	DECLARE @Correcto bit =	0

		IF(@Email like '%[a-z,0-9]@[a-z]%.[A-Za-z]%[A-Za-z]'
			AND @Email not like '%@%@%'
			AND @Email not like '%(%'
			AND @Email not like '%)%'
			AND @Email not like '%[%'
			AND @Email not like '%]%'
			AND @Email not like '%;%'
			AND @Email not like '%,%'
			AND @Email not like '%\%'
			AND @Email not like '%/%'
			AND @Email not like '%#%'
			AND @Email not like '%"%'
		)
			BEGIN
				SET @Correcto=1
			END

		RETURN @Correcto

END;

--SELECT [dbo].[fnValidarCorreo]('hola@sa.com')

CREATE FUNCTION dbo.fnGetPregRespRecu(@Email VARCHAR(100)) --Obtiene las preguntas y respuestas dependiendo del usuario
RETURNS TABLE
AS
RETURN
(
    SELECT Pregunta,Respuesta
    FROM MetodoRecuperacion
    WHERE Usuario = @Email
)


CREATE FUNCTION dbo.ObtenerEdad(@FechaNacimiento DATE)
RETURNS INT
AS
BEGIN
    DECLARE @Edad INT
    SET @Edad = DATEDIFF(YEAR, @FechaNacimiento, GETDATE()) -
                CASE WHEN DATEADD(YEAR, DATEDIFF(YEAR, @FechaNacimiento, GETDATE()), @FechaNacimiento) > GETDATE() THEN 1 ELSE 0 END
    RETURN @Edad
END