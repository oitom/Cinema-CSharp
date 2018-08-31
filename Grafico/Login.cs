using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Grafico
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            bool erroValidacao = false;
            errorLogin.Clear();

            if (textBoxUsuario.Text.Length == 0)
            {
                errorLogin.SetIconPadding(textBoxUsuario, 5);
                errorLogin.SetError(textBoxUsuario, "Preencha o campo corretamente!");
                erroValidacao = true;
            }
            if (textBoxSenha.Text.Length == 0)
            {
                errorLogin.SetIconPadding(textBoxSenha, 5);
                errorLogin.SetError(textBoxSenha, "Senha incorreta!");
                erroValidacao = true;
            }

            if (!erroValidacao)
            {
                Main formularioPrincipal = new Main();
                formularioPrincipal.ShowDialog();
            }

        }

    }
}
