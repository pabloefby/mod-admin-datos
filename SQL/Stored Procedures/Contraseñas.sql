
CREATE PROCEDURE sp_Contrase�as
	@Op			CHAR(1),
	@Contra		VARCHAR(25),
	@Usuario	VARCHAR(100)
AS
	BEGIN

	IF(@Op = 'A') --se guarda usuario y se agrega la contrase�a
		BEGIN
			INSERT INTO Contrase�a (Contrase�a,Usuario) 
			VALUES (@Contra,@Usuario)
		END

	IF(@Op = 'E')--se pone baja logica a la contrase�a
		BEGIN
			DELETE FROM Contrase�a
			WHERE Usuario = @Usuario AND (Estado = 1 OR Estado=2)
		END

	IF(@Op = 'T')--se pone la contrase�a como temporal
		BEGIN
			UPDATE Contrase�a
			SET Estado = 2
			WHERE Usuario = @Usuario AND Estado = 1
		END

	IF(@Op = '3')--Obtiene las ultimas 3 contrase�as de un usuario
		BEGIN 
			SELECT TOP 3 Contrase�a FROM Contrase�a
			WHERE Usuario=@Usuario
			ORDER BY IdContrase�a DESC
		END

		
	END