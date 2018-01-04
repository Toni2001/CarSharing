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
    public partial class AutosBearbeiten : Form
    {
        private object appData;

        public AutosBearbeiten()
        {
            InitializeComponent();
        }

        private void AutosBearbeiten_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'carSharingDBDataSet5.Auto' table. You can move, or remove it, as needed.
            this.autoTableAdapter1.Fill(this.carSharingDBDataSet5.Auto);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                autoBindingSource.EndEdit();
                autoBindingSource.AddingNew();
                MessageBox.Show("You have been sucessfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor.Current = Cursors.Default;


        }

        private void dataGridView1_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    autoBindingSource.RemoveCurrent();

            }
        }
    }
}
