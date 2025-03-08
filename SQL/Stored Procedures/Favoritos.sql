
CREATE PROCEDURE sp_Favoritos
@Op CHAR(1),
@NomFav VARCHAR(50),
@NVersion VARCHAR(30),
@Testamento VARCHAR(20) ,
@Libro VARCHAR(20),
@NumeroCap TINYINT ,
@EsCapitulo INT, --0 No es Cap, 1 Si es cap
@Versiculo TINYINT,
@Texto TEXT,
@Usuario  VARCHAR(100),
@FechaAgregado SMALLDATETIME
AS
	BEGIN
		IF(@Op='A')--AGREGAR FAVORITO
			BEGIN

			INSERT INTO Favorito(NomFavorito,NVersion,Testamento,Libro,NumeroCap,EsCapitulo,Versiculo,Texto,Usuario,FechaAgregado)
			VALUES(@NomFav,@NVersion,@Testamento,@Libro,@NumeroCap,@EsCapitulo,@Versiculo,@Texto,@Usuario,@FechaAgregado)

			END	

		IF(@Op = 'V') -- Consultar versiculos favs
			BEGIN
				SELECT F.IdFavorito ID,
				F.NomFavorito Nombre,
				F.NVersion Vers,
				F.Testamento Testamento,
				F.Libro Libro,
				F.NumeroCap Capitulo,
				F.Versiculo Versiculo,
				F.Texto Texto
				FROM Favorito AS F
			WHERE F.Usuario = @Usuario AND F.EsCapitulo=0
			END

		IF(@Op='C')-- Consultar Capitulos FAV
			BEGIN
			SELECT F.IdFavorito ID,
				F.NomFavorito Nombre,
				F.NVersion Vers,
				F.Testamento Testamento,
				F.Libro Libro,
				F.NumeroCap Capitulo
				FROM Favorito AS F
			WHERE F.Usuario = @Usuario AND F.EsCapitulo=1
			END
		
		IF(@Op='E')
			BEGIN
				DELETE FROM Favorito
				WHERE IdFavorito = @EsCapitulo
			END
			
	END


	--SELECT * FROM Favorito