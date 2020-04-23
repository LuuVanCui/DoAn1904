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
using System.IO;

namespace QuanLyNhaXe01
{
    public partial class deleteVehicleByID : Form
    {
        public deleteVehicleByID()
        {
            InitializeComponent();
        }

        

        private void deleteVehicleByID_Load(object sender, EventArgs e)
        {
            comboBoxID.DataSource = vehicle.getVehicle(new SqlCommand("SELECT MaTheXe FROM Xe"));
            comboBoxID.ValueMember = "MaTheXe";
            comboBoxID.ValueMember = "MaTheXe";
            comboBoxID_SelectionChangeCommitted(sender, e);
        }

        
    }
}
