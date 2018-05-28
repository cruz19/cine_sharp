namespace Views
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelFunciones = new System.Windows.Forms.Panel();
            this.btnAddFunciones = new System.Windows.Forms.Button();
            this.btnVerFunciones = new System.Windows.Forms.Button();
            this.panelSalas = new System.Windows.Forms.Panel();
            this.btnAddSalas = new System.Windows.Forms.Button();
            this.btnVerSalas = new System.Windows.Forms.Button();
            this.panelPeliculas = new System.Windows.Forms.Panel();
            this.btnVerPeliculas = new System.Windows.Forms.Button();
            this.btnAddPeliculas = new System.Windows.Forms.Button();
            this.btnFunciones = new System.Windows.Forms.Button();
            this.btnSalas = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCerarSesionAdmin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelFunciones.SuspendLayout();
            this.panelSalas.SuspendLayout();
            this.panelPeliculas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerarSesionAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.panel1.Controls.Add(this.btnMinimizar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 26);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(753, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(12, 5);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(775, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(22, 19);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.btnCerarSesionAdmin);
            this.panelMenu.Controls.Add(this.panelFunciones);
            this.panelMenu.Controls.Add(this.panelSalas);
            this.panelMenu.Controls.Add(this.panelPeliculas);
            this.panelMenu.Controls.Add(this.btnFunciones);
            this.panelMenu.Controls.Add(this.btnSalas);
            this.panelMenu.Controls.Add(this.btnPeliculas);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 26);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.panelMenu.Size = new System.Drawing.Size(222, 519);
            this.panelMenu.TabIndex = 1;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // panelFunciones
            // 
            this.panelFunciones.Controls.Add(this.btnAddFunciones);
            this.panelFunciones.Controls.Add(this.btnVerFunciones);
            this.panelFunciones.Location = new System.Drawing.Point(30, 391);
            this.panelFunciones.Name = "panelFunciones";
            this.panelFunciones.Size = new System.Drawing.Size(189, 60);
            this.panelFunciones.TabIndex = 6;
            this.panelFunciones.Visible = false;
            // 
            // btnAddFunciones
            // 
            this.btnAddFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnAddFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFunciones.FlatAppearance.BorderSize = 0;
            this.btnAddFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnAddFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFunciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFunciones.ForeColor = System.Drawing.Color.White;
            this.btnAddFunciones.Image = ((System.Drawing.Image)(resources.GetObject("btnAddFunciones.Image")));
            this.btnAddFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFunciones.Location = new System.Drawing.Point(0, 0);
            this.btnAddFunciones.Name = "btnAddFunciones";
            this.btnAddFunciones.Size = new System.Drawing.Size(189, 28);
            this.btnAddFunciones.TabIndex = 3;
            this.btnAddFunciones.Text = "Agregar función";
            this.btnAddFunciones.UseVisualStyleBackColor = false;
            this.btnAddFunciones.Click += new System.EventHandler(this.btnAddFunciones_Click);
            // 
            // btnVerFunciones
            // 
            this.btnVerFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnVerFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerFunciones.FlatAppearance.BorderSize = 0;
            this.btnVerFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnVerFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerFunciones.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerFunciones.ForeColor = System.Drawing.Color.White;
            this.btnVerFunciones.Image = ((System.Drawing.Image)(resources.GetObject("btnVerFunciones.Image")));
            this.btnVerFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerFunciones.Location = new System.Drawing.Point(0, 29);
            this.btnVerFunciones.Name = "btnVerFunciones";
            this.btnVerFunciones.Size = new System.Drawing.Size(189, 28);
            this.btnVerFunciones.TabIndex = 4;
            this.btnVerFunciones.Text = "Ver funciones";
            this.btnVerFunciones.UseVisualStyleBackColor = false;
            // 
            // panelSalas
            // 
            this.panelSalas.Controls.Add(this.btnAddSalas);
            this.panelSalas.Controls.Add(this.btnVerSalas);
            this.panelSalas.Location = new System.Drawing.Point(30, 270);
            this.panelSalas.Name = "panelSalas";
            this.panelSalas.Size = new System.Drawing.Size(189, 60);
            this.panelSalas.TabIndex = 6;
            this.panelSalas.Visible = false;
            // 
            // btnAddSalas
            // 
            this.btnAddSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnAddSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSalas.FlatAppearance.BorderSize = 0;
            this.btnAddSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnAddSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSalas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSalas.ForeColor = System.Drawing.Color.White;
            this.btnAddSalas.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSalas.Image")));
            this.btnAddSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSalas.Location = new System.Drawing.Point(0, 0);
            this.btnAddSalas.Name = "btnAddSalas";
            this.btnAddSalas.Size = new System.Drawing.Size(189, 30);
            this.btnAddSalas.TabIndex = 3;
            this.btnAddSalas.Text = "Agregar salas";
            this.btnAddSalas.UseVisualStyleBackColor = false;
            this.btnAddSalas.Click += new System.EventHandler(this.btnAddSalas_Click);
            // 
            // btnVerSalas
            // 
            this.btnVerSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnVerSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerSalas.FlatAppearance.BorderSize = 0;
            this.btnVerSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnVerSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerSalas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerSalas.ForeColor = System.Drawing.Color.White;
            this.btnVerSalas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerSalas.Image")));
            this.btnVerSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerSalas.Location = new System.Drawing.Point(0, 31);
            this.btnVerSalas.Name = "btnVerSalas";
            this.btnVerSalas.Size = new System.Drawing.Size(189, 28);
            this.btnVerSalas.TabIndex = 4;
            this.btnVerSalas.Text = "Ver salas";
            this.btnVerSalas.UseVisualStyleBackColor = false;
            // 
            // panelPeliculas
            // 
            this.panelPeliculas.Controls.Add(this.btnVerPeliculas);
            this.panelPeliculas.Controls.Add(this.btnAddPeliculas);
            this.panelPeliculas.Location = new System.Drawing.Point(30, 151);
            this.panelPeliculas.Name = "panelPeliculas";
            this.panelPeliculas.Size = new System.Drawing.Size(189, 59);
            this.panelPeliculas.TabIndex = 5;
            this.panelPeliculas.Visible = false;
            // 
            // btnVerPeliculas
            // 
            this.btnVerPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnVerPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPeliculas.FlatAppearance.BorderSize = 0;
            this.btnVerPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnVerPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerPeliculas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnVerPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnVerPeliculas.Image")));
            this.btnVerPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPeliculas.Location = new System.Drawing.Point(0, 29);
            this.btnVerPeliculas.Name = "btnVerPeliculas";
            this.btnVerPeliculas.Size = new System.Drawing.Size(189, 28);
            this.btnVerPeliculas.TabIndex = 4;
            this.btnVerPeliculas.Text = "Ver películas";
            this.btnVerPeliculas.UseVisualStyleBackColor = false;
            this.btnVerPeliculas.Click += new System.EventHandler(this.btnVerPeliculas_Click);
            // 
            // btnAddPeliculas
            // 
            this.btnAddPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(170)))), ((int)(((byte)(157)))));
            this.btnAddPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPeliculas.FlatAppearance.BorderSize = 0;
            this.btnAddPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnAddPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPeliculas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnAddPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnAddPeliculas.Image")));
            this.btnAddPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPeliculas.Location = new System.Drawing.Point(0, 0);
            this.btnAddPeliculas.Name = "btnAddPeliculas";
            this.btnAddPeliculas.Size = new System.Drawing.Size(189, 28);
            this.btnAddPeliculas.TabIndex = 3;
            this.btnAddPeliculas.Text = "Agregar película";
            this.btnAddPeliculas.UseVisualStyleBackColor = false;
            this.btnAddPeliculas.Click += new System.EventHandler(this.btnAddPeliculas_Click);
            // 
            // btnFunciones
            // 
            this.btnFunciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.btnFunciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunciones.FlatAppearance.BorderSize = 0;
            this.btnFunciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnFunciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunciones.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunciones.ForeColor = System.Drawing.Color.LightGray;
            this.btnFunciones.Image = ((System.Drawing.Image)(resources.GetObject("btnFunciones.Image")));
            this.btnFunciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunciones.Location = new System.Drawing.Point(3, 349);
            this.btnFunciones.Name = "btnFunciones";
            this.btnFunciones.Size = new System.Drawing.Size(216, 40);
            this.btnFunciones.TabIndex = 4;
            this.btnFunciones.Text = "Funciones";
            this.btnFunciones.UseVisualStyleBackColor = false;
            this.btnFunciones.Click += new System.EventHandler(this.btnFunciones_Click);
            // 
            // btnSalas
            // 
            this.btnSalas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.btnSalas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalas.FlatAppearance.BorderSize = 0;
            this.btnSalas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnSalas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalas.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalas.Image = ((System.Drawing.Image)(resources.GetObject("btnSalas.Image")));
            this.btnSalas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalas.Location = new System.Drawing.Point(3, 228);
            this.btnSalas.Name = "btnSalas";
            this.btnSalas.Size = new System.Drawing.Size(216, 40);
            this.btnSalas.TabIndex = 3;
            this.btnSalas.Text = "Salas";
            this.btnSalas.UseVisualStyleBackColor = false;
            this.btnSalas.Click += new System.EventHandler(this.btnSalas_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(71)))), ((int)(((byte)(82)))));
            this.btnPeliculas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeliculas.FlatAppearance.BorderSize = 0;
            this.btnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(96)))), ((int)(((byte)(111)))));
            this.btnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeliculas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.Color.LightGray;
            this.btnPeliculas.Image = ((System.Drawing.Image)(resources.GetObject("btnPeliculas.Image")));
            this.btnPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeliculas.Location = new System.Drawing.Point(3, 109);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(216, 40);
            this.btnPeliculas.TabIndex = 2;
            this.btnPeliculas.Text = "Películas";
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(222, 26);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(581, 519);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnCerarSesionAdmin
            // 
            this.btnCerarSesionAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerarSesionAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnCerarSesionAdmin.Image")));
            this.btnCerarSesionAdmin.Location = new System.Drawing.Point(12, 480);
            this.btnCerarSesionAdmin.Name = "btnCerarSesionAdmin";
            this.btnCerarSesionAdmin.Size = new System.Drawing.Size(26, 27);
            this.btnCerarSesionAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerarSesionAdmin.TabIndex = 0;
            this.btnCerarSesionAdmin.TabStop = false;
            this.btnCerarSesionAdmin.Click += new System.EventHandler(this.btnCerarSesionAdmin_Click);
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 545);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(803, 545);
            this.MinimumSize = new System.Drawing.Size(803, 545);
            this.Name = "Administrador";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelFunciones.ResumeLayout(false);
            this.panelSalas.ResumeLayout(false);
            this.panelPeliculas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerarSesionAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Panel panelPeliculas;
        private System.Windows.Forms.Button btnVerPeliculas;
        private System.Windows.Forms.Button btnAddPeliculas;
        private System.Windows.Forms.Button btnFunciones;
        private System.Windows.Forms.Button btnSalas;
        private System.Windows.Forms.Panel panelSalas;
        private System.Windows.Forms.Button btnVerSalas;
        private System.Windows.Forms.Button btnAddSalas;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelFunciones;
        private System.Windows.Forms.Button btnVerFunciones;
        private System.Windows.Forms.Button btnAddFunciones;
        private System.Windows.Forms.PictureBox btnCerarSesionAdmin;
    }
}

