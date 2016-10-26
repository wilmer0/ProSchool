using System;
using System.Collections.Generic;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using ProSchoolModelo;
using ProSchoolModelo.Modelos;


namespace ProSchoolModelo
{

    public class coneccion
    {



        private static coneccion instance;



        public static coneccion Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new coneccion();
                }
                return instance;
            }
        }

        public static DatosConeccionBD datosConeccionBd;

        public coneccion(DatosConeccionBD datosConeccion)
        {
            datosConeccionBd = datosConeccion;
        }


        public coneccion()
        {

        }


        public proschoolEntities getConeccion()
        {
            if (datosConeccionBd == null)
            {
                datosConeccionBd = new DatosConeccionBD();

                


                //         public ADMFICEntities(string servidor, String baseDatos, String user, String pass)
                //    : base("name=ADMFICEntities")
                //{


                //    var connectionString = this.Database.Connection.ConnectionString + ";password=" + pass;
                //    connectionString = "server=" + servidor + ";userid=" + user + ";persistsecurityinfo=true;database=" + baseDatos + ";password=" + pass;

                //    this.Database.Connection.ConnectionString = connectionString;
                //}

                //        if (!System.IO.Directory.Exists("Configuracion"))
                //        {

                //            System.IO.Directory.CreateDirectory("Configuracion");

                //        }

              


                //        // leer archivo

                   
                    datosConeccionBd.Servidor = "localhost";
                    datosConeccionBd.BaseDatos = "7commercium";
                    datosConeccionBd.Usuario = "migracion";
                    datosConeccionBd.Contrasena = "1234";
                    return new proschoolEntities(datosConeccionBd.Servidor, datosConeccionBd.BaseDatos,
                        datosConeccionBd.Usuario, datosConeccionBd.Contrasena);
               
            }

            else
            {
                return new proschoolEntities(datosConeccionBd.Servidor, datosConeccionBd.BaseDatos,
                    datosConeccionBd.Usuario,
                    datosConeccionBd.Contrasena);
            }

        }
    }
}


