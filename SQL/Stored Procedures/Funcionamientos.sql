CREATE PROCEDURE sp_Funcionamiento
@Op			CHAR(1),
@Email		VARCHAR(100),
@Fecha		DATETIME,
@Texto		VARCHAR(1000)
AS
	BEGIN

		IF(@Op='I') --INICIO SESION
			BEGIN
				SELECT * FROM vw_UsuarioEstatus
				WHERE Email = @Email AND (EstatusContra=1 OR EstatusContra=2)
			END

		IF(@Op='R') --RECORDAR USUARIO
			BEGIN
				UPDATE Usuario
				SET Recordar=1
				WHERE Usuario.Email = @Email
			END
		
		IF(@Op='O') --OLVIDAR USUARIO
			BEGIN
				UPDATE Usuario
				SET Recordar=0
				WHERE Usuario.Email = @Email
			END

		IF(@Op='D') --Desactivar usuario
			BEGIN
				UPDATE Usuario
				SET FechaBaja=GETDATE()
				WHERE Usuario.Email = @Email

				DELETE FROM Usuario
				WHERE Email = @Email
			END
			
		IF(@Op='F') -- reactivar usuario
			BEGIN
				UPDATE Usuario
				SET Estatus=1,FechaBaja=NULL
				WHERE Usuario.Email = @Email
			END

		IF(@Op='G') -- trae los nombre del filtro
			BEGIN 
				SELECT F.NombreFiltro AS Nombre
				FROM Filtro AS F
			END

		IF(@Op='H') --historial todo el usuario todoas las fechas
			BEGIN
				SELECT * FROM vw_Historial
				WHERE Usuario = @Email
			END

		IF(@Op='Z') -- historial mes y año
			BEGIN
				SELECT 
				H.ID,
				h.Busqueda,
				h.Filtro,
				h.Version,
				h.Libro,
				h.Testamento,
				h.Fecha
				FROM vw_Historial AS H
				WHERE Usuario = @Email AND MONTH(Fecha)=MONTH(@Fecha) AND YEAR(Fecha) = YEAR(@Fecha)
			END
		
		IF(@Op = 'P') --obtener los datos del favorito a partir del texto del versiculo
			BEGIN
				SELECT
					VV.NombreVersion VersionN,
					T.Nombre Testamento,
					L.Nombre Libro,
					V.NumeroCap Capitulo,
					V.NumeroVers NumVer,
					V.Texto Texto
				FROM DB_Bible.dbo.Versiculos AS V
				JOIN DB_Bible.dbo.Libros AS L
					ON V.Id_Libro = L.Id_Libro
				JOIN DB_Bible.dbo.Versiones AS VV
					ON V.Id_Version = VV.Id_Version
				JOIN DB_Bible.dbo.Testamentos AS T
					ON T.Id_Testamento = L.Id_Testamento
				WHERE CAST(V.Texto AS VARCHAR(MAX)) = @Texto

			END

		
	END