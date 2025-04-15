namespace telas
{
	partial class frLogin
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btLogin = new System.Windows.Forms.Button();
			this.tbSenha = new System.Windows.Forms.TextBox();
			this.tbLogin = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pcbLogin = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).BeginInit();
			this.SuspendLayout();
			// 
			// btLogin
			// 
			this.btLogin.Location = new System.Drawing.Point(124, 265);
			this.btLogin.Name = "btLogin";
			this.btLogin.Size = new System.Drawing.Size(75, 23);
			this.btLogin.TabIndex = 1;
			this.btLogin.Text = "&Logar";
			this.btLogin.UseVisualStyleBackColor = true;
			this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
			// 
			// tbSenha
			// 
			this.tbSenha.Location = new System.Drawing.Point(124, 196);
			this.tbSenha.Name = "tbSenha";
			this.tbSenha.PasswordChar = '*';
			this.tbSenha.Size = new System.Drawing.Size(100, 20);
			this.tbSenha.TabIndex = 2;
			// 
			// tbLogin
			// 
			this.tbLogin.Location = new System.Drawing.Point(124, 170);
			this.tbLogin.Name = "tbLogin";
			this.tbLogin.Size = new System.Drawing.Size(100, 20);
			this.tbLogin.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 199);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Senha:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(36, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Login:";
			// 
			// pcbLogin
			// 
			this.pcbLogin.Image = global::telas.Properties.Resources.net;
			this.pcbLogin.Location = new System.Drawing.Point(-163, 0);
			this.pcbLogin.Name = "pcbLogin";
			this.pcbLogin.Size = new System.Drawing.Size(667, 433);
			this.pcbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pcbLogin.TabIndex = 0;
			this.pcbLogin.TabStop = false;
			this.pcbLogin.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// frLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(319, 431);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbLogin);
			this.Controls.Add(this.tbSenha);
			this.Controls.Add(this.btLogin);
			this.Controls.Add(this.pcbLogin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "frLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Netflix";
			this.Load += new System.EventHandler(this.frLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.pcbLogin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pcbLogin;
		private System.Windows.Forms.Button btLogin;
		private System.Windows.Forms.TextBox tbSenha;
		private System.Windows.Forms.TextBox tbLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

