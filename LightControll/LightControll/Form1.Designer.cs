﻿namespace LightControl
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bar4 = new System.Windows.Forms.VScrollBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bar3 = new System.Windows.Forms.VScrollBar();
            this.Bar2 = new System.Windows.Forms.VScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Bar5 = new System.Windows.Forms.VScrollBar();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Bar6 = new System.Windows.Forms.VScrollBar();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar1
            // 
            this.Bar1.Location = new System.Drawing.Point(0, 0);
            this.Bar1.Maximum = 264;
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(30, 30);
            this.Bar1.TabIndex = 0;
            this.Bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LED 1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Bar4);
            this.panel1.Location = new System.Drawing.Point(169, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 32);
            this.panel1.TabIndex = 2;
            // 
            // Bar4
            // 
            this.Bar4.Location = new System.Drawing.Point(0, 1);
            this.Bar4.Maximum = 264;
            this.Bar4.Name = "Bar4";
            this.Bar4.Size = new System.Drawing.Size(30, 30);
            this.Bar4.TabIndex = 0;
            this.Bar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar4_Scroll);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Bar3);
            this.panel2.Location = new System.Drawing.Point(126, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 32);
            this.panel2.TabIndex = 4;
            // 
            // Bar3
            // 
            this.Bar3.Location = new System.Drawing.Point(0, 0);
            this.Bar3.Maximum = 264;
            this.Bar3.Name = "Bar3";
            this.Bar3.Size = new System.Drawing.Size(30, 30);
            this.Bar3.TabIndex = 0;
            this.Bar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar3_Scroll);
            // 
            // Bar2
            // 
            this.Bar2.Location = new System.Drawing.Point(0, 0);
            this.Bar2.Maximum = 264;
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(30, 30);
            this.Bar2.TabIndex = 0;
            this.Bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LED 2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Bar5);
            this.panel3.Location = new System.Drawing.Point(212, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(32, 32);
            this.panel3.TabIndex = 6;
            // 
            // Bar5
            // 
            this.Bar5.Location = new System.Drawing.Point(0, -1);
            this.Bar5.Maximum = 264;
            this.Bar5.Name = "Bar5";
            this.Bar5.Size = new System.Drawing.Size(30, 30);
            this.Bar5.TabIndex = 0;
            this.Bar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar5_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LED 3";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Bar1);
            this.panel4.Location = new System.Drawing.Point(40, 79);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LED 4";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Bar2);
            this.panel5.Location = new System.Drawing.Point(83, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 32);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "LED 5";
            // 
            // Bar6
            // 
            this.Bar6.Location = new System.Drawing.Point(0, 0);
            this.Bar6.Maximum = 264;
            this.Bar6.Name = "Bar6";
            this.Bar6.Size = new System.Drawing.Size(30, 30);
            this.Bar6.TabIndex = 9;
            this.Bar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar6_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(252, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "LED 6";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Bar6);
            this.panel6.Location = new System.Drawing.Point(255, 79);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(32, 32);
            this.panel6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 164);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar Bar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.VScrollBar Bar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.VScrollBar Bar3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.VScrollBar Bar4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.VScrollBar Bar5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.VScrollBar Bar6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
    }
}

