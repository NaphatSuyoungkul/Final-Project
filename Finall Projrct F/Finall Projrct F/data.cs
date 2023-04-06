using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Finall_Projrct_F.Class1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Finall_Projrct_F
{
    public partial class login : Form
    {
        public Class1 new_Class1;
        public login(string usename)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usename = tbname.Text;
            string password = tbpass.Text;

            Class1 data = new login (usename,password);

            if (!data.IsVaild())
            {

                MessageBox.Show("Invalid username or password");
            }
            else
            {


                this.Close();
                Form1 FormHistory = new Form1();
                FormHistory.ShowDialog();
            }

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
