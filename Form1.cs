namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Make the Enter key trigger the send button and set initial focus to the input
            AcceptButton = bnt;
            txtm.Focus();
            txtm.KeyDown += Txtm_KeyDown;
        }

        private void LSTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnt_Click(object sender, EventArgs e)
        {
            // Prevent sending empty or whitespace-only messages
            string typed_msg = txtm.Text.Trim();
            if (string.IsNullOrEmpty(typed_msg))
            {
                txtm.Focus();
                return;
            }

            LSTB.Items.Add(typed_msg);
            txtm.Clear();
            txtm.Focus();
        }

        private void Txtm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Suppress the ding and trigger the send action
                e.SuppressKeyPress = true;
                bnt.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
