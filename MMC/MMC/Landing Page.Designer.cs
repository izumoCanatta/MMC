namespace MMC
{
    partial class MMC
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
            headerPanel = new Panel();
            headerSubTitle = new Label();
            headerTitle = new Label();
            fontDialog1 = new FontDialog();
            panelBody = new Panel();
            buttonLogin = new Button();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            bodyLogin = new Label();
            headerPanel.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerPanel.BackColor = Color.Transparent;
            headerPanel.Controls.Add(headerSubTitle);
            headerPanel.Controls.Add(headerTitle);
            headerPanel.Location = new Point(4, 32);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(547, 77);
            headerPanel.TabIndex = 1;
            // 
            // headerSubTitle
            // 
            headerSubTitle.AutoSize = true;
            headerSubTitle.Location = new Point(209, 57);
            headerSubTitle.Name = "headerSubTitle";
            headerSubTitle.Size = new Size(120, 20);
            headerSubTitle.TabIndex = 1;
            headerSubTitle.Text = "Established 2025";
            // 
            // headerTitle
            // 
            headerTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            headerTitle.AutoSize = true;
            headerTitle.BackColor = Color.Transparent;
            headerTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerTitle.Location = new Point(55, 0);
            headerTitle.Name = "headerTitle";
            headerTitle.Size = new Size(421, 41);
            headerTitle.TabIndex = 0;
            headerTitle.Text = "Mayong Meling Cooperative";
            headerTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            panelBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelBody.BackColor = Color.Beige;
            panelBody.BorderStyle = BorderStyle.FixedSingle;
            panelBody.Controls.Add(buttonLogin);
            panelBody.Controls.Add(labelPassword);
            panelBody.Controls.Add(textBoxPassword);
            panelBody.Controls.Add(labelUsername);
            panelBody.Controls.Add(textBoxUsername);
            panelBody.Controls.Add(bodyLogin);
            panelBody.Location = new Point(69, 152);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(411, 299);
            panelBody.TabIndex = 2;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = SystemColors.Window;
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonLogin.ForeColor = Color.DarkGreen;
            buttonLogin.Location = new Point(145, 212);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 35);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(54, 157);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(73, 20);
            labelPassword.TabIndex = 4;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(145, 153);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(211, 27);
            textBoxPassword.TabIndex = 3;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Location = new Point(53, 110);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(78, 20);
            labelUsername.TabIndex = 2;
            labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(144, 106);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(211, 27);
            textBoxUsername.TabIndex = 1;
            // 
            // bodyLogin
            // 
            bodyLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bodyLogin.AutoSize = true;
            bodyLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bodyLogin.Location = new Point(127, 39);
            bodyLogin.Name = "bodyLogin";
            bodyLogin.Size = new Size(153, 31);
            bodyLogin.TabIndex = 0;
            bodyLogin.Text = "Admin Login";
            // 
            // MMC
            // 
            AccessibleName = "MMC";
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(559, 625);
            Controls.Add(panelBody);
            Controls.Add(headerPanel);
            MaximizeBox = false;
            Name = "MMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MMC";
            TopMost = true;
            WindowState = FormWindowState.Minimized;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FontDialog fontDialog1;
        private Label headerTitle;
        private Panel headerPanel;
        private Label headerSubTitle;
        private Panel panelBody;
        private Label bodyLogin;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Button buttonLogin;
    }
}
