namespace Opdracht5Oefening2
{
    partial class Gemidemlde
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
            this.lbGemidelde = new System.Windows.Forms.ListBox();
            this.btGetal = new System.Windows.Forms.Button();
            this.tbAvg = new System.Windows.Forms.TextBox();
            this.lbAvg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbGemidelde
            // 
            this.lbGemidelde.FormattingEnabled = true;
            this.lbGemidelde.ItemHeight = 15;
            this.lbGemidelde.Location = new System.Drawing.Point(70, 12);
            this.lbGemidelde.Name = "lbGemidelde";
            this.lbGemidelde.Size = new System.Drawing.Size(120, 94);
            this.lbGemidelde.TabIndex = 0;
            // 
            // btGetal
            // 
            this.btGetal.Location = new System.Drawing.Point(211, 83);
            this.btGetal.Name = "btGetal";
            this.btGetal.Size = new System.Drawing.Size(100, 23);
            this.btGetal.TabIndex = 1;
            this.btGetal.Text = "Nieuwe getal";
            this.btGetal.UseVisualStyleBackColor = true;
            this.btGetal.Click += new System.EventHandler(this.btGetal_Click);
            // 
            // tbAvg
            // 
            this.tbAvg.Location = new System.Drawing.Point(211, 41);
            this.tbAvg.Name = "tbAvg";
            this.tbAvg.Size = new System.Drawing.Size(100, 23);
            this.tbAvg.TabIndex = 2;
            // 
            // lbAvg
            // 
            this.lbAvg.AutoSize = true;
            this.lbAvg.Location = new System.Drawing.Point(223, 12);
            this.lbAvg.Name = "lbAvg";
            this.lbAvg.Size = new System.Drawing.Size(71, 15);
            this.lbAvg.TabIndex = 3;
            this.lbAvg.Text = "Gemiddelde";
            // 
            // Gemidemlde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbAvg);
            this.Controls.Add(this.tbAvg);
            this.Controls.Add(this.btGetal);
            this.Controls.Add(this.lbGemidelde);
            this.Name = "Gemidemlde";
            this.Text = "Gemidemlde";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbGemidelde;
        private System.Windows.Forms.Button btGetal;
        private System.Windows.Forms.TextBox tbAvg;
        private System.Windows.Forms.Label lbAvg;
    }
}