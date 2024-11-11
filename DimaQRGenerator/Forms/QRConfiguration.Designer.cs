namespace DimaQRGenerator.Forms
{
    partial class QRConfiguration
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
            this.comboBox_ecc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_eci_mode = new System.Windows.Forms.ComboBox();
            this.button_dark_qr = new System.Windows.Forms.Button();
            this.button_light_qr = new System.Windows.Forms.Button();
            this.numericUpDown_pixel_per_module = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_quiet_zone = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pixel_per_module)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nivel de Corrección de error";
            // 
            // comboBox_ecc
            // 
            this.comboBox_ecc.FormattingEnabled = true;
            this.comboBox_ecc.Location = new System.Drawing.Point(170, 10);
            this.comboBox_ecc.Name = "comboBox_ecc";
            this.comboBox_ecc.Size = new System.Drawing.Size(108, 21);
            this.comboBox_ecc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color Oscuro (Los rectángulos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color Claro (Fondo)";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Forzar UTF8";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Modo ECI";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.checkBox_quiet_zone);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_pixel_per_module);
            this.groupBox1.Controls.Add(this.comboBox_eci_mode);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(284, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 93);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Avanzado";
            // 
            // comboBox_eci_mode
            // 
            this.comboBox_eci_mode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_eci_mode.FormattingEnabled = true;
            this.comboBox_eci_mode.Location = new System.Drawing.Point(66, 16);
            this.comboBox_eci_mode.Name = "comboBox_eci_mode";
            this.comboBox_eci_mode.Size = new System.Drawing.Size(184, 21);
            this.comboBox_eci_mode.TabIndex = 9;
            // 
            // button_dark_qr
            // 
            this.button_dark_qr.Location = new System.Drawing.Point(170, 37);
            this.button_dark_qr.Name = "button_dark_qr";
            this.button_dark_qr.Size = new System.Drawing.Size(108, 23);
            this.button_dark_qr.TabIndex = 9;
            this.button_dark_qr.Text = "Color QR";
            this.button_dark_qr.UseVisualStyleBackColor = true;
            // 
            // button_light_qr
            // 
            this.button_light_qr.Location = new System.Drawing.Point(170, 66);
            this.button_light_qr.Name = "button_light_qr";
            this.button_light_qr.Size = new System.Drawing.Size(108, 23);
            this.button_light_qr.TabIndex = 10;
            this.button_light_qr.Text = "Color Fondo";
            this.button_light_qr.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_pixel_per_module
            // 
            this.numericUpDown_pixel_per_module.Location = new System.Drawing.Point(157, 43);
            this.numericUpDown_pixel_per_module.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_pixel_per_module.Name = "numericUpDown_pixel_per_module";
            this.numericUpDown_pixel_per_module.Size = new System.Drawing.Size(93, 20);
            this.numericUpDown_pixel_per_module.TabIndex = 10;
            this.numericUpDown_pixel_per_module.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "PPM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBox_quiet_zone
            // 
            this.checkBox_quiet_zone.AutoSize = true;
            this.checkBox_quiet_zone.Checked = true;
            this.checkBox_quiet_zone.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_quiet_zone.Location = new System.Drawing.Point(6, 44);
            this.checkBox_quiet_zone.Name = "checkBox_quiet_zone";
            this.checkBox_quiet_zone.Size = new System.Drawing.Size(79, 17);
            this.checkBox_quiet_zone.TabIndex = 12;
            this.checkBox_quiet_zone.Text = "Quiet Zone";
            this.checkBox_quiet_zone.UseVisualStyleBackColor = true;
            // 
            // QRConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 115);
            this.Controls.Add(this.button_light_qr);
            this.Controls.Add(this.button_dark_qr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_ecc);
            this.Controls.Add(this.label1);
            this.Name = "QRConfiguration";
            this.Text = "QRConfiguration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_pixel_per_module)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_ecc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_eci_mode;
        private System.Windows.Forms.Button button_dark_qr;
        private System.Windows.Forms.Button button_light_qr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_pixel_per_module;
        private System.Windows.Forms.CheckBox checkBox_quiet_zone;
    }
}