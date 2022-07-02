namespace CRMSystem
{
    partial class DeleteUF
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteTB = new System.Windows.Forms.TextBox();
            this.sureDeletePanel = new System.Windows.Forms.Panel();
            this.deleteNoButton = new System.Windows.Forms.Button();
            this.yesNodeletePanel = new System.Windows.Forms.Panel();
            this.deleteYesButton = new System.Windows.Forms.Button();
            this.phoneNumberDeletePanel = new System.Windows.Forms.Panel();
            this.phoneNumberAddLabel = new System.Windows.Forms.Label();
            this.findFindButton = new System.Windows.Forms.Button();
            this.phoneNumberDeleteTB = new System.Windows.Forms.TextBox();
            this.sureDeletePanel.SuspendLayout();
            this.phoneNumberDeletePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // deleteTB
            // 
            this.deleteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.deleteTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteTB.Font = new System.Drawing.Font("Lucida Bright", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTB.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteTB.Location = new System.Drawing.Point(3, 3);
            this.deleteTB.Name = "deleteTB";
            this.deleteTB.Size = new System.Drawing.Size(820, 38);
            this.deleteTB.TabIndex = 0;
            this.deleteTB.Text = "Are You Sure You want To delete This Profile?";
            // 
            // sureDeletePanel
            // 
            this.sureDeletePanel.Controls.Add(this.deleteNoButton);
            this.sureDeletePanel.Controls.Add(this.yesNodeletePanel);
            this.sureDeletePanel.Controls.Add(this.deleteYesButton);
            this.sureDeletePanel.Controls.Add(this.deleteTB);
            this.sureDeletePanel.Location = new System.Drawing.Point(120, 180);
            this.sureDeletePanel.Name = "sureDeletePanel";
            this.sureDeletePanel.Size = new System.Drawing.Size(835, 136);
            this.sureDeletePanel.TabIndex = 0;
            this.sureDeletePanel.Visible = false;
            // 
            // deleteNoButton
            // 
            this.deleteNoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.deleteNoButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteNoButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteNoButton.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.deleteNoButton.Location = new System.Drawing.Point(446, 73);
            this.deleteNoButton.Name = "deleteNoButton";
            this.deleteNoButton.Size = new System.Drawing.Size(198, 45);
            this.deleteNoButton.TabIndex = 2;
            this.deleteNoButton.Text = "No";
            this.deleteNoButton.UseVisualStyleBackColor = false;
            // 
            // yesNodeletePanel
            // 
            this.yesNodeletePanel.Location = new System.Drawing.Point(219, 134);
            this.yesNodeletePanel.Name = "yesNodeletePanel";
            this.yesNodeletePanel.Size = new System.Drawing.Size(425, 53);
            this.yesNodeletePanel.TabIndex = 2;
            // 
            // deleteYesButton
            // 
            this.deleteYesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteYesButton.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteYesButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteYesButton.Location = new System.Drawing.Point(219, 73);
            this.deleteYesButton.Name = "deleteYesButton";
            this.deleteYesButton.Size = new System.Drawing.Size(198, 45);
            this.deleteYesButton.TabIndex = 1;
            this.deleteYesButton.Text = "Yes";
            this.deleteYesButton.UseVisualStyleBackColor = false;
            // 
            // phoneNumberDeletePanel
            // 
            this.phoneNumberDeletePanel.AutoSize = true;
            this.phoneNumberDeletePanel.Controls.Add(this.phoneNumberAddLabel);
            this.phoneNumberDeletePanel.Controls.Add(this.findFindButton);
            this.phoneNumberDeletePanel.Controls.Add(this.phoneNumberDeleteTB);
            this.phoneNumberDeletePanel.Location = new System.Drawing.Point(27, 21);
            this.phoneNumberDeletePanel.Name = "phoneNumberDeletePanel";
            this.phoneNumberDeletePanel.Size = new System.Drawing.Size(984, 82);
            this.phoneNumberDeletePanel.TabIndex = 62;
            // 
            // phoneNumberAddLabel
            // 
            this.phoneNumberAddLabel.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberAddLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.phoneNumberAddLabel.Location = new System.Drawing.Point(-8, 0);
            this.phoneNumberAddLabel.Name = "phoneNumberAddLabel";
            this.phoneNumberAddLabel.Size = new System.Drawing.Size(259, 65);
            this.phoneNumberAddLabel.TabIndex = 39;
            this.phoneNumberAddLabel.Text = "Phone Number";
            // 
            // findFindButton
            // 
            this.findFindButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findFindButton.BackColor = System.Drawing.Color.Snow;
            this.findFindButton.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findFindButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findFindButton.Location = new System.Drawing.Point(828, 12);
            this.findFindButton.Name = "findFindButton";
            this.findFindButton.Size = new System.Drawing.Size(140, 59);
            this.findFindButton.TabIndex = 53;
            this.findFindButton.Text = "Delete";
            this.findFindButton.UseVisualStyleBackColor = false;
            this.findFindButton.Click += new System.EventHandler(this.findFindButton_Click);
            // 
            // phoneNumberDeleteTB
            // 
            this.phoneNumberDeleteTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberDeleteTB.Location = new System.Drawing.Point(281, 12);
            this.phoneNumberDeleteTB.Name = "phoneNumberDeleteTB";
            this.phoneNumberDeleteTB.Size = new System.Drawing.Size(280, 29);
            this.phoneNumberDeleteTB.TabIndex = 38;
            // 
            // DeleteUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.Controls.Add(this.phoneNumberDeletePanel);
            this.Controls.Add(this.sureDeletePanel);
            this.Name = "DeleteUF";
            this.Size = new System.Drawing.Size(1079, 581);
            this.sureDeletePanel.ResumeLayout(false);
            this.sureDeletePanel.PerformLayout();
            this.phoneNumberDeletePanel.ResumeLayout(false);
            this.phoneNumberDeletePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox deleteTB;
        private System.Windows.Forms.Panel sureDeletePanel;
        private System.Windows.Forms.Panel yesNodeletePanel;
        private System.Windows.Forms.Button deleteNoButton;
        private System.Windows.Forms.Button deleteYesButton;
        private System.Windows.Forms.Panel phoneNumberDeletePanel;
        private System.Windows.Forms.Label phoneNumberAddLabel;
        private System.Windows.Forms.Button findFindButton;
        private System.Windows.Forms.TextBox phoneNumberDeleteTB;
    }
}
