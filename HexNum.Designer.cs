namespace ShodRT
{
    partial class HexNum
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
            this.txtH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnHB = new System.Windows.Forms.Button();
            this.btnNH = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAscii = new System.Windows.Forms.TextBox();
            this.lblAsciiHex = new System.Windows.Forms.Label();
            this.txtAsciiHex = new System.Windows.Forms.TextBox();
            this.btnAH = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFloat = new System.Windows.Forms.TextBox();
            this.btnHF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(45, 27);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(235, 20);
            this.txtH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hex";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Num";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(45, 77);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(235, 20);
            this.txtN.TabIndex = 1;
            // 
            // btnHB
            // 
            this.btnHB.Location = new System.Drawing.Point(16, 179);
            this.btnHB.Name = "btnHB";
            this.btnHB.Size = new System.Drawing.Size(75, 23);
            this.btnHB.TabIndex = 2;
            this.btnHB.Text = "Hex->Num";
            this.btnHB.UseVisualStyleBackColor = true;
            this.btnHB.Click += new System.EventHandler(this.btnHB_Click);
            // 
            // btnNH
            // 
            this.btnNH.Location = new System.Drawing.Point(204, 179);
            this.btnNH.Name = "btnNH";
            this.btnNH.Size = new System.Drawing.Size(75, 23);
            this.btnNH.TabIndex = 4;
            this.btnNH.Text = "Num->Hex";
            this.btnNH.UseVisualStyleBackColor = true;
            this.btnNH.Click += new System.EventHandler(this.btnNH_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ascii";
            // 
            // txtAscii
            // 
            this.txtAscii.Location = new System.Drawing.Point(45, 224);
            this.txtAscii.Name = "txtAscii";
            this.txtAscii.Size = new System.Drawing.Size(235, 20);
            this.txtAscii.TabIndex = 5;
            // 
            // lblAsciiHex
            // 
            this.lblAsciiHex.AutoSize = true;
            this.lblAsciiHex.Location = new System.Drawing.Point(13, 275);
            this.lblAsciiHex.Name = "lblAsciiHex";
            this.lblAsciiHex.Size = new System.Drawing.Size(26, 13);
            this.lblAsciiHex.TabIndex = 8;
            this.lblAsciiHex.Text = "Hex";
            // 
            // txtAsciiHex
            // 
            this.txtAsciiHex.Location = new System.Drawing.Point(45, 272);
            this.txtAsciiHex.Name = "txtAsciiHex";
            this.txtAsciiHex.Size = new System.Drawing.Size(235, 20);
            this.txtAsciiHex.TabIndex = 7;
            // 
            // btnAH
            // 
            this.btnAH.Location = new System.Drawing.Point(45, 315);
            this.btnAH.Name = "btnAH";
            this.btnAH.Size = new System.Drawing.Size(75, 23);
            this.btnAH.TabIndex = 9;
            this.btnAH.Text = "Ascii->Hex";
            this.btnAH.UseVisualStyleBackColor = true;
            this.btnAH.Click += new System.EventHandler(this.btnAH_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Float";
            // 
            // txtFloat
            // 
            this.txtFloat.Location = new System.Drawing.Point(44, 127);
            this.txtFloat.Name = "txtFloat";
            this.txtFloat.Size = new System.Drawing.Size(235, 20);
            this.txtFloat.TabIndex = 10;
            // 
            // btnHF
            // 
            this.btnHF.Location = new System.Drawing.Point(115, 179);
            this.btnHF.Name = "btnHF";
            this.btnHF.Size = new System.Drawing.Size(75, 23);
            this.btnHF.TabIndex = 12;
            this.btnHF.Text = "Hex->Float";
            this.btnHF.UseVisualStyleBackColor = true;
            this.btnHF.Click += new System.EventHandler(this.btnHF_Click);
            // 
            // HexNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 443);
            this.Controls.Add(this.btnHF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFloat);
            this.Controls.Add(this.btnAH);
            this.Controls.Add(this.lblAsciiHex);
            this.Controls.Add(this.txtAsciiHex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAscii);
            this.Controls.Add(this.btnNH);
            this.Controls.Add(this.btnHB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtH);
            this.Name = "HexNum";
            this.Text = "HexNum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button btnHB;
        private System.Windows.Forms.Button btnNH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAscii;
        private System.Windows.Forms.Label lblAsciiHex;
        private System.Windows.Forms.TextBox txtAsciiHex;
        private System.Windows.Forms.Button btnAH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFloat;
        private System.Windows.Forms.Button btnHF;
    }
}