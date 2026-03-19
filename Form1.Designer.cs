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
            lblTitle = new Label();
            txtInput = new TextBox();
            btnClearAll = new Button();
            lstChat = new ListBox();
            btnSend = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("한컴 고딕", 35.9999962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.Highlight;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(783, 125);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            lblTitle.Click += label1_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 638);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(671, 39);
            txtInput.TabIndex = 1;
            txtInput.TextChanged += textBox1_TextChanged;
            txtInput.KeyDown += txtInput_KeyDown;
            // 
            // btnClearAll
            // 
            btnClearAll.BackColor = SystemColors.GradientActiveCaption;
            btnClearAll.Location = new Point(904, 635);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(209, 42);
            btnClearAll.TabIndex = 2;
            btnClearAll.Text = "대화 기록 삭제";
            btnClearAll.UseVisualStyleBackColor = false;
            btnClearAll.Click += btnClearAll_Click;
            // 
            // lstChat
            // 
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(12, 155);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(1316, 420);
            lstChat.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GradientActiveCaption;
            btnSend.Location = new Point(1119, 636);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(209, 42);
            btnSend.TabIndex = 4;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.GradientActiveCaption;
            btnDelete.Location = new Point(689, 636);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(209, 42);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "삭제";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1340, 733);
            Controls.Add(btnDelete);
            Controls.Add(btnSend);
            Controls.Add(lstChat);
            Controls.Add(btnClearAll);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private Button btnClearAll;
        private ListBox lstChat;
        private Button btnSend;
        private Button btnDelete;
    }
}
