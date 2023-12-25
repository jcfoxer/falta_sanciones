namespace uso_de_radio_button_y_chekbutton
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt3);
            this.groupBox1.Controls.Add(this.rbt2);
            this.groupBox1.Controls.Add(this.rbt1);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "como desea pedir el pedido ";
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(68, 36);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(134, 17);
            this.rbt1.TabIndex = 0;
            this.rbt1.Text = "por correo normal [$50]";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(68, 77);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(140, 17);
            this.rbt2.TabIndex = 1;
            this.rbt2.Text = "por correo normal [$100]";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Checked = true;
            this.rbt3.Location = new System.Drawing.Point(68, 122);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(140, 17);
            this.rbt3.TabIndex = 2;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "por correo normal [$150]";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk3);
            this.groupBox2.Controls.Add(this.chk2);
            this.groupBox2.Controls.Add(this.chk1);
            this.groupBox2.Location = new System.Drawing.Point(170, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(596, 137);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "como desea recibir el pedido";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Checked = true;
            this.chk1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1.Location = new System.Drawing.Point(28, 41);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(80, 17);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "por email[5]";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Checked = true;
            this.chk2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2.Location = new System.Drawing.Point(28, 64);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(86, 17);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "por email[15]";
            this.chk2.UseVisualStyleBackColor = true;
            this.chk2.CheckedChanged += new System.EventHandler(this.chk2_CheckedChanged);
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Checked = true;
            this.chk3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3.Location = new System.Drawing.Point(28, 87);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(86, 17);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "por email[20]";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(784, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 128);
            this.button1.TabIndex = 2;
            this.button1.Text = "calculart gastos de envio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.Button button1;
    }
}

