using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telas
{
	public partial class frLogin : Form
	{
		public frLogin()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btLogin_Click(object sender, EventArgs e)
		{
			string nome = tbLogin.Text;
			string senha = tbSenha.Text;

			if(senha == "Petry" & nome == "Petry")
			{
				FrPrincipal frPrint = new FrPrincipal();
				frPrint.ShowDialog();
			}

			else
			{
				MessageBox.Show("Senha inserida incorretamente!");
			}


		}

		private void frLogin_Load(object sender, EventArgs e)
		{
			FrSplash splash = new FrSplash();
			splash.ShowDialog();
		}

		
	}
}
