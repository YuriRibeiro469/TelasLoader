using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace loader
{
    public partial class TelaRegister : Form
    {
        

        public TelaRegister()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
            TelaLogin login =new TelaLogin();
            this.Close();
            login.Show();
        }
    }
}
