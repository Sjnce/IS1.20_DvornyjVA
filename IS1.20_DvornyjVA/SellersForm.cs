using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IS1._20_DvornyjVA
{
    public partial class SellersForm : Form
    {
        public SellersForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"");
        private void SellersForm_Load(object sender, EventArgs e)
        {

        }
    }
}
