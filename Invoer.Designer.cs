namespace Opdracht5Oefening2
{
    partial class Invoer
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
            this.lbWaarde = new System.Windows.Forms.Label();
            this.tbWaarde = new System.Windows.Forms.TextBox();
            this.btWaarde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWaarde
            // 
            this.lbWaarde.AutoSize = true;
            this.lbWaarde.Location = new System.Drawing.Point(176, 100);
            this.lbWaarde.Name = "lbWaarde";
            this.lbWaarde.Size = new System.Drawing.Size(47, 15);
            this.lbWaarde.TabIndex = 0;
            this.lbWaarde.Text = "Waarde";
            // 
            // tbWaarde
            // 
            this.tbWaarde.Location = new System.Drawing.Point(144, 132);
            this.tbWaarde.Name = "tbWaarde";
            this.tbWaarde.Size = new System.Drawing.Size(100, 23);
            this.tbWaarde.TabIndex = 1;
            // 
            // btWaarde
            // 
            this.btWaarde.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btWaarde.Location = new System.Drawing.Point(158, 175);
            this.btWaarde.Name = "btWaarde";
            this.btWaarde.Size = new System.Drawing.Size(75, 23);
            this.btWaarde.TabIndex = 2;
            this.btWaarde.Text = "Ok";
            this.btWaarde.UseVisualStyleBackColor = true;
            this.btWaarde.Click += new System.EventHandler(this.btWaarde_Click);
            // 
            // Invoer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btWaarde);
            this.Controls.Add(this.tbWaarde);
            this.Controls.Add(this.lbWaarde);
            this.Name = "Invoer";
            this.Text = "Invoer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWaarde;
        private System.Windows.Forms.TextBox tbWaarde;
        private System.Windows.Forms.Button btWaarde;
    }
}