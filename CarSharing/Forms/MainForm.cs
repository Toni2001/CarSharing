using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSharing.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutosAusleihen formLaAutosAusleihen = new AutosAusleihen();
            formLaAutosAusleihen.Show();
        }

        private void btnAutosKaufen_Click(object sender, EventArgs e)
        {
            AutosKaufen formKaufen = new AutosKaufen();
            formKaufen.Show();
        }

        private void btnAutosLöschen_Click(object sender, EventArgs e)
        {
            AutosLöschen formLöschen = new AutosLöschen();
            formLöschen.Show();
        }

        private void btnAutosBearbeiten_Click(object sender, EventArgs e)
        {
            AutosBearbeiten formBearbeiten = new AutosBearbeiten();
            formBearbeiten.Show();
        }
    }
}
