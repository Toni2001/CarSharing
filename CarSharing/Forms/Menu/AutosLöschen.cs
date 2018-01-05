using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSharing
{
    public partial class AutosLöschen : Form
    {
        public AutosLöschen()
        {
            InitializeComponent();
        }

        private void AutosLöschen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carSharingDBDataSet4.Auto' table. You can move, or remove it, as needed.
            //this.autoTableAdapter.Fill(this.carSharingDBDataSet4.Auto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
