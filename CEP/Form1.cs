using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEP.Correios;


namespace CEP
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void txtCEP_Leave(object sender, EventArgs e)
		{
			LocalizaCEP();
		}


		private void LocalizaCEP()
		{
			using (var ws = new Correios.AtendeClienteClient())
			{
				var resultado = ws.consultaCEP(txtCEP.Text);
				txtUF.Text = resultado.uf;
				txtCidade.Text = resultado.cidade;
				txtBairro.Text = resultado.bairro;
				txtRua.Text = resultado.end;
			}
		}
	}
}
