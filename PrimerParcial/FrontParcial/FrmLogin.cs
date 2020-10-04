using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontParcial
{
    public partial class FrmLogin : Form
    {
        string auxUsuario;
        int intentos = 0;


        #region Properties
        /// <summary>
        /// Getter del usuario logueado
        /// </summary>
        public string AuxUsuario
        {
            get { return auxUsuario; }
        }
        #endregion



        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
          
                bool validarUsuario = false;


                if (!Validaciones.ValidarString(this.txtUsuario.Text) && !Validaciones.ValidarString(this.txtContraseña.Text))
                {
                    intentos ++;

                    foreach (var item in TiendaApu.ListaUsuarios)
                    {

                        if (item.Key == this.txtUsuario.Text)
                        {
                            if (item.Value == this.txtContraseña.Text)
                            {
                                validarUsuario = true;

                                auxUsuario = item.Key;

                                DialogResult = DialogResult.Yes;
                            }
                        }
                    }

                    if (!validarUsuario)
                    {

                        MessageBox.Show("Verifique Usuario o contraseña","Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    if (intentos == 3)
                    {
                        MessageBox.Show("Ha alcanzado el limite maximo de ingresos erroneos","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                    }

                    this.txtUsuario.Clear();
                    this.txtContraseña.Clear();

                }
            

        }

        private void Login_Load(object sender, EventArgs e)
        {
            TiendaApu.HardcodeoUsuarios();
        }
    }
}
