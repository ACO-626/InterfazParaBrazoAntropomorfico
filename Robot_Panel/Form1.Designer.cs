
namespace Robot_Panel
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelTipo = new System.Windows.Forms.Label();
            this.comboBTipo = new System.Windows.Forms.ComboBox();
            this.labelPuntoInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelmm1 = new System.Windows.Forms.Label();
            this.labelmm2 = new System.Windows.Forms.Label();
            this.labelmm4 = new System.Windows.Forms.Label();
            this.labelmm3 = new System.Windows.Forms.Label();
            this.labelSimpleVistaPrevia = new System.Windows.Forms.Label();
            this.panelCanvas = new System.Windows.Forms.Panel();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturePReference01 = new System.Windows.Forms.PictureBox();
            this.picturePReference2 = new System.Windows.Forms.PictureBox();
            this.btnVisualizar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBRowHX = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelSimpleO = new System.Windows.Forms.Label();
            this.labelSimpleX = new System.Windows.Forms.Label();
            this.labelSimpleY = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbConsoleMensaje = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePReference01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePReference2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBRowHX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTipo.Location = new System.Drawing.Point(54, 140);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(125, 23);
            this.labelTipo.TabIndex = 0;
            this.labelTipo.Text = "Tipo de trazo";
            // 
            // comboBTipo
            // 
            this.comboBTipo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBTipo.CausesValidation = false;
            this.comboBTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBTipo.FormattingEnabled = true;
            this.comboBTipo.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.comboBTipo.Location = new System.Drawing.Point(64, 167);
            this.comboBTipo.Name = "comboBTipo";
            this.comboBTipo.Size = new System.Drawing.Size(267, 26);
            this.comboBTipo.TabIndex = 1;
            this.comboBTipo.SelectedIndexChanged += new System.EventHandler(this.comboBTipo_SelectedIndexChanged);
            // 
            // labelPuntoInicio
            // 
            this.labelPuntoInicio.AutoSize = true;
            this.labelPuntoInicio.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPuntoInicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPuntoInicio.Location = new System.Drawing.Point(54, 229);
            this.labelPuntoInicio.Name = "labelPuntoInicio";
            this.labelPuntoInicio.Size = new System.Drawing.Size(252, 23);
            this.labelPuntoInicio.TabIndex = 2;
            this.labelPuntoInicio.Text = "Punto de inicio del trazp (P)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(64, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Punto de fin del trazp (P\')";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxX1.Location = new System.Drawing.Point(64, 262);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(90, 26);
            this.textBoxX1.TabIndex = 4;
            // 
            // textBoxY1
            // 
            this.textBoxY1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxY1.Location = new System.Drawing.Point(241, 262);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(90, 26);
            this.textBoxY1.TabIndex = 5;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxX2.Location = new System.Drawing.Point(64, 370);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(90, 26);
            this.textBoxX2.TabIndex = 6;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxY2.Location = new System.Drawing.Point(241, 370);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(90, 26);
            this.textBoxY2.TabIndex = 7;
            // 
            // labelmm1
            // 
            this.labelmm1.AutoSize = true;
            this.labelmm1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmm1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelmm1.Location = new System.Drawing.Point(160, 270);
            this.labelmm1.Name = "labelmm1";
            this.labelmm1.Size = new System.Drawing.Size(57, 18);
            this.labelmm1.TabIndex = 8;
            this.labelmm1.Text = "X [mm]";
            // 
            // labelmm2
            // 
            this.labelmm2.AutoSize = true;
            this.labelmm2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmm2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelmm2.Location = new System.Drawing.Point(337, 270);
            this.labelmm2.Name = "labelmm2";
            this.labelmm2.Size = new System.Drawing.Size(55, 18);
            this.labelmm2.TabIndex = 9;
            this.labelmm2.Text = "Y [mm]";
            // 
            // labelmm4
            // 
            this.labelmm4.AutoSize = true;
            this.labelmm4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmm4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelmm4.Location = new System.Drawing.Point(337, 378);
            this.labelmm4.Name = "labelmm4";
            this.labelmm4.Size = new System.Drawing.Size(55, 18);
            this.labelmm4.TabIndex = 10;
            this.labelmm4.Text = "Y [mm]";
            // 
            // labelmm3
            // 
            this.labelmm3.AutoSize = true;
            this.labelmm3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelmm3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelmm3.Location = new System.Drawing.Point(160, 378);
            this.labelmm3.Name = "labelmm3";
            this.labelmm3.Size = new System.Drawing.Size(57, 18);
            this.labelmm3.TabIndex = 11;
            this.labelmm3.Text = "X [mm]";
            // 
            // labelSimpleVistaPrevia
            // 
            this.labelSimpleVistaPrevia.AutoSize = true;
            this.labelSimpleVistaPrevia.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSimpleVistaPrevia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleVistaPrevia.Location = new System.Drawing.Point(860, 91);
            this.labelSimpleVistaPrevia.Name = "labelSimpleVistaPrevia";
            this.labelSimpleVistaPrevia.Size = new System.Drawing.Size(113, 23);
            this.labelSimpleVistaPrevia.TabIndex = 12;
            this.labelSimpleVistaPrevia.Text = "Vista previa";
            // 
            // panelCanvas
            // 
            this.panelCanvas.BackColor = System.Drawing.Color.White;
            this.panelCanvas.Location = new System.Drawing.Point(643, 128);
            this.panelCanvas.Name = "panelCanvas";
            this.panelCanvas.Size = new System.Drawing.Size(330, 420);
            this.panelCanvas.TabIndex = 13;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Location = new System.Drawing.Point(643, 566);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(89, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.vistaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // vistaToolStripMenuItem
            // 
            this.vistaToolStripMenuItem.Name = "vistaToolStripMenuItem";
            this.vistaToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.vistaToolStripMenuItem.Text = "Vista";
            // 
            // picturePReference01
            // 
            this.picturePReference01.Image = ((System.Drawing.Image)(resources.GetObject("picturePReference01.Image")));
            this.picturePReference01.Location = new System.Drawing.Point(420, 210);
            this.picturePReference01.Name = "picturePReference01";
            this.picturePReference01.Size = new System.Drawing.Size(142, 77);
            this.picturePReference01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePReference01.TabIndex = 16;
            this.picturePReference01.TabStop = false;
            // 
            // picturePReference2
            // 
            this.picturePReference2.Image = ((System.Drawing.Image)(resources.GetObject("picturePReference2.Image")));
            this.picturePReference2.Location = new System.Drawing.Point(420, 318);
            this.picturePReference2.Name = "picturePReference2";
            this.picturePReference2.Size = new System.Drawing.Size(142, 77);
            this.picturePReference2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePReference2.TabIndex = 17;
            this.picturePReference2.TabStop = false;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnVisualizar.Image")));
            this.btnVisualizar.Location = new System.Drawing.Point(131, 473);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(159, 89);
            this.btnVisualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVisualizar.TabIndex = 18;
            this.btnVisualizar.TabStop = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 473);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBRowHX
            // 
            this.pictureBRowHX.Image = ((System.Drawing.Image)(resources.GetObject("pictureBRowHX.Image")));
            this.pictureBRowHX.Location = new System.Drawing.Point(643, 103);
            this.pictureBRowHX.Name = "pictureBRowHX";
            this.pictureBRowHX.Size = new System.Drawing.Size(99, 21);
            this.pictureBRowHX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBRowHX.TabIndex = 20;
            this.pictureBRowHX.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(616, 128);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // labelSimpleO
            // 
            this.labelSimpleO.AutoSize = true;
            this.labelSimpleO.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSimpleO.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleO.Location = new System.Drawing.Point(616, 103);
            this.labelSimpleO.Name = "labelSimpleO";
            this.labelSimpleO.Size = new System.Drawing.Size(26, 23);
            this.labelSimpleO.TabIndex = 22;
            this.labelSimpleO.Text = "O";
            // 
            // labelSimpleX
            // 
            this.labelSimpleX.AutoSize = true;
            this.labelSimpleX.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSimpleX.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleX.Location = new System.Drawing.Point(737, 102);
            this.labelSimpleX.Name = "labelSimpleX";
            this.labelSimpleX.Size = new System.Drawing.Size(23, 23);
            this.labelSimpleX.TabIndex = 23;
            this.labelSimpleX.Text = "X";
            // 
            // labelSimpleY
            // 
            this.labelSimpleY.AutoSize = true;
            this.labelSimpleY.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSimpleY.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelSimpleY.Location = new System.Drawing.Point(616, 232);
            this.labelSimpleY.Name = "labelSimpleY";
            this.labelSimpleY.Size = new System.Drawing.Size(24, 23);
            this.labelSimpleY.TabIndex = 24;
            this.labelSimpleY.Text = "Y";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(875, 554);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(979, 460);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(17, 88);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // lbConsoleMensaje
            // 
            this.lbConsoleMensaje.AutoSize = true;
            this.lbConsoleMensaje.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbConsoleMensaje.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbConsoleMensaje.Location = new System.Drawing.Point(643, 66);
            this.lbConsoleMensaje.Name = "lbConsoleMensaje";
            this.lbConsoleMensaje.Size = new System.Drawing.Size(54, 15);
            this.lbConsoleMensaje.TabIndex = 28;
            this.lbConsoleMensaje.Text = "Mensaje";
            this.lbConsoleMensaje.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1006, 633);
            this.Controls.Add(this.lbConsoleMensaje);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.labelSimpleY);
            this.Controls.Add(this.labelSimpleX);
            this.Controls.Add(this.labelSimpleO);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBRowHX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.picturePReference2);
            this.Controls.Add(this.picturePReference01);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panelCanvas);
            this.Controls.Add(this.labelSimpleVistaPrevia);
            this.Controls.Add(this.labelmm3);
            this.Controls.Add(this.labelmm4);
            this.Controls.Add(this.labelmm2);
            this.Controls.Add(this.labelmm1);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPuntoInicio);
            this.Controls.Add(this.comboBTipo);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Robot Panel - [Robótica 2023-1]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePReference01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePReference2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVisualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBRowHX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.ComboBox comboBTipo;
        private System.Windows.Forms.Label labelPuntoInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelmm1;
        private System.Windows.Forms.Label labelmm2;
        private System.Windows.Forms.Label labelmm4;
        private System.Windows.Forms.Label labelmm3;
        private System.Windows.Forms.Label labelSimpleVistaPrevia;
        private System.Windows.Forms.Panel panelCanvas;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picturePReference01;
        private System.Windows.Forms.PictureBox picturePReference2;
        private System.Windows.Forms.PictureBox btnVisualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBRowHX;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelSimpleO;
        private System.Windows.Forms.Label labelSimpleX;
        private System.Windows.Forms.Label labelSimpleY;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbConsoleMensaje;
    }
}

