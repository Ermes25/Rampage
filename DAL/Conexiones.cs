﻿using System.Data.SqlClient;
namespace DAL
{
    public static class Conexion
    {
        private static string NombreAplicacion = "";
        private static string Servidor = @"";
        private static string Usuario = "";
        private static string Password = "";
        private static string BaseDatos = "";

        public static string ConexionString(bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder ConstructorCadenaConexion = new()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = !SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };
            if (SqlAutentication)
            {
                ConstructorCadenaConexion.UserID = Usuario;
                ConstructorCadenaConexion.Password = Password;
            }
            return ConstructorCadenaConexion.ConnectionString;
        }
    }
}

