using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutricionalApp
{
    public partial class LoginAdmSist : Form
    {
        public static bool AdmSistOK;
        public LoginAdmSist()
        {
            InitializeComponent();
        }

        private void btVisualizar_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar != '\0')
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            using (var db = new DatabaseConnection())
            {
                db.OpenConnection();

                string email = txtEmail.Text;
                string pass = txtSenha.Text;

                string result = db.CheckUserAdm(email, pass);

                if (result == "true")
                {
                    MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdmSistOK = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AdmSistOK = false;
                }
            }

        }

        private void LoginAdmSist_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }


    }
