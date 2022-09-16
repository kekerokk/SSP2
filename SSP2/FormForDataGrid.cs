using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSP2
{
    public partial class FormForDataGrid : Form
    {
        public void StartDataGrid(BindingList<DB.Player> blPS)
        {
            InitializeComponent();
            dataGridView1.DataSource = blPS;
        }
        public FormForDataGrid(BindingList<DB.Player> blPS)
        {

        }
        public FormForDataGrid()
        {

        }


        private void FormForDataGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
