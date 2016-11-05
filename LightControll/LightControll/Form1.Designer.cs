namespace LightControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.Button = new System.Windows.Forms.Button();
            this.sperren = new System.Windows.Forms.Label();
            this.sperrPanel = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.check5 = new System.Windows.Forms.CheckBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.check4 = new System.Windows.Forms.CheckBox();
            this.check2 = new System.Windows.Forms.CheckBox();
            this.check3 = new System.Windows.Forms.CheckBox();
            this.Standard = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.sperrPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar1
            // 
            this.Bar1.Location = new System.Drawing.Point(0, 0);
            this.Bar1.Maximum = 264;
            this.Bar1.Name = "Bar1";
            this.Bar1.Size = new System.Drawing.Size(30, 30);
            this.Bar1.TabIndex = 0;
            this.Bar1.Value = 255;
            this.Bar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LED 1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Bar4);
            this.panel1.Location = new System.Drawing.Point(199, 34);
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
            this.Bar4.Value = 255;
            this.Bar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar4_Scroll);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Bar3);
            this.panel2.Location = new System.Drawing.Point(156, 34);
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
            this.Bar3.Value = 255;
            this.Bar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar3_Scroll);
            // 
            // Bar2
            // 
            this.Bar2.Location = new System.Drawing.Point(0, 0);
            this.Bar2.Maximum = 264;
            this.Bar2.Name = "Bar2";
            this.Bar2.Size = new System.Drawing.Size(30, 30);
            this.Bar2.TabIndex = 0;
            this.Bar2.Value = 255;
            this.Bar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar2_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LED 2";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Bar5);
            this.panel3.Location = new System.Drawing.Point(242, 34);
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
            this.Bar5.Value = 255;
            this.Bar5.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar5_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "LED 3";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Bar1);
            this.panel4.Location = new System.Drawing.Point(70, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(32, 32);
            this.panel4.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LED 4";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.Bar2);
            this.panel5.Location = new System.Drawing.Point(113, 34);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(32, 32);
            this.panel5.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 9);
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
            this.Bar6.Value = 255;
            this.Bar6.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Bar6_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "LED 6";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Bar6);
            this.panel6.Location = new System.Drawing.Point(285, 34);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(32, 32);
            this.panel6.TabIndex = 11;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(331, 79);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(89, 29);
            this.Button.TabIndex = 12;
            this.Button.Text = "Auswertung";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.Button_Click);
            // 
            // sperren
            // 
            this.sperren.AutoSize = true;
            this.sperren.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sperren.Location = new System.Drawing.Point(10, 84);
            this.sperren.Name = "sperren";
            this.sperren.Size = new System.Drawing.Size(56, 16);
            this.sperren.TabIndex = 20;
            this.sperren.Text = "Sperren";
            // 
            // sperrPanel
            // 
            this.sperrPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sperrPanel.Controls.Add(this.checkBox2);
            this.sperrPanel.Controls.Add(this.check6);
            this.sperrPanel.Controls.Add(this.check5);
            this.sperrPanel.Controls.Add(this.check1);
            this.sperrPanel.Controls.Add(this.check4);
            this.sperrPanel.Controls.Add(this.check2);
            this.sperrPanel.Controls.Add(this.check3);
            this.sperrPanel.Location = new System.Drawing.Point(70, 79);
            this.sperrPanel.Name = "sperrPanel";
            this.sperrPanel.Size = new System.Drawing.Size(247, 29);
            this.sperrPanel.TabIndex = 20;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(270, 6);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Location = new System.Drawing.Point(223, 7);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(15, 14);
            this.check6.TabIndex = 18;
            this.check6.UseVisualStyleBackColor = true;
            this.check6.CheckedChanged += new System.EventHandler(this.check6_CheckedChanged);
            // 
            // check5
            // 
            this.check5.AutoSize = true;
            this.check5.Location = new System.Drawing.Point(180, 7);
            this.check5.Name = "check5";
            this.check5.Size = new System.Drawing.Size(15, 14);
            this.check5.TabIndex = 18;
            this.check5.UseVisualStyleBackColor = true;
            this.check5.CheckedChanged += new System.EventHandler(this.check5_CheckedChanged);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Location = new System.Drawing.Point(8, 7);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(15, 14);
            this.check1.TabIndex = 14;
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // check4
            // 
            this.check4.AutoSize = true;
            this.check4.Location = new System.Drawing.Point(137, 7);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(15, 14);
            this.check4.TabIndex = 17;
            this.check4.UseVisualStyleBackColor = true;
            this.check4.CheckedChanged += new System.EventHandler(this.check4_CheckedChanged);
            // 
            // check2
            // 
            this.check2.AutoSize = true;
            this.check2.Location = new System.Drawing.Point(51, 7);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(15, 14);
            this.check2.TabIndex = 15;
            this.check2.UseVisualStyleBackColor = true;
            this.check2.CheckedChanged += new System.EventHandler(this.check2_CheckedChanged);
            // 
            // check3
            // 
            this.check3.AutoSize = true;
            this.check3.Location = new System.Drawing.Point(94, 7);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(15, 14);
            this.check3.TabIndex = 16;
            this.check3.UseVisualStyleBackColor = true;
            this.check3.CheckedChanged += new System.EventHandler(this.check3_CheckedChanged);
            // 
            // Standard
            // 
            this.Standard.Location = new System.Drawing.Point(70, 114);
            this.Standard.Name = "Standard";
            this.Standard.Size = new System.Drawing.Size(120, 36);
            this.Standard.TabIndex = 21;
            this.Standard.Text = "Standard für LED 1/6 setzen";
            this.Standard.UseVisualStyleBackColor = true;
            this.Standard.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(199, 114);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(120, 36);
            this.Reset.TabIndex = 22;
            this.Reset.Text = "Alle Werte zurücksetzen";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(394, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(30, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Über";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 153);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Standard);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.sperren);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sperrPanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LightControl";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.sperrPanel.ResumeLayout(false);
            this.sperrPanel.PerformLayout();
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
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label sperren;
        private System.Windows.Forms.Panel sperrPanel;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.CheckBox check5;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.CheckBox check4;
        private System.Windows.Forms.CheckBox check2;
        private System.Windows.Forms.CheckBox check3;
        private System.Windows.Forms.Button Standard;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

