CREATE TRIGGER desactivarContrase�a --en vez de eliminar contrase�as, baja logica
ON Contrase�a
INSTEAD OF DELETE
AS 
	BEGIN 
		UPDATE Contrase�a
		SET Estado=0
		FROM Contrase�a AS C
			JOIN deleted d 
			ON C.IdContrase�a = D.IdContrase�a
	END



CREATE TRIGGER desactivarUsuario --en vez de eliminar usuarios, baja l�gica
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
--DROP TRIGGER desactivarContrase�a
--DROP TRIGGER fechaBusquedaAgrega


	