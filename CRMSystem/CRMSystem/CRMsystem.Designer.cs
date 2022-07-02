namespace CRMSystem
{
    partial class CRMsystem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.findbutton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.workAreaPanel = new System.Windows.Forms.Panel();
            this.addUF = new CRMSystem.AddUF();
            this.printUF = new CRMSystem.PrintUF();
            this.editUF = new CRMSystem.EditUF();
            this.deleteUF = new CRMSystem.DeleteUF();
            this.findUF = new CRMSystem.FindUF();
            this.panel1.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.workAreaPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(88)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 36F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(327, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(616, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arison Holdings Limited";
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.optionPanel.AutoSize = true;
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(88)))));
            this.optionPanel.Controls.Add(this.addButton);
            this.optionPanel.Controls.Add(this.findbutton);
            this.optionPanel.Controls.Add(this.printButton);
            this.optionPanel.Controls.Add(this.editButton);
            this.optionPanel.Controls.Add(this.deleteButton);
            this.optionPanel.Location = new System.Drawing.Point(0, 100);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(182, 581);
            this.optionPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.addButton.Font = new System.Drawing.Font("Elephant", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addButton.Location = new System.Drawing.Point(3, 116);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(176, 110);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // findbutton
            // 
            this.findbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.findbutton.Font = new System.Drawing.Font("Elephant", 36F);
            this.findbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findbutton.Location = new System.Drawing.Point(3, 0);
            this.findbutton.Name = "findbutton";
            this.findbutton.Size = new System.Drawing.Size(176, 110);
            this.findbutton.TabIndex = 0;
            this.findbutton.Text = "Find";
            this.findbutton.UseVisualStyleBackColor = false;
            this.findbutton.Click += new System.EventHandler(this.findbutton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.printButton.Font = new System.Drawing.Font("Elephant", 36F);
            this.printButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printButton.Location = new System.Drawing.Point(3, 464);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(176, 110);
            this.printButton.TabIndex = 4;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.editButton.Font = new System.Drawing.Font("Elephant", 36F);
            this.editButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.editButton.Location = new System.Drawing.Point(3, 348);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(176, 110);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.deleteButton.Font = new System.Drawing.Font("Elephant", 30.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteButton.Location = new System.Drawing.Point(3, 232);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(176, 110);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // workAreaPanel
            // 
            this.workAreaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workAreaPanel.AutoSize = true;
            this.workAreaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.workAreaPanel.Controls.Add(this.addUF);
            this.workAreaPanel.Controls.Add(this.printUF);
            this.workAreaPanel.Controls.Add(this.editUF);
            this.workAreaPanel.Controls.Add(this.deleteUF);
            this.workAreaPanel.Controls.Add(this.findUF);
            this.workAreaPanel.Location = new System.Drawing.Point(185, 100);
            this.workAreaPanel.Name = "workAreaPanel";
            this.workAreaPanel.Size = new System.Drawing.Size(1082, 584);
            this.workAreaPanel.TabIndex = 2;
            // 
            // addUF
            // 
            this.addUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.addUF.Location = new System.Drawing.Point(0, 0);
            this.addUF.Name = "addUF";
            this.addUF.Size = new System.Drawing.Size(1079, 581);
            this.addUF.TabIndex = 0;
            this.addUF.Visible = false;
            this.addUF.Load += new System.EventHandler(this.addUF_Load);
            // 
            // printUF
            // 
            this.printUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.printUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printUF.Location = new System.Drawing.Point(0, 0);
            this.printUF.Name = "printUF";
            this.printUF.Size = new System.Drawing.Size(1082, 584);
            this.printUF.TabIndex = 4;
            this.printUF.Visible = false;
            // 
            // editUF
            // 
            this.editUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.editUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.editUF.Location = new System.Drawing.Point(0, 0);
            this.editUF.Name = "editUF";
            this.editUF.Size = new System.Drawing.Size(1082, 584);
            this.editUF.TabIndex = 3;
            this.editUF.Visible = false;
            // 
            // deleteUF
            // 
            this.deleteUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.deleteUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteUF.Location = new System.Drawing.Point(0, 0);
            this.deleteUF.Name = "deleteUF";
            this.deleteUF.Size = new System.Drawing.Size(1082, 584);
            this.deleteUF.TabIndex = 2;
            this.deleteUF.Visible = false;
            // 
            // findUF
            // 
            this.findUF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.findUF.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findUF.Location = new System.Drawing.Point(0, 0);
            this.findUF.Name = "findUF";
            this.findUF.Size = new System.Drawing.Size(1082, 584);
            this.findUF.TabIndex = 1;
            this.findUF.Load += new System.EventHandler(this.findUF1_Load);
            // 
            // CRMsystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(27)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.workAreaPanel);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "CRMsystem";
            this.Text = "CRMsystem";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.workAreaPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button findbutton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Panel workAreaPanel;
        private AddUF addUF;
        private PrintUF printUF;
        private EditUF editUF;
        private DeleteUF deleteUF;
        private FindUF findUF;
    }
}