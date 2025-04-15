namespace telas
{
	partial class FrPrincipal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvDados = new System.Windows.Forms.DataGridView();
			this.btCadastro = new System.Windows.Forms.Button();
			this.btLeitura = new System.Windows.Forms.Button();
			this.btAlterar = new System.Windows.Forms.Button();
			this.btExcluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbFone = new System.Windows.Forms.TextBox();
			this.tbCPF = new System.Windows.Forms.TextBox();
			this.tbIdade = new System.Windows.Forms.TextBox();
			this.tbNome = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbId = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDados
			// 
			this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDados.Location = new System.Drawing.Point(37, 240);
			this.dgvDados.Name = "dgvDados";
			this.dgvDados.Size = new System.Drawing.Size(566, 275);
			this.dgvDados.TabIndex = 0;
			this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
			// 
			// btCadastro
			// 
			this.btCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btCadastro.Location = new System.Drawing.Point(609, 240);
			this.btCadastro.Name = "btCadastro";
			this.btCadastro.Size = new System.Drawing.Size(125, 75);
			this.btCadastro.TabIndex = 1;
			this.btCadastro.Text = "&Cadastro";
			this.btCadastro.UseVisualStyleBackColor = true;
			this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
			// 
			// btLeitura
			// 
			this.btLeitura.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btLeitura.Location = new System.Drawing.Point(224, 324);
			this.btLeitura.Name = "btLeitura";
			this.btLeitura.Size = new System.Drawing.Size(125, 75);
			this.btLeitura.TabIndex = 2;
			this.btLeitura.Text = "&Leitura";
			this.btLeitura.UseVisualStyleBackColor = true;
			this.btLeitura.Click += new System.EventHandler(this.btLeitura_Click);
			// 
			// btAlterar
			// 
			this.btAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btAlterar.Location = new System.Drawing.Point(609, 340);
			this.btAlterar.Name = "btAlterar";
			this.btAlterar.Size = new System.Drawing.Size(125, 75);
			this.btAlterar.TabIndex = 3;
			this.btAlterar.Text = "&Alterar";
			this.btAlterar.UseVisualStyleBackColor = true;
			this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
			// 
			// btExcluir
			// 
			this.btExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btExcluir.Location = new System.Drawing.Point(609, 440);
			this.btExcluir.Name = "btExcluir";
			this.btExcluir.Size = new System.Drawing.Size(125, 75);
			this.btExcluir.TabIndex = 4;
			this.btExcluir.Text = "&Excluir";
			this.btExcluir.UseVisualStyleBackColor = true;
			this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(14, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 29);
			this.label1.TabIndex = 5;
			this.label1.Text = "Idade:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(14, 135);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 29);
			this.label2.TabIndex = 6;
			this.label2.Text = "Fone:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(14, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 29);
			this.label3.TabIndex = 7;
			this.label3.Text = "Nome:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(14, 172);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 29);
			this.label5.TabIndex = 9;
			this.label5.Text = "CPF:";
			// 
			// tbFone
			// 
			this.tbFone.Location = new System.Drawing.Point(105, 143);
			this.tbFone.Name = "tbFone";
			this.tbFone.Size = new System.Drawing.Size(210, 20);
			this.tbFone.TabIndex = 10;
			// 
			// tbCPF
			// 
			this.tbCPF.Location = new System.Drawing.Point(95, 179);
			this.tbCPF.Name = "tbCPF";
			this.tbCPF.Size = new System.Drawing.Size(220, 20);
			this.tbCPF.TabIndex = 11;
			// 
			// tbIdade
			// 
			this.tbIdade.Location = new System.Drawing.Point(109, 107);
			this.tbIdade.Name = "tbIdade";
			this.tbIdade.Size = new System.Drawing.Size(206, 20);
			this.tbIdade.TabIndex = 12;
			// 
			// tbNome
			// 
			this.tbNome.Location = new System.Drawing.Point(119, 66);
			this.tbNome.Name = "tbNome";
			this.tbNome.Size = new System.Drawing.Size(196, 20);
			this.tbNome.TabIndex = 14;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(14, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 29);
			this.label4.TabIndex = 8;
			this.label4.Text = "IdUsuario:";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(151, 27);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(164, 20);
			this.tbId.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(838, 507);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 50);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::telas.Properties.Resources.ui;
			this.pictureBox2.Location = new System.Drawing.Point(391, 27);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(317, 186);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 16;
			this.pictureBox2.TabStop = false;
			// 
			// FrPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.BackgroundImage = global::telas.Properties.Resources.preto;
			this.ClientSize = new System.Drawing.Size(753, 558);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.tbNome);
			this.Controls.Add(this.tbId);
			this.Controls.Add(this.tbIdade);
			this.Controls.Add(this.tbCPF);
			this.Controls.Add(this.tbFone);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btExcluir);
			this.Controls.Add(this.btAlterar);
			this.Controls.Add(this.btCadastro);
			this.Controls.Add(this.dgvDados);
			this.Controls.Add(this.btLeitura);
			this.Name = "FrPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.FrPrincipal_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDados;
		private System.Windows.Forms.Button btCadastro;
		private System.Windows.Forms.Button btLeitura;
		private System.Windows.Forms.Button btAlterar;
		private System.Windows.Forms.Button btExcluir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbFone;
		private System.Windows.Forms.TextBox tbCPF;
		private System.Windows.Forms.TextBox tbIdade;
		private System.Windows.Forms.TextBox tbNome;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}