CREATE PROCEDURE sp_Busquedas
@Op CHAR(1),
@Palabras VARCHAR(MAX),
@Idioma VARCHAR(20),
@Filtro INT,
@NVersion VARCHAR(30),
@Testamento VARCHAR(20),
@Libro VARCHAR(20),
@Usuario  VARCHAR(100)
AS
	BEGIN

		IF(@Op='I')
			BEGIN
				INSERT INTO Busqueda(PalabrasBuscadas,Idioma,Filtro,NVersion,Testamento,Libro,Usuario)
				VALUES(@Palabras,@Idioma,@Filtro,@NVersion,@Testamento,@Libro,@Usuario)

			END

		IF(@Op='B') --Busqueda toda la biblia
			BEGIN
				--DECLARE @sepa CHAR(1);
				--SET @sepa =' '; 

				SELECT LTRIM(RTRIM(VALUE))Palabra
				into #Palabras
				from string_split(@Palabras,' ');

				SELECT Cita, CAST(Texto AS VARCHAR(MAX)) AS Texto,NomVersion --para compatibilidad se tiene de texto en like se tiene que pasar a una tabla nueva con funcion cast
				INTO #TempTextos
				FROM vw_CitaVerLibNum
				WHERE NomVersion = @NVersion;

				DECLARE @NumPalabras INT
				SELECT @NumPalabras = COUNT(*) FROM #Palabras

				SELECT Cita,Texto
				FROM #TempTextos AS T
					JOIN #Palabras AS P
					ON T.Texto LIKE '%'+P.Palabra+'%'
				WHERE T.NomVersion = @NVersion
				GROUP BY T.Cita, T.Texto
				HAVING COUNT(DISTINCT P.Palabra) = @NumPalabras;
			
				DROP TABLE #Palabras;
				DROP TABLE #TempTextos;
					
			END

		IF(@Op='C')--Busqueda por testamento
			BEGIN

				SELECT LTRIM(RTRIM(VALUE))Palabra
				into #Palabras2
				from string_split(@Palabras,' ');

				SELECT Cita, CAST(Texto AS VARCHAR(MAX)) AS Texto,
				NomVersion,
				Testamento
				INTO #TempTextos2
				FROM vw_CitaVerLibNum
				WHERE NomVersion = @NVersion AND Testamento = @Testamento;

				DECLARE @NPalabras INT
				SELECT @NPalabras = COUNT(*) FROM #Palabras2

				SELECT Cita,Texto
				FROM #TempTextos2 AS T
					JOIN #Palabras2 AS P
					ON T.Texto LIKE '%'+P.Palabra+'%'
				WHERE T.NomVersion = @NVersion AND Testamento = @Testamento
				GROUP BY T.Cita, T.Texto
				HAVING COUNT(DISTINCT P.Palabra) = @NPalabras;
			
				DROP TABLE #Palabras2;
				DROP TABLE #TempTextos2;
				
			END

			IF(@Op='D')--Busqueda por libro
			BEGIN

				SELECT LTRIM(RTRIM(VALUE))Palabra
				into #Palabras3
				from string_split(@Palabras,' ');

				SELECT Cita, CAST(Texto AS VARCHAR(MAX)) AS Texto,
				NomVersion,
				Testamento,
				Libro
				INTO #TempTextos3
				FROM vw_CitaVerLibNum
				WHERE NomVersion = @NVersion AND Testamento = @Testamento AND Libro = @Libro;

				DECLARE @NumPala INT
				SELECT @NumPala = COUNT(*) FROM #Palabras3

				SELECT Cita,Texto
				FROM #TempTextos3 AS T
					JOIN #Palabras3 AS P
					ON T.Texto LIKE '%'+P.Palabra+'%'
				WHERE T.NomVersion = @NVersion AND Testamento = @Testamento AND Libro = @Libro
				GROUP BY T.Cita, T.Texto
				HAVING COUNT(DISTINCT P.Palabra) = @NumPala;
			
				DROP TABLE #Palabras3;
				DROP TABLE #TempTextos3;
				
			END

			IF(@Op = 'T') --borrar todo el historial de busquedas
				BEGIN
					DELETE FROM Busqueda
					WHERE Usuario = @Usuario
				END

			IF(@Op = 'S') --borrar una busqueda
				BEGIN
					DELETE FROM Busqueda
					WHERE Usuario = @Usuario AND IdBusqueda = @Filtro --se usa filtro para mandar el valor int
				END
	END


--SELECT*FROM Busqueda