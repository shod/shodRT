namespace ShodRT
{
    partial class ShodRT
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
            this.btnHN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHN
            // 
            this.btnHN.Location = new System.Drawing.Point(12, 12);
            this.btnHN.Name = "btnHN";
            this.btnHN.Size = new System.Drawing.Size(75, 23);
            this.btnHN.TabIndex = 0;
            this.btnHN.Text = "HEX->NUM";
            this.btnHN.UseVisualStyleBackColor = true;
            this.btnHN.Click += new System.EventHandler(this.btnHN_Click);
            // 
            // ShodRT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 303);
            this.Controls.Add(this.btnHN);
            this.Name = "ShodRT";
            this.Text = "ShodRT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHN;
    }
}

