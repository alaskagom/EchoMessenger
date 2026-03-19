namespace EchoMessenger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Ensure initial count is correct
            UpdateMessageCount();
            // Clear placeholder on first click/focus
            txtm.GotFocus += Txtm_GotFocus;
        }

        private void Txtm_GotFocus(object? sender, EventArgs e)
        {
            if (txtm.Text == "(여기에 입력하세요)")
                txtm.Clear();
            txtm.GotFocus -= Txtm_GotFocus;
        }

        private void LSTB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bnt_Click(object sender, EventArgs e)
        {
            // Trim whitespace
            string typed_msg = txtm.Text.Trim();
            if (string.IsNullOrEmpty(typed_msg))
            {
                // Do not add empty messages
                return;
            }

            // Prepend timestamp in format [HH:mm:ss]
            string stamped = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";
            LSTB.Items.Add(stamped);
            txtm.Clear();

            UpdateMessageCount();
        }

        private void UpdateMessageCount()
        {
            int count = LSTB.Items.Count;
            // labelCount is added in designer
            labelCount.Text = $"현재대화: {count}개";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
