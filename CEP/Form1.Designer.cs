namespace CEP
{
	partial class Form1
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
			this.txtCEP = new System.Windows.Forms.TextBox();
			this.txtUF = new System.Windows.Forms.TextBox();
			this.txtCidade = new System.Windows.Forms.TextBox();
			this.txtBairro = new System.Windows.Forms.TextBox();
			this.txtRua = new System.Windows.Forms.TextBox();
			this.lblCEP = new System.Windows.Forms.Label();
			this.lblEstado = new System.Windows.Forms.Label();
			this.lblCidade = new System.Windows.Forms.Label();
			this.lblBairro = new System.Windows.Forms.Label();
			this.lblRua = new System.Windows.Forms.Label();
			this.btnLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtCEP
			// 
			this.txtCEP.Location = new System.Drawing.Point(31, 39);
			this.txtCEP.Name = "txtCEP";
			this.txtCEP.Size = new System.Drawing.Size(173, 22);
			this.txtCEP.TabIndex = 0;
			this.txtCEP.Leave += new System.EventHandler(this.txtCEP_Leave);
			// 
			// txtUF
			// 
			this.txtUF.Location = new System.Drawing.Point(31, 103);
			this.txtUF.Name = "txtUF";
			this.txtUF.Size = new System.Drawing.Size(510, 22);
			this.txtUF.TabIndex = 1;
			// 
			// txtCidade
			// 
			this.txtCidade.Location = new System.Drawing.Point(31, 151);
			this.txtCidade.Name = "txtCidade";
			this.txtCidade.Size = new System.Drawing.Size(510, 22);
			this.txtCidade.TabIndex = 2;
			// 
			// txtBairro
			// 
			this.txtBairro.Location = new System.Drawing.Point(31, 202);
			this.txtBairro.Name = "txtBairro";
			this.txtBairro.Size = new System.Drawing.Size(510, 22);
			this.txtBairro.TabIndex = 3;
			// 
			// txtRua
			// 
			this.txtRua.Location = new System.Drawing.Point(31, 247);
			this.txtRua.Name = "txtRua";
			this.txtRua.Size = new System.Drawing.Size(510, 22);
			this.txtRua.TabIndex = 4;
			// 
			// lblCEP
			// 
			this.lblCEP.AutoSize = true;
			this.lblCEP.Location = new System.Drawing.Point(28, 19);
			this.lblCEP.Name = "lblCEP";
			this.lblCEP.Size = new System.Drawing.Size(35, 17);
			this.lblCEP.TabIndex = 5;
			this.lblCEP.Text = "CEP";
			// 
			// lblEstado
			// 
			this.lblEstado.AutoSize = true;
			this.lblEstado.Location = new System.Drawing.Point(28, 83);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(52, 17);
			this.lblEstado.TabIndex = 6;
			this.lblEstado.Text = "Estado";
			// 
			// lblCidade
			// 
			this.lblCidade.AutoSize = true;
			this.lblCidade.Location = new System.Drawing.Point(28, 131);
			this.lblCidade.Name = "lblCidade";
			this.lblCidade.Size = new System.Drawing.Size(52, 17);
			this.lblCidade.TabIndex = 7;
			this.lblCidade.Text = "Cidade";
			// 
			// lblBairro
			// 
			this.lblBairro.AutoSize = true;
			this.lblBairro.Location = new System.Drawing.Point(28, 180);
			this.lblBairro.Name = "lblBairro";
			this.lblBairro.Size = new System.Drawing.Size(46, 17);
			this.lblBairro.TabIndex = 8;
			this.lblBairro.Text = "Bairro";
			// 
			// lblRua
			// 
			this.lblRua.AutoSize = true;
			this.lblRua.Location = new System.Drawing.Point(28, 227);
			this.lblRua.Name = "lblRua";
			this.lblRua.Size = new System.Drawing.Size(34, 17);
			this.lblRua.TabIndex = 9;
			this.lblRua.Text = "Rua";
			// 
			// btnLimpar
			// 
			this.btnLimpar.Location = new System.Drawing.Point(31, 276);
			this.btnLimpar.Name = "btnLimpar";
			this.btnLimpar.Size = new System.Drawing.Size(132, 59);
			this.btnLimpar.TabIndex = 10;
			this.btnLimpar.Text = "Limpar";
			this.btnLimpar.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 347);
			this.Controls.Add(this.btnLimpar);
			this.Controls.Add(this.lblRua);
			this.Controls.Add(this.lblBairro);
			this.Controls.Add(this.lblCidade);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.lblCEP);
			this.Controls.Add(this.txtRua);
			this.Controls.Add(this.txtBairro);
			this.Controls.Add(this.txtCidade);
			this.Controls.Add(this.txtUF);
			this.Controls.Add(this.txtCEP);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCEP;
		private System.Windows.Forms.TextBox txtUF;
		private System.Windows.Forms.TextBox txtCidade;
		private System.Windows.Forms.TextBox txtBairro;
		private System.Windows.Forms.TextBox txtRua;
		private System.Windows.Forms.Label lblCEP;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Label lblCidade;
		private System.Windows.Forms.Label lblBairro;
		private System.Windows.Forms.Label lblRua;
		private System.Windows.Forms.Button btnLimpar;
	}
}

