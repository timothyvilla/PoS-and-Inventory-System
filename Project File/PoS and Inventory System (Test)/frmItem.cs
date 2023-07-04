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


namespace PoS_and_Inventory_System__Test_
{
    public partial class frmItem : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmInvList frmlist;

        public frmItem(frmInvList flist)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmlist= flist; 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmBrand_Load(object sender, EventArgs e)
        {

        }


        private void Clear()
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;

            txtItem.Clear();
            txtItem.Focus();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this item?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblItem(item)VALUES(@Item)", cn);
                    cm.Parameters.AddWithValue("@Item", txtItem.Text);
                    cm.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show("Record has been successfully saved.");

                    Clear();

                    frmlist.LoadRecords();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
  