namespace CRMSystem
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.adminIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.adminLoginLabel = new System.Windows.Forms.Label();
            this.adminTextBox = new System.Windows.Forms.TextBox();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminLoginPanel = new System.Windows.Forms.Panel();
            this.goBackAdminButton = new System.Windows.Forms.Button();
            this.changePasswordAdminButton = new System.Windows.Forms.Button();
            this.changeLoginInfoPanel = new System.Windows.Forms.Panel();
            this.goBackChangePassButton = new System.Windows.Forms.Button();
            this.currentPasswordTextBoxt = new System.Windows.Forms.TextBox();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.newPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.newUserIdTextBox = new System.Windows.Forms.TextBox();
            this.newUserIdLabel = new System.Windows.Forms.Label();
            this.currentPasswordLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userPassTextBox = new System.Windows.Forms.TextBox();
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.loginUserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chagnePassUserButton = new System.Windows.Forms.Button();
            this.userLoginPanel = new System.Windows.Forms.Panel();
            this.goBackUserButton = new System.Windows.Forms.Button();
            this.changeLoginInfoUserPanel = new System.Windows.Forms.Panel();
            this.goBackChangePassUserButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.updateChangePassUserButton = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gatePanel = new System.Windows.Forms.Panel();
            this.userGateButton = new System.Windows.Forms.Button();
            this.adminGateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.adminLoginPanel.SuspendLayout();
            this.changeLoginInfoPanel.SuspendLayout();
            this.userLoginPanel.SuspendLayout();
            this.changeLoginInfoUserPanel.SuspendLayout();
            this.gatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminIdLabel
            // 
            this.adminIdLabel.AutoSize = true;
            this.adminIdLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminIdLabel.Location = new System.Drawing.Point(5, 134);
            this.adminIdLabel.Name = "adminIdLabel";
            this.adminIdLabel.Size = new System.Drawing.Size(125, 32);
            this.adminIdLabel.TabIndex = 0;
            this.adminIdLabel.Text = "Admin ID";
            this.adminIdLabel.Click += new System.EventHandler(this.userIdLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(5, 212);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(118, 32);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // adminLoginLabel
            // 
            this.adminLoginLabel.AutoSize = true;
            this.adminLoginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.adminLoginLabel.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLoginLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminLoginLabel.Location = new System.Drawing.Point(89, 25);
            this.adminLoginLabel.Name = "adminLoginLabel";
            this.adminLoginLabel.Size = new System.Drawing.Size(322, 65);
            this.adminLoginLabel.TabIndex = 2;
            this.adminLoginLabel.Text = "Admin Login";
            // 
            // adminTextBox
            // 
            this.adminTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.adminTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminTextBox.Location = new System.Drawing.Point(155, 134);
            this.adminTextBox.Name = "adminTextBox";
            this.adminTextBox.Size = new System.Drawing.Size(274, 31);
            this.adminTextBox.TabIndex = 0;
            this.adminTextBox.TextChanged += new System.EventHandler(this.userTextBox_TextChanged);
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.adminPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminPasswordTextBox.Location = new System.Drawing.Point(155, 214);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.Size = new System.Drawing.Size(274, 31);
            this.adminPasswordTextBox.TabIndex = 1;
            this.adminPasswordTextBox.UseSystemPasswordChar = true;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            this.loginButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginButton.Location = new System.Drawing.Point(155, 288);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(274, 48);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 681);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // adminLoginPanel
            // 
            this.adminLoginPanel.Controls.Add(this.goBackAdminButton);
            this.adminLoginPanel.Controls.Add(this.changePasswordAdminButton);
            this.adminLoginPanel.Controls.Add(this.adminLoginLabel);
            this.adminLoginPanel.Controls.Add(this.loginButton);
            this.adminLoginPanel.Controls.Add(this.adminTextBox);
            this.adminLoginPanel.Controls.Add(this.adminPasswordTextBox);
            this.adminLoginPanel.Controls.Add(this.adminIdLabel);
            this.adminLoginPanel.Controls.Add(this.passwordLabel);
            this.adminLoginPanel.Location = new System.Drawing.Point(642, 160);
            this.adminLoginPanel.Name = "adminLoginPanel";
            this.adminLoginPanel.Size = new System.Drawing.Size(546, 486);
            this.adminLoginPanel.TabIndex = 8;
            this.adminLoginPanel.Visible = false;
            this.adminLoginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // goBackAdminButton
            // 
            this.goBackAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.goBackAdminButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackAdminButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goBackAdminButton.Location = new System.Drawing.Point(258, 420);
            this.goBackAdminButton.Name = "goBackAdminButton";
            this.goBackAdminButton.Size = new System.Drawing.Size(78, 31);
            this.goBackAdminButton.TabIndex = 4;
            this.goBackAdminButton.Text = "Go Back";
            this.goBackAdminButton.UseVisualStyleBackColor = false;
            this.goBackAdminButton.Click += new System.EventHandler(this.goBackAdminButton_Click);
            // 
            // changePasswordAdminButton
            // 
            this.changePasswordAdminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.changePasswordAdminButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changePasswordAdminButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.changePasswordAdminButton.Location = new System.Drawing.Point(220, 360);
            this.changePasswordAdminButton.Name = "changePasswordAdminButton";
            this.changePasswordAdminButton.Size = new System.Drawing.Size(148, 31);
            this.changePasswordAdminButton.TabIndex = 3;
            this.changePasswordAdminButton.Text = "Change Password";
            this.changePasswordAdminButton.UseVisualStyleBackColor = false;
            this.changePasswordAdminButton.Click += new System.EventHandler(this.changePasswordAdminButton_Click);
            // 
            // changeLoginInfoPanel
            // 
            this.changeLoginInfoPanel.Controls.Add(this.goBackChangePassButton);
            this.changeLoginInfoPanel.Controls.Add(this.currentPasswordTextBoxt);
            this.changeLoginInfoPanel.Controls.Add(this.confirmPasswordTextBox);
            this.changeLoginInfoPanel.Controls.Add(this.confirmPasswordLabel);
            this.changeLoginInfoPanel.Controls.Add(this.newPasswordTextBox);
            this.changeLoginInfoPanel.Controls.Add(this.newPasswordLabel);
            this.changeLoginInfoPanel.Controls.Add(this.updateButton);
            this.changeLoginInfoPanel.Controls.Add(this.newUserIdTextBox);
            this.changeLoginInfoPanel.Controls.Add(this.newUserIdLabel);
            this.changeLoginInfoPanel.Controls.Add(this.currentPasswordLabel);
            this.changeLoginInfoPanel.Location = new System.Drawing.Point(642, 150);
            this.changeLoginInfoPanel.Name = "changeLoginInfoPanel";
            this.changeLoginInfoPanel.Size = new System.Drawing.Size(602, 381);
            this.changeLoginInfoPanel.TabIndex = 9;
            this.changeLoginInfoPanel.Visible = false;
            // 
            // goBackChangePassButton
            // 
            this.goBackChangePassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.goBackChangePassButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackChangePassButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goBackChangePassButton.Location = new System.Drawing.Point(243, 347);
            this.goBackChangePassButton.Name = "goBackChangePassButton";
            this.goBackChangePassButton.Size = new System.Drawing.Size(78, 31);
            this.goBackChangePassButton.TabIndex = 10;
            this.goBackChangePassButton.Text = "Go Back";
            this.goBackChangePassButton.UseVisualStyleBackColor = false;
            this.goBackChangePassButton.Click += new System.EventHandler(this.goBackChangePassButton_Click);
            // 
            // currentPasswordTextBoxt
            // 
            this.currentPasswordTextBoxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.currentPasswordTextBoxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentPasswordTextBoxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentPasswordTextBoxt.Location = new System.Drawing.Point(243, 89);
            this.currentPasswordTextBoxt.Name = "currentPasswordTextBoxt";
            this.currentPasswordTextBoxt.Size = new System.Drawing.Size(318, 31);
            this.currentPasswordTextBoxt.TabIndex = 1;
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(243, 216);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(318, 31);
            this.confirmPasswordTextBox.TabIndex = 3;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.confirmPasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(5, 214);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(214, 32);
            this.confirmPasswordLabel.TabIndex = 9;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // newPasswordTextBox
            // 
            this.newPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.newPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPasswordTextBox.Location = new System.Drawing.Point(243, 157);
            this.newPasswordTextBox.Name = "newPasswordTextBox";
            this.newPasswordTextBox.Size = new System.Drawing.Size(318, 31);
            this.newPasswordTextBox.TabIndex = 2;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.newPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newPasswordLabel.Location = new System.Drawing.Point(5, 155);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(176, 32);
            this.newPasswordLabel.TabIndex = 6;
            this.newPasswordLabel.Text = "New Password";
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            this.updateButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(137, 277);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(274, 48);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // newUserIdTextBox
            // 
            this.newUserIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.newUserIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserIdTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newUserIdTextBox.Location = new System.Drawing.Point(243, 24);
            this.newUserIdTextBox.Name = "newUserIdTextBox";
            this.newUserIdTextBox.Size = new System.Drawing.Size(318, 31);
            this.newUserIdTextBox.TabIndex = 0;
            // 
            // newUserIdLabel
            // 
            this.newUserIdLabel.AutoSize = true;
            this.newUserIdLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newUserIdLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newUserIdLabel.Location = new System.Drawing.Point(5, 22);
            this.newUserIdLabel.Name = "newUserIdLabel";
            this.newUserIdLabel.Size = new System.Drawing.Size(158, 32);
            this.newUserIdLabel.TabIndex = 0;
            this.newUserIdLabel.Text = "New User ID";
            // 
            // currentPasswordLabel
            // 
            this.currentPasswordLabel.AutoSize = true;
            this.currentPasswordLabel.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.currentPasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.currentPasswordLabel.Location = new System.Drawing.Point(5, 87);
            this.currentPasswordLabel.Name = "currentPasswordLabel";
            this.currentPasswordLabel.Size = new System.Drawing.Size(209, 32);
            this.currentPasswordLabel.TabIndex = 1;
            this.currentPasswordLabel.Text = "Current Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(3, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 32);
            this.label5.TabIndex = 1;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(5, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "User ID";
            // 
            // userPassTextBox
            // 
            this.userPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.userPassTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userPassTextBox.Location = new System.Drawing.Point(155, 214);
            this.userPassTextBox.Name = "userPassTextBox";
            this.userPassTextBox.Size = new System.Drawing.Size(274, 31);
            this.userPassTextBox.TabIndex = 1;
            this.userPassTextBox.UseSystemPasswordChar = true;
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.userIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdTextBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userIdTextBox.Location = new System.Drawing.Point(155, 134);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(274, 31);
            this.userIdTextBox.TabIndex = 0;
            // 
            // loginUserButton
            // 
            this.loginUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            this.loginUserButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginUserButton.Location = new System.Drawing.Point(155, 288);
            this.loginUserButton.Name = "loginUserButton";
            this.loginUserButton.Size = new System.Drawing.Size(274, 48);
            this.loginUserButton.TabIndex = 2;
            this.loginUserButton.Text = "Login";
            this.loginUserButton.UseVisualStyleBackColor = false;
            this.loginUserButton.Click += new System.EventHandler(this.loginUserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(163, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 65);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Login";
            // 
            // chagnePassUserButton
            // 
            this.chagnePassUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.chagnePassUserButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chagnePassUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.chagnePassUserButton.Location = new System.Drawing.Point(220, 360);
            this.chagnePassUserButton.Name = "chagnePassUserButton";
            this.chagnePassUserButton.Size = new System.Drawing.Size(148, 31);
            this.chagnePassUserButton.TabIndex = 3;
            this.chagnePassUserButton.Text = "Change Password";
            this.chagnePassUserButton.UseVisualStyleBackColor = false;
            this.chagnePassUserButton.Click += new System.EventHandler(this.chagnePassUserButton_Click);
            // 
            // userLoginPanel
            // 
            this.userLoginPanel.Controls.Add(this.goBackUserButton);
            this.userLoginPanel.Controls.Add(this.chagnePassUserButton);
            this.userLoginPanel.Controls.Add(this.label1);
            this.userLoginPanel.Controls.Add(this.loginUserButton);
            this.userLoginPanel.Controls.Add(this.userIdTextBox);
            this.userLoginPanel.Controls.Add(this.userPassTextBox);
            this.userLoginPanel.Controls.Add(this.label4);
            this.userLoginPanel.Controls.Add(this.label5);
            this.userLoginPanel.Location = new System.Drawing.Point(623, 142);
            this.userLoginPanel.Name = "userLoginPanel";
            this.userLoginPanel.Size = new System.Drawing.Size(596, 469);
            this.userLoginPanel.TabIndex = 10;
            this.userLoginPanel.Visible = false;
            // 
            // goBackUserButton
            // 
            this.goBackUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.goBackUserButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goBackUserButton.Location = new System.Drawing.Point(262, 425);
            this.goBackUserButton.Name = "goBackUserButton";
            this.goBackUserButton.Size = new System.Drawing.Size(78, 31);
            this.goBackUserButton.TabIndex = 5;
            this.goBackUserButton.Text = "Go Back";
            this.goBackUserButton.UseVisualStyleBackColor = false;
            this.goBackUserButton.Click += new System.EventHandler(this.goBackUserButton_Click);
            // 
            // changeLoginInfoUserPanel
            // 
            this.changeLoginInfoUserPanel.Controls.Add(this.goBackChangePassUserButton);
            this.changeLoginInfoUserPanel.Controls.Add(this.textBox1);
            this.changeLoginInfoUserPanel.Controls.Add(this.textBox2);
            this.changeLoginInfoUserPanel.Controls.Add(this.label2);
            this.changeLoginInfoUserPanel.Controls.Add(this.textBox5);
            this.changeLoginInfoUserPanel.Controls.Add(this.label3);
            this.changeLoginInfoUserPanel.Controls.Add(this.updateChangePassUserButton);
            this.changeLoginInfoUserPanel.Controls.Add(this.textBox6);
            this.changeLoginInfoUserPanel.Controls.Add(this.label6);
            this.changeLoginInfoUserPanel.Controls.Add(this.label7);
            this.changeLoginInfoUserPanel.Location = new System.Drawing.Point(626, 137);
            this.changeLoginInfoUserPanel.Name = "changeLoginInfoUserPanel";
            this.changeLoginInfoUserPanel.Size = new System.Drawing.Size(608, 424);
            this.changeLoginInfoUserPanel.TabIndex = 11;
            this.changeLoginInfoUserPanel.Visible = false;
            // 
            // goBackChangePassUserButton
            // 
            this.goBackChangePassUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.goBackChangePassUserButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBackChangePassUserButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goBackChangePassUserButton.Location = new System.Drawing.Point(243, 347);
            this.goBackChangePassUserButton.Name = "goBackChangePassUserButton";
            this.goBackChangePassUserButton.Size = new System.Drawing.Size(78, 31);
            this.goBackChangePassUserButton.TabIndex = 10;
            this.goBackChangePassUserButton.Text = "Go Back";
            this.goBackChangePassUserButton.UseVisualStyleBackColor = false;
            this.goBackChangePassUserButton.Click += new System.EventHandler(this.goBackChangePassUserButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(243, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2.Location = new System.Drawing.Point(243, 216);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(318, 31);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Confirm Password";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5.Location = new System.Drawing.Point(243, 157);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(318, 31);
            this.textBox5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(5, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "New Password";
            // 
            // updateChangePassUserButton
            // 
            this.updateChangePassUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(180)))), ((int)(((byte)(138)))));
            this.updateChangePassUserButton.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateChangePassUserButton.Location = new System.Drawing.Point(137, 277);
            this.updateChangePassUserButton.Name = "updateChangePassUserButton";
            this.updateChangePassUserButton.Size = new System.Drawing.Size(274, 48);
            this.updateChangePassUserButton.TabIndex = 4;
            this.updateChangePassUserButton.Text = "Update";
            this.updateChangePassUserButton.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox6.Location = new System.Drawing.Point(243, 24);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(318, 31);
            this.textBox6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(5, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "New User ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(5, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 32);
            this.label7.TabIndex = 1;
            this.label7.Text = "Current Password";
            // 
            // gatePanel
            // 
            this.gatePanel.Controls.Add(this.userGateButton);
            this.gatePanel.Controls.Add(this.adminGateButton);
            this.gatePanel.Location = new System.Drawing.Point(634, 91);
            this.gatePanel.Name = "gatePanel";
            this.gatePanel.Size = new System.Drawing.Size(596, 555);
            this.gatePanel.TabIndex = 11;
            // 
            // userGateButton
            // 
            this.userGateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.userGateButton.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userGateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userGateButton.Location = new System.Drawing.Point(145, 302);
            this.userGateButton.Name = "userGateButton";
            this.userGateButton.Size = new System.Drawing.Size(274, 109);
            this.userGateButton.TabIndex = 3;
            this.userGateButton.Text = "User";
            this.userGateButton.UseVisualStyleBackColor = false;
            this.userGateButton.Click += new System.EventHandler(this.userGateButton_Click);
            // 
            // adminGateButton
            // 
            this.adminGateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.adminGateButton.Font = new System.Drawing.Font("Palatino Linotype", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminGateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminGateButton.Location = new System.Drawing.Point(145, 109);
            this.adminGateButton.Name = "adminGateButton";
            this.adminGateButton.Size = new System.Drawing.Size(274, 109);
            this.adminGateButton.TabIndex = 2;
            this.adminGateButton.Text = "Admin";
            this.adminGateButton.UseVisualStyleBackColor = false;
            this.adminGateButton.Click += new System.EventHandler(this.adminGateButton_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1251, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.adminLoginPanel);
            this.Controls.Add(this.changeLoginInfoUserPanel);
            this.Controls.Add(this.userLoginPanel);
            this.Controls.Add(this.changeLoginInfoPanel);
            this.Controls.Add(this.gatePanel);
            this.Name = "loginForm";
            this.Text = "CRM System - Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.adminLoginPanel.ResumeLayout(false);
            this.adminLoginPanel.PerformLayout();
            this.changeLoginInfoPanel.ResumeLayout(false);
            this.changeLoginInfoPanel.PerformLayout();
            this.userLoginPanel.ResumeLayout(false);
            this.userLoginPanel.PerformLayout();
            this.changeLoginInfoUserPanel.ResumeLayout(false);
            this.changeLoginInfoUserPanel.PerformLayout();
            this.gatePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label adminIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label adminLoginLabel;
        private System.Windows.Forms.TextBox adminTextBox;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adminLoginPanel;
        private System.Windows.Forms.Panel changeLoginInfoPanel;
        private System.Windows.Forms.TextBox newPasswordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox newUserIdTextBox;
        private System.Windows.Forms.TextBox currentPasswordTextBoxt;
        private System.Windows.Forms.Label newUserIdLabel;
        private System.Windows.Forms.Label currentPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button changePasswordAdminButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userPassTextBox;
        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.Button loginUserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chagnePassUserButton;
        private System.Windows.Forms.Panel userLoginPanel;
        private System.Windows.Forms.Panel gatePanel;
        private System.Windows.Forms.Button userGateButton;
        private System.Windows.Forms.Button adminGateButton;
        private System.Windows.Forms.Button goBackAdminButton;
        private System.Windows.Forms.Button goBackChangePassButton;
        private System.Windows.Forms.Button goBackUserButton;
        private System.Windows.Forms.Panel changeLoginInfoUserPanel;
        private System.Windows.Forms.Button goBackChangePassUserButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button updateChangePassUserButton;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

