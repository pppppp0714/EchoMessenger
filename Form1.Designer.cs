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
            lstOutput = new ListBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("바탕", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.SteelBlue;
            lblTitle.Location = new Point(40, 42);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(407, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Echo Messenger";
            // 
            // txtInput
            // 
            txtInput.BackColor = SystemColors.Control;
            txtInput.Font = new Font("맑은 고딕", 11.5F);
            txtInput.Location = new Point(40, 390);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(558, 33);
            txtInput.TabIndex = 1;
            txtInput.Text = "여기에 입력하세요.";
            txtInput.TextChanged += txtInput_TextChanged;
            // 
            // lstOutput
            // 
            lstOutput.BackColor = SystemColors.InactiveCaption;
            lstOutput.Font = new Font("맑은 고딕", 11.5F);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(40, 105);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(722, 254);
            lstOutput.TabIndex = 2;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.GreenYellow;
            btnSend.Font = new Font("바탕", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnSend.Location = new Point(624, 388);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(138, 39);
            btnSend.TabIndex = 3;
            btnSend.Text = "전송";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(lstOutput);
            Controls.Add(txtInput);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtInput;
        private ListBox lstOutput;
        private Button btnSend;
    }
}
