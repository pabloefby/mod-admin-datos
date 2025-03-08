
--ARCHIVO PARA LA CREACION DE UN USUARIO PARA EL INICIO DE LA EJECUCCION DEL PROGRAMA
--Se creara la cuenta con los siguientes datos importantes:
--Email: admin@gmail.oom
--Nombre: Administrador Primera Cuenta
--Tamaño de la fuente: 11
--Contraseña:Contra####
--Pregunta de recuperacion: Capital de Francia
--Respuesta de recuperacion: Paris

--(estos campos pueden ser editados una vez que haya accedido a la aplicacion, excepto el email.

INSERT INTO Usuario (Email,NomCompleto,FechaNacimiento,Fuente, FechaAlta,ApPaterno,ApMaterno)
VALUES ('admin@gmail.com',
		'Administrador',
		'2002-12-23',
		11,
		GETDATE(),
		'Primera',
		'Cuenta'
		)

INSERT INTO Contraseña(Contraseña,Usuario)
VALUES ('Contra####',
		'admin@gmail.com')

INSERT INTO MetodoRecuperacion(Pregunta,Respuesta,Usuario)
VALUES ('Capital de Francia',
		'Paris',
		'admin@gmail.com')
		

