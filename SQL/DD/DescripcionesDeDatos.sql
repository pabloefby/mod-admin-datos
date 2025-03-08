
--SELECT*FROM Busqueda

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'PK de la tabla'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = IdBusqueda;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Palabras que se realizaron en la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = PalabrasBuscadas;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'FK al ID del filtro empleado en la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = Filtro;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Idioma en el cual se hizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = Idioma;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Nombre de la version de la biblia en la cual se hizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = NVersion;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Nombre del testamento en el cual se hizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = Testamento;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Nombre del libro en el cual se realizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = Libro;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'FK al Email del usuario que realizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = Usuario;
GO

EXEC sp_addextendedproperty 
	@name = N'Descripcion' ,@value = N'Fecha y hora en la cual se realizo la busqueda'
    ,@level0type = N'Schema', @level0name = dbo
    ,@level1type = N'Table',  @level1name = Busqueda
    ,@level2type = N'Column', @level2name = FechaBusqueda;
GO









