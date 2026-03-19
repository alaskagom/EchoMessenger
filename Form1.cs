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
            // initialize message count label
            UpdateMessageCount();
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

            // Enforce 50 character limit as a safety check
            if (typed_msg.Length > 50)
            {
                MessageBox.Show("메시지는 50자 이하로 입력해주세요.", "글자수 제한", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtm.Focus();
                return;
            }

            // add timestamped message
            string timestamped = $"[{DateTime.Now:HH:mm:ss}] {typed_msg}";
            LSTB.Items.Add(timestamped);
            txtm.Clear();
            txtm.Focus();
            UpdateMessageCount();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LSTB.SelectedIndex < 0)
                {
                    MessageBox.Show("삭제할 항목을 선택하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                LSTB.Items.RemoveAt(LSTB.SelectedIndex);
                UpdateMessageCount();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 중 오류가 발생했습니다: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (LSTB.Items.Count == 0)
            {
                MessageBox.Show("삭제할 대화기록이 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LSTB.Items.Clear();
            UpdateMessageCount();
        }

        private void UpdateMessageCount()
        {
            if (lblCount != null)
            {
                lblCount.Text = $"현재대화: {LSTB.Items.Count}개";
            }
        }
    }
}
