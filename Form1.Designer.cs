namespace CiscoConfigGeneratorTest01
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
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_pos3 = new System.Windows.Forms.TextBox();
            this.txt_pos2 = new System.Windows.Forms.TextBox();
            this.txt_pos1 = new System.Windows.Forms.TextBox();
            this.txt_prefix = new System.Windows.Forms.TextBox();
            this.lbx_portranges = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_lbxsave = new System.Windows.Forms.Button();
            this.btn_lbxrem = new System.Windows.Forms.Button();
            this.Liste = new System.Windows.Forms.GroupBox();
            this.btn_clearlbx = new System.Windows.Forms.Button();
            this.txt_pos4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbx_normal = new System.Windows.Forms.RadioButton();
            this.rbx_ap = new System.Windows.Forms.RadioButton();
            this.Liste.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(46, 318);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(265, 52);
            this.btn_generate.TabIndex = 10;
            this.btn_generate.Text = "Generate new Config";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_pos3
            // 
            this.txt_pos3.Location = new System.Drawing.Point(169, 19);
            this.txt_pos3.Name = "txt_pos3";
            this.txt_pos3.Size = new System.Drawing.Size(34, 20);
            this.txt_pos3.TabIndex = 4;
            this.txt_pos3.Text = "1";
            this.txt_pos3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // txt_pos2
            // 
            this.txt_pos2.Location = new System.Drawing.Point(111, 19);
            this.txt_pos2.Name = "txt_pos2";
            this.txt_pos2.Size = new System.Drawing.Size(34, 20);
            this.txt_pos2.TabIndex = 3;
            this.txt_pos2.Text = "0";
            this.txt_pos2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // txt_pos1
            // 
            this.txt_pos1.Location = new System.Drawing.Point(53, 19);
            this.txt_pos1.Name = "txt_pos1";
            this.txt_pos1.Size = new System.Drawing.Size(34, 20);
            this.txt_pos1.TabIndex = 2;
            this.txt_pos1.Text = "1";
            this.txt_pos1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // txt_prefix
            // 
            this.txt_prefix.Location = new System.Drawing.Point(13, 19);
            this.txt_prefix.Name = "txt_prefix";
            this.txt_prefix.Size = new System.Drawing.Size(34, 20);
            this.txt_prefix.TabIndex = 1;
            this.txt_prefix.Text = "Gi";
            this.txt_prefix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lbx_portranges
            // 
            this.lbx_portranges.FormattingEnabled = true;
            this.lbx_portranges.Location = new System.Drawing.Point(12, 97);
            this.lbx_portranges.Name = "lbx_portranges";
            this.lbx_portranges.Size = new System.Drawing.Size(151, 199);
            this.lbx_portranges.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "/";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "/";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_lbxsave
            // 
            this.btn_lbxsave.Location = new System.Drawing.Point(6, 19);
            this.btn_lbxsave.Name = "btn_lbxsave";
            this.btn_lbxsave.Size = new System.Drawing.Size(141, 23);
            this.btn_lbxsave.TabIndex = 6;
            this.btn_lbxsave.Text = "Save";
            this.btn_lbxsave.UseVisualStyleBackColor = true;
            this.btn_lbxsave.Click += new System.EventHandler(this.btn_lbxsave_Click);
            // 
            // btn_lbxrem
            // 
            this.btn_lbxrem.Location = new System.Drawing.Point(6, 48);
            this.btn_lbxrem.Name = "btn_lbxrem";
            this.btn_lbxrem.Size = new System.Drawing.Size(141, 23);
            this.btn_lbxrem.TabIndex = 11;
            this.btn_lbxrem.Text = "Remove";
            this.btn_lbxrem.UseVisualStyleBackColor = true;
            this.btn_lbxrem.Click += new System.EventHandler(this.btn_lbxrem_Click);
            // 
            // Liste
            // 
            this.Liste.Controls.Add(this.btn_lbxsave);
            this.Liste.Controls.Add(this.btn_clearlbx);
            this.Liste.Controls.Add(this.btn_lbxrem);
            this.Liste.Location = new System.Drawing.Point(187, 97);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(153, 131);
            this.Liste.TabIndex = 13;
            this.Liste.TabStop = false;
            this.Liste.Text = "Liste";
            // 
            // btn_clearlbx
            // 
            this.btn_clearlbx.Location = new System.Drawing.Point(6, 98);
            this.btn_clearlbx.Name = "btn_clearlbx";
            this.btn_clearlbx.Size = new System.Drawing.Size(141, 23);
            this.btn_clearlbx.TabIndex = 11;
            this.btn_clearlbx.Text = "Clear";
            this.btn_clearlbx.UseVisualStyleBackColor = true;
            this.btn_clearlbx.Click += new System.EventHandler(this.btn_clearlbx_Click);
            // 
            // txt_pos4
            // 
            this.txt_pos4.Location = new System.Drawing.Point(251, 19);
            this.txt_pos4.Name = "txt_pos4";
            this.txt_pos4.Size = new System.Drawing.Size(34, 20);
            this.txt_pos4.TabIndex = 5;
            this.txt_pos4.Text = "1";
            this.txt_pos4.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_pos4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "-";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_prefix);
            this.groupBox1.Controls.Add(this.txt_pos4);
            this.groupBox1.Controls.Add(this.txt_pos3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_pos2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_pos1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 79);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "z.B. Gi1/0/1-10 oder Gi0/null/1-10";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbx_ap);
            this.gb.Controls.Add(this.rbx_normal);
            this.gb.Location = new System.Drawing.Point(187, 234);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(153, 62);
            this.gb.TabIndex = 15;
            this.gb.TabStop = false;
            this.gb.Text = "Art wählen";
            // 
            // rbx_normal
            // 
            this.rbx_normal.AutoSize = true;
            this.rbx_normal.Checked = true;
            this.rbx_normal.Location = new System.Drawing.Point(39, 19);
            this.rbx_normal.Name = "rbx_normal";
            this.rbx_normal.Size = new System.Drawing.Size(58, 17);
            this.rbx_normal.TabIndex = 0;
            this.rbx_normal.TabStop = true;
            this.rbx_normal.Text = "Normal";
            this.rbx_normal.UseVisualStyleBackColor = true;
            this.rbx_normal.CheckedChanged += new System.EventHandler(this.rbx_normal_CheckedChanged);
            // 
            // rbx_ap
            // 
            this.rbx_ap.AutoSize = true;
            this.rbx_ap.Location = new System.Drawing.Point(39, 42);
            this.rbx_ap.Name = "rbx_ap";
            this.rbx_ap.Size = new System.Drawing.Size(87, 17);
            this.rbx_ap.TabIndex = 1;
            this.rbx_ap.Text = "Access Point";
            this.rbx_ap.UseVisualStyleBackColor = true;
            this.rbx_ap.CheckedChanged += new System.EventHandler(this.rbx_ap_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 382);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.lbx_portranges);
            this.Controls.Add(this.btn_generate);
            this.Name = "Form1";
            this.Text = "ConfigGenerator Generelle Ports";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Liste.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_pos3;
        private System.Windows.Forms.TextBox txt_pos2;
        private System.Windows.Forms.TextBox txt_pos1;
        private System.Windows.Forms.TextBox txt_prefix;
        private System.Windows.Forms.ListBox lbx_portranges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_lbxsave;
        private System.Windows.Forms.Button btn_lbxrem;
        private System.Windows.Forms.GroupBox Liste;
        private System.Windows.Forms.TextBox txt_pos4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_clearlbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbx_ap;
        private System.Windows.Forms.RadioButton rbx_normal;
    }
}

