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

                // leer archivo

                datosConeccionBd.Servidor = "localhost";
                datosConeccionBd.BaseDatos = "ProSchool";
                datosConeccionBd.Usuario = "root";
                datosConeccionBd.Contrasena = "wilmerlomas1";
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


