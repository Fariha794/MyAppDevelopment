namespace CRMSystem
{
    partial class PrintUF
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
            this.printActionButton = new System.Windows.Forms.Button();
            this.printPreviewActionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printActionButton
            // 
            this.printActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.printActionButton.Font = new System.Drawing.Font("Elephant", 36F);
            this.printActionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printActionButton.Location = new System.Drawing.Point(230, 211);
            this.printActionButton.Name = "printActionButton";
            this.printActionButton.Size = new System.Drawing.Size(176, 110);
            this.printActionButton.TabIndex = 5;
            this.printActionButton.Text = "Print";
            this.printActionButton.UseVisualStyleBackColor = false;
            // 
            // printPreviewActionButton
            // 
            this.printPreviewActionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(88)))), ((int)(((byte)(166)))));
            this.printPreviewActionButton.Font = new System.Drawing.Font("Elephant", 36F);
            this.printPreviewActionButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.printPreviewActionButton.Location = new System.Drawing.Point(476, 211);
            this.printPreviewActionButton.Name = "printPreviewActionButton";
            this.printPreviewActionButton.Size = new System.Drawing.Size(441, 110);
            this.printPreviewActionButton.TabIndex = 6;
            this.printPreviewActionButton.Text = "Print Preview";
            this.printPreviewActionButton.UseVisualStyleBackColor = false;
            // 
            // PrintUF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(75)))), ((int)(((byte)(138)))));
            this.Controls.Add(this.printPreviewActionButton);
            this.Controls.Add(this.printActionButton);
            this.Name = "PrintUF";
            this.Size = new System.Drawing.Size(1079, 581);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printActionButton;
        private System.Windows.Forms.Button printPreviewActionButton;
    }
}
