namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LSTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnt_Click(object sender, EventArgs e)
        {
            string typed_msg = txtm.Text;
            LSTB.Items.Add(typed_msg);
            txtm.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
