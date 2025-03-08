CREATE TRIGGER desactivarContraseña --en vez de eliminar contraseñas, baja logica
ON Contraseña
INSTEAD OF DELETE
AS 
	BEGIN 
		UPDATE Contraseña
		SET Estado=0
		FROM Contraseña AS C
			JOIN deleted d 
			ON C.IdContraseña = D.IdContraseña
	END



CREATE TRIGGER desactivarUsuario --en vez de eliminar usuarios, baja lógica
ON Usuario
INSTEAD OF DELETE
AS
	BEGIN
		UPDATE Usuario
		SET Estatus = 0
		FROM Usuario AS U
			JOIN deleted d
			ON U.Email = d.Email
	END

CREATE TRIGGER fechaBusquedaAgrega --A las tuplas insertadas, se les asigna la fecha en la cual fueron hechas
ON Busqueda
AFTER INSERT
AS
BEGIN
    UPDATE Busqueda
    SET FechaBusqueda = GETDATE()
    FROM Busqueda B
    INNER JOIN inserted i ON B.Usuario = i.Usuario
END

--DROP TRIGGER desactivarUsuario
--DROP TRIGGER desactivarContraseña
--DROP TRIGGER fechaBusquedaAgrega


	