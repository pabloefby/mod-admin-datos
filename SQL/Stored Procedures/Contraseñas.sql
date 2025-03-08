
CREATE PROCEDURE sp_Contraseñas
	@Op			CHAR(1),
	@Contra		VARCHAR(25),
	@Usuario	VARCHAR(100)
AS
	BEGIN

	IF(@Op = 'A') --se guarda usuario y se agrega la contraseña
		BEGIN
			INSERT INTO Contraseña (Contraseña,Usuario) 
			VALUES (@Contra,@Usuario)
		END

	IF(@Op = 'E')--se pone baja logica a la contraseña
		BEGIN
			DELETE FROM Contraseña
			WHERE Usuario = @Usuario AND (Estado = 1 OR Estado=2)
		END

	IF(@Op = 'T')--se pone la contraseña como temporal
		BEGIN
			UPDATE Contraseña
			SET Estado = 2
			WHERE Usuario = @Usuario AND Estado = 1
		END

	IF(@Op = '3')--Obtiene las ultimas 3 contraseñas de un usuario
		BEGIN 
			SELECT TOP 3 Contraseña FROM Contraseña
			WHERE Usuario=@Usuario
			ORDER BY IdContraseña DESC
		END

		
	END