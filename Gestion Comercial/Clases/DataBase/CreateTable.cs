namespace Gestion_Comercial.Clases.DataBase
{
    public class CreateTable
    {
        static CreateTable(){
            var context = new System.Data.Linq.DataContext(Conexion.Connection);

            // Crear Tabla Por la Aplicacion.

            // CREATE TABLE[TAcciones]
            context.ExecuteCommand("CREATE TABLE[TAcciones] ([idAcciones] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[fkCliente] INTEGER NOT NULL,[fkTipoAccion] INTEGER NOT NULL,[FechaAccion] DATE DEFAULT CURRENT_DATE NULL,[FechaRecordar] DATE DEFAULT CURRENT_DATE NULL,[Comentario] TEXT NULL);");
            // CREATE TABLE[TCliente]
            context.ExecuteCommand("CREATE TABLE [TCliente] ([idCliente] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[Nombre] varCHAR(30)  NOT NULL,[Apellido] VARCHAR(30)  NOT NULL,[Cedula] VARCHAR(30)  UNIQUE NULL,[fkDireccion] INTEGER  NULL,[Telefono] varchar(30)  NULL,[Email] varCHAR(30)  NULL,[Estatu] INTEGER  NULL);");
            // CREATE TABLE[TDireccion]
            context.ExecuteCommand("CREATE TABLE[TDireccion] ([idDireccion] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[pais] varCHAR(30)  NOT NULL,[Ciudad] VARCHAR(30)  NOT NULL,[Municipio] vaRCHAR(30)  NULL,[Barrio] vaRCHAR(30)  NULL,[Calle] varCHAR(15)  NULL,[numCasa] INTEGER(4)  NULL,[Detalles] varchar(9)  NULL); ");
            // CREATE TABLE[TTipoAccion]
            context.ExecuteCommand("CREATE TABLE[TTipoAccion] ([idTipoAccion] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[Descripcion] VARCHAR(60)  NOT NULL); ");
            // CREATE TABLE[TUsuario]
            context.ExecuteCommand("CREATE TABLE[TUsuario] ([idUsuario] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,[Usuario] VARCHAR(30)  UNIQUE NOT NULL,[Clave] VARCHAR(30)  NOT NULL,[fkUsuario] INTEGER Null); ");
        }

    }
}
/*CREATE TABLE[TAcciones] (
[idAcciones] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[fkCliente] INTEGER NOT NULL,
[fkTipoAccion] INTEGER NOT NULL,
[FechaAccion] DATE DEFAULT CURRENT_DATE NULL,
[FechaRecordar] DATE DEFAULT CURRENT_DATE NULL,
[Comentario] TEXT NULL
);*/
/*CREATE TABLE [TCliente] (
[idCliente] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[Nombre] varCHAR(30)  NOT NULL,
[Apellido] VARCHAR(30)  NOT NULL,
[Cedula] VARCHAR(30)  UNIQUE NULL,
[fkDireccion] INTEGER  NULL,
[Telefono] varchar(30)  NULL,
[Email] varCHAR(30)  NULL,
[Estatu] INTEGER  NULL
);*/
/*CREATE TABLE[TDireccion] (
[idDireccion] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[pais] varCHAR(30)  NOT NULL,
[Ciudad] VARCHAR(30)  NOT NULL,
[Municipio] vaRCHAR(30)  NULL,
[Barrio] vaRCHAR(30)  NULL,
[Calle] varCHAR(15)  NULL,
[numCasa] INTEGER(4)  NULL,
[Detalles] varchar(9)  NULL
);*/
/*CREATE TABLE[TTipoAccion] (
[idTipoAccion] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[Descripcion] VARCHAR(60)  NOT NULL
);*/
/*CREATE TABLE[TUsuario] (
[idUsuario] INTEGER  NOT NULL PRIMARY KEY AUTOINCREMENT,
[Usuario] VARCHAR(30)  UNIQUE NOT NULL,
[Clave] VARCHAR(30)  NOT NULL,
[fkUsuario] INTEGER Null
);*/