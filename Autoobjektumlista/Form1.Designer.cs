namespace Autoobjektumlista
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_rendszam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_tipus = new System.Windows.Forms.TextBox();
            this.checkBox_Magyar = new System.Windows.Forms.CheckBox();
            this.checkBox_Nemet = new System.Windows.Forms.CheckBox();
            this.checkBox_Angol = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_Kulfoldi = new System.Windows.Forms.CheckBox();
            this.listBox_Autoadatok = new System.Windows.Forms.ListBox();
            this.textBox_teljesitmeny = new System.Windows.Forms.TextBox();
            this.btnRogzit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "rendszam:";
            // 
            // textBox_rendszam
            // 
            this.textBox_rendszam.Location = new System.Drawing.Point(183, 34);
            this.textBox_rendszam.Name = "textBox_rendszam";
            this.textBox_rendszam.Size = new System.Drawing.Size(100, 22);
            this.textBox_rendszam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Típus";
            // 
            // textBox_tipus
            // 
            this.textBox_tipus.Location = new System.Drawing.Point(182, 88);
            this.textBox_tipus.Name = "textBox_tipus";
            this.textBox_tipus.Size = new System.Drawing.Size(100, 22);
            this.textBox_tipus.TabIndex = 3;
            // 
            // checkBox_Magyar
            // 
            this.checkBox_Magyar.AutoSize = true;
            this.checkBox_Magyar.Location = new System.Drawing.Point(64, 162);
            this.checkBox_Magyar.Name = "checkBox_Magyar";
            this.checkBox_Magyar.Size = new System.Drawing.Size(77, 21);
            this.checkBox_Magyar.TabIndex = 4;
            this.checkBox_Magyar.Text = "Magyar";
            this.checkBox_Magyar.UseVisualStyleBackColor = true;
            // 
            // checkBox_Nemet
            // 
            this.checkBox_Nemet.AutoSize = true;
            this.checkBox_Nemet.Location = new System.Drawing.Point(178, 162);
            this.checkBox_Nemet.Name = "checkBox_Nemet";
            this.checkBox_Nemet.Size = new System.Drawing.Size(71, 21);
            this.checkBox_Nemet.TabIndex = 5;
            this.checkBox_Nemet.Text = "Német";
            this.checkBox_Nemet.UseVisualStyleBackColor = true;
            // 
            // checkBox_Angol
            // 
            this.checkBox_Angol.AutoSize = true;
            this.checkBox_Angol.Location = new System.Drawing.Point(291, 162);
            this.checkBox_Angol.Name = "checkBox_Angol";
            this.checkBox_Angol.Size = new System.Drawing.Size(66, 21);
            this.checkBox_Angol.TabIndex = 6;
            this.checkBox_Angol.Text = "Angol";
            this.checkBox_Angol.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Teljesítmény:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gyártmány";
            // 
            // checkBox_Kulfoldi
            // 
            this.checkBox_Kulfoldi.AutoSize = true;
            this.checkBox_Kulfoldi.Location = new System.Drawing.Point(71, 199);
            this.checkBox_Kulfoldi.Name = "checkBox_Kulfoldi";
            this.checkBox_Kulfoldi.Size = new System.Drawing.Size(121, 21);
            this.checkBox_Kulfoldi.TabIndex = 9;
            this.checkBox_Kulfoldi.Text = "külföldi ország";
            this.checkBox_Kulfoldi.UseVisualStyleBackColor = true;
            // 
            // listBox_Autoadatok
            // 
            this.listBox_Autoadatok.FormattingEnabled = true;
            this.listBox_Autoadatok.ItemHeight = 16;
            this.listBox_Autoadatok.Location = new System.Drawing.Point(494, 17);
            this.listBox_Autoadatok.Name = "listBox_Autoadatok";
            this.listBox_Autoadatok.Size = new System.Drawing.Size(235, 356);
            this.listBox_Autoadatok.TabIndex = 10;
            this.listBox_Autoadatok.SelectedIndexChanged += new System.EventHandler(this.listBox_Autoadatok_SelectedIndexChanged);
            // 
            // textBox_teljesitmeny
            // 
            this.textBox_teljesitmeny.Location = new System.Drawing.Point(183, 226);
            this.textBox_teljesitmeny.Name = "textBox_teljesitmeny";
            this.textBox_teljesitmeny.Size = new System.Drawing.Size(100, 22);
            this.textBox_teljesitmeny.TabIndex = 11;
            // 
            // btnRogzit
            // 
            this.btnRogzit.Location = new System.Drawing.Point(150, 337);
            this.btnRogzit.Name = "btnRogzit";
            this.btnRogzit.Size = new System.Drawing.Size(75, 23);
            this.btnRogzit.TabIndex = 12;
            this.btnRogzit.Text = "Rögzítés";
            this.btnRogzit.UseVisualStyleBackColor = true;
            this.btnRogzit.Click += new System.EventHandler(this.btnRogzit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "km/ora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRogzit);
            this.Controls.Add(this.textBox_teljesitmeny);
            this.Controls.Add(this.listBox_Autoadatok);
            this.Controls.Add(this.checkBox_Kulfoldi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_Angol);
            this.Controls.Add(this.checkBox_Nemet);
            this.Controls.Add(this.checkBox_Magyar);
            this.Controls.Add(this.textBox_tipus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_rendszam);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_rendszam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_tipus;
        private System.Windows.Forms.CheckBox checkBox_Magyar;
        private System.Windows.Forms.CheckBox checkBox_Nemet;
        private System.Windows.Forms.CheckBox checkBox_Angol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Kulfoldi;
        private System.Windows.Forms.ListBox listBox_Autoadatok;
        private System.Windows.Forms.TextBox textBox_teljesitmeny;
        private System.Windows.Forms.Button btnRogzit;
        private System.Windows.Forms.Label label5;
    }
}

