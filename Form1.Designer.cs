namespace EchoMessenger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bnt = new Button();
            label1 = new Label();
            LSTB = new ListBox();
            txtm = new TextBox();
            btnDelete = new Button();
            btnClearAll = new Button();
            lblCount = new Label();
            SuspendLayout();
            // 
            // bnt
            // 
            bnt.BackColor = Color.FromArgb(128, 255, 128);
            bnt.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            bnt.Location = new Point(624, 360);
            bnt.Name = "bnt";
            bnt.Size = new Size(124, 49);
            bnt.TabIndex = 0;
            bnt.Text = "전송";
            bnt.UseVisualStyleBackColor = false;
            bnt.Click += bnt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(38, 31);
            label1.Name = "label1";
            label1.Size = new Size(333, 54);
            label1.TabIndex = 1;
            label1.Text = "Echo Messenger";
            // 
            // LSTB
            // 
            LSTB.BackColor = Color.FromArgb(255, 255, 192);
            LSTB.FormattingEnabled = true;
            LSTB.Location = new Point(38, 94);
            LSTB.Name = "LSTB";
            LSTB.Size = new Size(580, 244);
            LSTB.TabIndex = 2;
            LSTB.SelectedIndexChanged += LSTB_SelectedIndexChanged;
            // 
            // txtm
            // 
            txtm.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtm.Location = new Point(41, 360);
            txtm.MaxLength = 50;
            txtm.Name = "txtm";
            txtm.Size = new Size(557, 34);
            txtm.TabIndex = 3;
            txtm.Text = "(여기에 입력하세요)";
            txtm.TextChanged += textBox1_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 192, 192);
            btnDelete.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnDelete.Location = new Point(624, 320);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 34);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = Color.FromArgb(255, 192, 255);
            btnClearAll.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnClearAll.Location = new Point(624, 280);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(124, 34);
            btnClearAll.TabIndex = 5;
            btnClearAll.Text = "대화기록삭제";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblCount.Location = new Point(38, 420);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(100, 20);
            lblCount.TabIndex = 6;
            lblCount.Text = "현재대화: 0개";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtm);
            Controls.Add(LSTB);
            Controls.Add(label1);
            Controls.Add(bnt);
            Controls.Add(btnDelete);
            Controls.Add(btnClearAll);
            Controls.Add(lblCount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bnt;
        private Label label1;
        private ListBox LSTB;
        private TextBox txtm;
        private Button btnDelete;
        private Button btnClearAll;
        private Label lblCount;
    }
}
