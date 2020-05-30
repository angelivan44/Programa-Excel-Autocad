namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.CajBox = new System.Windows.Forms.CheckBox();
            this.LumBox = new System.Windows.Forms.CheckBox();
            this.SedBox = new System.Windows.Forms.CheckBox();
            this.VanosBox = new System.Windows.Forms.CheckBox();
            this.Postesbox = new System.Windows.Forms.CheckBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.CajBox);
            this.panel1.Controls.Add(this.LumBox);
            this.panel1.Controls.Add(this.SedBox);
            this.panel1.Controls.Add(this.VanosBox);
            this.panel1.Controls.Add(this.Postesbox);
            this.panel1.Location = new System.Drawing.Point(251, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 204);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reporte";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconSize = 92;
            this.iconPictureBox1.Location = new System.Drawing.Point(29, 81);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(106, 92);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // CajBox
            // 
            this.CajBox.AutoSize = true;
            this.CajBox.Checked = true;
            this.CajBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CajBox.Location = new System.Drawing.Point(159, 170);
            this.CajBox.Name = "CajBox";
            this.CajBox.Size = new System.Drawing.Size(69, 17);
            this.CajBox.TabIndex = 4;
            this.CajBox.Text = "Cajetines";
            this.CajBox.UseVisualStyleBackColor = true;
            // 
            // LumBox
            // 
            this.LumBox.AutoSize = true;
            this.LumBox.Checked = true;
            this.LumBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LumBox.Location = new System.Drawing.Point(159, 147);
            this.LumBox.Name = "LumBox";
            this.LumBox.Size = new System.Drawing.Size(76, 17);
            this.LumBox.TabIndex = 3;
            this.LumBox.Text = "Luminarias";
            this.LumBox.UseVisualStyleBackColor = true;
            // 
            // SedBox
            // 
            this.SedBox.AutoSize = true;
            this.SedBox.Checked = true;
            this.SedBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SedBox.Location = new System.Drawing.Point(159, 121);
            this.SedBox.Name = "SedBox";
            this.SedBox.Size = new System.Drawing.Size(96, 17);
            this.SedBox.TabIndex = 2;
            this.SedBox.Text = "Subestaciones";
            this.SedBox.UseVisualStyleBackColor = true;
            // 
            // VanosBox
            // 
            this.VanosBox.AutoSize = true;
            this.VanosBox.Checked = true;
            this.VanosBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.VanosBox.Location = new System.Drawing.Point(159, 98);
            this.VanosBox.Name = "VanosBox";
            this.VanosBox.Size = new System.Drawing.Size(56, 17);
            this.VanosBox.TabIndex = 1;
            this.VanosBox.Text = "Vanos";
            this.VanosBox.UseVisualStyleBackColor = true;
            // 
            // Postesbox
            // 
            this.Postesbox.AutoSize = true;
            this.Postesbox.Checked = true;
            this.Postesbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Postesbox.Location = new System.Drawing.Point(159, 75);
            this.Postesbox.Name = "Postesbox";
            this.Postesbox.Size = new System.Drawing.Size(58, 17);
            this.Postesbox.TabIndex = 0;
            this.Postesbox.Text = "Postes";
            this.Postesbox.UseVisualStyleBackColor = true;
            this.Postesbox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(52, 59);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(149, 61);
            this.iconButton1.TabIndex = 6;
            this.iconButton1.Text = "Base de Datos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconSize = 50;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(52, 156);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Rotation = 0D;
            this.iconButton2.Size = new System.Drawing.Size(149, 57);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Configuración";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.Enabled = false;
            this.iconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.CaretSquareRight;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconSize = 50;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(379, 284);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Rotation = 0D;
            this.iconButton3.Size = new System.Drawing.Size(120, 57);
            this.iconButton3.TabIndex = 8;
            this.iconButton3.Text = "EJECUTAR";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 356);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CajBox;
        private System.Windows.Forms.CheckBox LumBox;
        private System.Windows.Forms.CheckBox SedBox;
        private System.Windows.Forms.CheckBox VanosBox;
        private System.Windows.Forms.CheckBox Postesbox;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

