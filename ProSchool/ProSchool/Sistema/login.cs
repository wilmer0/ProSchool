using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProSchool
{
    public partial class login : FormBase
    {



        //objetos
        Sistema.menu_principal ventanaMenuPrincipal = new Sistema.menu_principal();





        public login()
        {
            InitializeComponent();
            loadVentana();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        public override void loadVentana()
        {
           
            this.tituloLabel.Text = "Inicio de Sesión";
            usuarioText.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        public override void Procesar()
        {
           //usar modelo para conectar y buscar si existe usuario
        }


        public override void Salir()
        {
            Application.Exit();
        }

        public override void limpiar()
        {

        }


        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                //salir
                Salir();
            }
            if (e.KeyData == Keys.F6)
            {
                //limpiar
                limpiar();
            }
            if (e.KeyData == Keys.F8)
            {
                //procesar
                Procesar();
            }
        }
        
    }
}
