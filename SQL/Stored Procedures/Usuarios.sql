CREATE PROCEDURE sp_Usuarios 
@Op CHAR(1),
@Email VARCHAR(100),
@NomCompleto VARCHAR(100),
@FechaNacimiento DATE,
@Genero CHAR(1),
@Fuente INT,
@ApPaterno VARCHAR(50),
@ApMaterno VARCHAR(50)
AS 
BEGIN
	IF(@Op='R') --USUARIOS RECORDADOS
		BEGIN
			SELECT * FROM vw_UsuariosRecordados
		END
	
	IF(@Op ='A') --guardar usuarios
		BEGIN
			
			IF([dbo].[fnValidarCorreo](@Email) = 0 )
				BEGIN 
					RAISERROR('Correo electrónico no válido. Intentelo nuevamente.', 16, 1)	
				END
			ELSE
				BEGIN
					IF([dbo].[ObtenerEdad](@FechaNacimiento)<=12) 
						BEGIN
							RAISERROR('Usted debe ser mayor a 12 años', 16, 1)	
						END
					ELSE
						BEGIN 
							INSERT INTO Usuario(Email,NomCompleto,ApPaterno,ApMaterno,FechaNacimiento,Genero,FechaAlta)
							VALUES (@Email,@NomCompleto,@ApPaterno,@ApMaterno,@FechaNacimiento,@Genero,GETDATE())
						END
				END
		END


	IF(@Op='C') --consulta de usuarios activos
		BEGIN
			SELECT * FROM vw_UsuariosActivos
		END

	IF(@Op='D') --consulta de usuarios inactivos
		BEGIN
			SELECT * FROM vw_UsuariosInactivos
		END


	IF(@Op='U')--Obtener datos de usuario loggeado
		BEGIN
			SELECT
			U.NomCompleto Nombre,
			U.ApPaterno ApPaterno,
			U.ApMaterno ApMaterno,
			U.FechaNacimiento FechaNac,
			U.Genero Genero,
			U.Fuente Fuente
			FROM Usuario AS U
		WHERE Email = @Email
		END

	IF(@Op ='M') --Modificar usuario
		BEGIN
		IF([dbo].[ObtenerEdad](@FechaNacimiento)<=12)
			BEGIN
				RAISERROR('Usted debe ser mayor a 12 años', 16, 1)
			END
		ELSE
			BEGIN
				UPDATE Usuario
				SET NomCompleto=@NomCompleto,
				FechaNacimiento=@FechaNacimiento,
				Genero=@Genero,
				Fuente=@Fuente,
				ApPaterno=@ApPaterno,
				ApMaterno=@ApMaterno
			WHERE Email=@Email
			END
						
	END
	
END
