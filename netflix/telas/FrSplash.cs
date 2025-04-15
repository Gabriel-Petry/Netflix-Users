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
	public partial class FrSplash : Form
	{
		public FrSplash()
		{
			InitializeComponent();
		}

		private void trSplash_Tick(object sender, EventArgs e)
		{
			progressBar1.Increment(1);

			if(progressBar1.Value == 25)
			{
				trSplash.Enabled = false;
				this.Close();
			}
		}

		private void FrSplash_Load(object sender, EventArgs e)
		{

		}
	}
}
