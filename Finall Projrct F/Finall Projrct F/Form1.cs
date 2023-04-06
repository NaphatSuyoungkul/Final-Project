namespace Finall_Projrct_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            
            
            if (txtf1.Text!= "")
            {
                total += Convert.ToInt32(txtf1.Text) * 50;
            }
            if (txtf2.Text != "")
            {
                total += Convert.ToInt32(txtf2.Text) * 50;
            }
            if (txtf3.Text != "")
            {
                total += Convert.ToInt32(txtf3.Text) * 50;
            }
            if (txtf4.Text != "")
            {
                total += Convert.ToInt32(txtf4.Text) * 50;
            }
            if (txtf5.Text != "")
            {
                total += Convert.ToInt32(txtf5.Text) * 50;
            }
            if (txtf6.Text != "")
            {
                total += Convert.ToInt32(txtf6.Text) * 50;
            }
            lblpay.Text = total.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblpay.Text = " ";
            txtf1.Text = " ";
            txtf2.Text = " ";
            txtf3.Text = " ";
            txtf4.Text = " ";
            txtf5.Text = " ";
            txtf6.Text = " ";

        }
    }
}