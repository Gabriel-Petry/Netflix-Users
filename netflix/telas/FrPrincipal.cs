using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telas
{
	public partial class FrPrincipal : Form
	{
		public FrPrincipal()
		{
			InitializeComponent();
		}

		private void pbPrincipal_Click(object sender, EventArgs e)
		{

		}

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void FrPrincipal_Load(object sender, EventArgs e)
		{
			btLeitura_Click(sender, e);
		}

		private void btLeitura_Click(object sender, EventArgs e)
		{
			OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB; Data Source = .\SQLEXPRESS; Initial Catalog = netflix; User ID = sa; password = sa;");

			try
			{
				conexao.Open();

				OleDbCommand sql = new OleDbCommand("SELECT * FROM tbDados", conexao);

				OleDbDataAdapter daLogin = new OleDbDataAdapter(sql);

				DataTable dtLogin = new DataTable();

				daLogin.Fill(dtLogin);

				dgvDados.DataSource = dtLogin;

				conexao.Close();

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu erro na leitura do registro!" +
					"\n \nChame o suporte técnico");
			}
			finally
			{
				conexao.Close();
				//MessageBox.Show("O Banco de Dados foi encerrado com sucesso!");
			}

		}

		private void btCadastro_Click(object sender, EventArgs e)
		{
			OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB; Data Source = .\SQLEXPRESS; Initial Catalog = netflix; User ID = sa; password = sa;");

			try
			{
				conexao.Open();

				string nome = tbNome.Text;
				int idade = int.Parse(tbIdade.Text);
				int fone = int.Parse(tbFone.Text);
				int cpf = int.Parse(tbCPF.Text);

				OleDbCommand sql = new OleDbCommand("INSERT INTO tbDados values('" + nome + "', '" + idade + "', '" + fone + "', '" + cpf + "')", conexao);

				int i = sql.ExecuteNonQuery();

				if (i > 0)
				{
					btLeitura_Click(sender, e);
					MessageBox.Show("Inserção concluída com sucesso!");

				}

				conexao.Close();

			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao cadastrar o registro no banco de dados." +
					"\n\n Tente novamente com nome de usuário e senha válidos ou chame o suporte técnico!");
			}
			finally
			{
				conexao.Close();
			}

			btLeitura_Click(sender, e);
		}

		private void btAlterar_Click(object sender, EventArgs e)
		{
			OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB; Data Source = .\SQLEXPRESS; Initial Catalog = netflix; User ID = sa; password = sa;");

			try
			{
				conexao.Open();

				int id = int.Parse(tbId.Text);
				string nome = tbNome.Text;
				int idade = int.Parse(tbIdade.Text);
				int fone = int.Parse(tbFone.Text);
				int cpf = int.Parse(tbCPF.Text);

				OleDbCommand sql = new OleDbCommand("UPDATE tbDados SET nome = '" + nome + "', idade = '" + idade + "', fone = '" + fone + "', cpf = '" + cpf + "' WHERE idUsuario = " + id, conexao);

				sql.ExecuteNonQuery();

				MessageBox.Show("\nSe o código do login digitado é existente, a atualização foi concluída com sucesso!");

				conexao.Close();

			}
			catch (Exception)
			{
				btLeitura_Click(sender, e);
				MessageBox.Show("Ocorreu um erro na alteração do registro!" +
					"\n\nTente novamente com um código de login, nome de usuário ou senha válidos ou chame o suporte técnico", "AVISO IMPORTANTE");

			}
			finally
			{
				conexao.Close();
			}

			btLeitura_Click(sender, e);
		}

		private void btExcluir_Click(object sender, EventArgs e)
		{
			OleDbConnection conexao = new OleDbConnection(@"Provider = SQLOLEDB; Data Source = .\SQLEXPRESS; Initial Catalog = netflix; User ID = sa; password = sa;");

			try
			{
				conexao.Open();

				int id = int.Parse(tbId.Text);

				OleDbCommand sql = new OleDbCommand("DELETE FROM tbDados WHERE idUsuario = " + id, conexao);

				sql.ExecuteNonQuery();
				btLeitura_Click(sender, e);
				MessageBox.Show("\nSe o código de Login digitado é existente, a exclusão foi concluída com sucesso!" + "\n\nCaso contrário, o registro não foi excluído!");


			}
			catch (Exception)
			{
				MessageBox.Show("Ocorreu um erro ao excluir o registro do banco de dados." +
					"\n\nO registro não foi excluído!", "AVISO IMPORTANTE");
			}

			btLeitura_Click(sender, e);
		}

		private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
