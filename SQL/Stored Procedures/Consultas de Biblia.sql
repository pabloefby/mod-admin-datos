CREATE PROCEDURE SP_ConsultaBiblia
	(@Op CHAR(1),
	@Idioma VARCHAR(20),
	@Version VARCHAR(30),
	@Testamento VARCHAR(20),
	@Libro VARCHAR(20),
	@Cap TINYINT,
	@NumVer TINYINT)
AS
BEGIN 

	IF(@Op = 'I')
		BEGIN
			SELECT Idiomas.Nombre
			FROM DB_Bible.dbo.Idiomas
		END

	IF(@Op = 'V') --Consulta Versiones a partir de Idiomas
		BEGIN
			SELECT V.NombreVersion
			FROM DB_Bible.dbo.Versiones AS V
				JOIN DB_Bible.dbo.Idiomas AS I
				ON V.Id_Idioma = I.Id_Idioma
			WHERE I.Nombre = @Idioma
		END


	IF(@Op = 'T') -- Consulta Testamentos a partir de Idiomas
		BEGIN
			SELECT T.Nombre
			FROM DB_Bible.dbo.Testamentos AS T
				JOIN DB_Bible.dbo.Idiomas AS I
				ON T.Id_Idioma = I.Id_Idioma
			WHERE I.Nombre = @Idioma
		END

	IF(@Op = 'L') --Consulta de Libros a partir de Testamento
		BEGIN
			SELECT L.Nombre
			FROM DB_Bible.dbo.Libros AS L
				JOIN DB_Bible.dbo.Testamentos AS T
				ON L.Id_Testamento = T.Id_Testamento
			WHERE T.Nombre = @Testamento
		END

	IF(@Op = 'N') --Consulta de NumCaps por Libro
		BEGIN
			SELECT DISTINCT L.CapitulosTot
			FROM DB_Bible.dbo.Libros AS L
			WHERE L.Nombre=@Libro
		END

	IF(@Op = 'A') --Consulta de versiculos a partir de Libro y NumCap
		BEGIN
			SELECT V.NumeroVers,V.Texto
			FROM DB_Bible.dbo.Versiculos AS V
				JOIN DB_Bible.dbo.Libros AS L
					ON V.Id_Libro = L.Id_Libro
			WHERE L.Nombre = @Libro AND V.NumeroCap=@Cap
		END

	IF(@Op = 'B') --Consulta de TODOS versiculos a partir de IdVers, Libro, NumCap 
		BEGIN
			SELECT Cita,Texto
			FROM vw_CitaVerLibNum
			WHERE NomVersion = @Version 
				AND Libro = @Libro 
				AND NumCap = @Cap
		END

END;


--EXEC SP_ConsultaBiblia 'B','', "NUEVA VERSION INTERNACIONAL" ,'','Génesis',1,;

--SELECT * FROM DB_Bible.dbo.Versiculos
--SELECT * FROM Versiones