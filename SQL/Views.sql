--VIEWS

--CONSULTAR INFORMACION VITAL DE USUARIOS PARA INICIO DE SESION
CREATE VIEW vw_UsuarioEstatus
AS
	SELECT 
	U.Email AS Email,
	U.NomCompleto As NombreCompleto,
	U.ApPaterno AS ApPaterno,
	U.ApMaterno AS ApMaterno,
	U.Estatus AS EstadoUser,
	C.Contraseña AS Contraseña,
	C.Estado AS EstatusContra,
	U.Fuente AS Fuente
		FROM Usuario AS U
		JOIN Contraseña AS C
			ON U.Email = C.Usuario



--CONSULTAR USUARIOS RECORDADOS
CREATE VIEW vw_UsuariosRecordados
AS 
	SELECT U.Email
		FROM Usuario AS U
	WHERE U.Recordar = 1



--CONSULTAR CITAS POR VERSION, LIBRO Y NUMERO CAP
CREATE VIEW vw_CitaVerLibNum
AS
SELECT VV.NombreVersion NomVersion,
		T.Nombre Testamento,
		L.Nombre Libro,
		V.NumeroCap NumCap,
		CONCAT(L.Nombre,'',
			V.NumeroCap,':',
			V.NumeroVers) Cita,
			V.Texto
			FROM DB_Bible.dbo.Versiculos AS V
				JOIN DB_Bible.dbo.Libros AS L
					ON V.Id_Libro = L.Id_Libro
				JOIN DB_Bible.dbo.Versiones AS VV
					ON V.Id_Version = VV.Id_Version
				JOIN DB_Bible.dbo.Testamentos AS T
					ON T.Id_Testamento = L.Id_Testamento

--CONSULTAR EL HISTORIAL
CREATE VIEW vw_Historial
AS
	SELECT
	B.IdBusqueda ID,
	B.PalabrasBuscadas Busqueda,
	F.NombreFiltro Filtro,
	B.Idioma Idioma,
	B.NVersion Version,
	B.Libro Libro,
	B.Testamento Testamento,
	B.Usuario Usuario,
	CAST (B.FechaBusqueda AS smalldatetime) Fecha
		FROM Busqueda AS B
			JOIN Filtro AS F
			ON B.Filtro = F.IdFiltro
	
--CONSULTAR USUARIOS ACTIVOS
CREATE VIEW vw_UsuariosActivos
AS
		SELECT 
			CONCAT(U.NomCompleto,' ',ApPaterno,' ',ApMaterno) Nombre,
			U.Email,
			U.Genero,
			U.FechaNacimiento FechaNacimiento,
			U.Fuente TamañoLetra,
			CAST(U.FechaAlta AS smalldatetime) FechaAlta
			FROM Usuario AS U	
		WHERE U.Estatus= 1 

----CONSULTAR USUARIOS INACTIVOS
CREATE VIEW vw_UsuariosInactivos
AS
		SELECT 
			CONCAT(U.NomCompleto,' ',ApPaterno,' ',ApMaterno) Nombre,
			U.Email,
			U.Genero,
			U.FechaNacimiento FechaNacimiento,
			CAST(U.FechaBaja AS smalldatetime) FechaBaja
			FROM Usuario AS U	
		WHERE U.Estatus= 0 




