using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarSharing.Helper;
using CarSharing.Model;

namespace CarSharing.Forms.Menu
{
    public partial class FarbeBearbeiten : Form
    {
        private CarSharingDBEntitiesNew _context;
        public FarbeBearbeiten()
        {
            InitializeComponent();
            _context = new CarSharingDBEntitiesNew();
        }

        private void FarbeBearbeiten_Load(object sender, EventArgs e)
        {
           
                _context.Farbe.Include(c => c.Auto).Load();
                dataGridViewColor.DataSource = _context.Farbe.Local.ToBindingList();

           
        }

        private void FarbeBearbeiten_FormClosing(object sender, FormClosingEventArgs e)
        {
           
                _context.SaveChanges();
           
        }
    }
}
