namespace Views
{
    partial class agregarPelicula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(agregarPelicula));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.txtNamePelicula = new System.Windows.Forms.TextBox();
            this.txtDescripcionPeli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddPelicula = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(73)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar película";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(581, 519);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape2.Enabled = false;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.SelectionColor = System.Drawing.Color.DimGray;
            this.lineShape2.X1 = 60;
            this.lineShape2.X2 = 501;
            this.lineShape2.Y1 = 263;
            this.lineShape2.Y2 = 263;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.DimGray;
            this.lineShape1.Enabled = false;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.SelectionColor = System.Drawing.Color.DimGray;
            this.lineShape1.X1 = 61;
            this.lineShape1.X2 = 502;
            this.lineShape1.Y1 = 183;
            this.lineShape1.Y2 = 183;
            // 
            // txtNamePelicula
            // 
            this.txtNamePelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.txtNamePelicula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamePelicula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePelicula.ForeColor = System.Drawing.Color.DimGray;
            this.txtNamePelicula.Location = new System.Drawing.Point(61, 146);
            this.txtNamePelicula.Name = "txtNamePelicula";
            this.txtNamePelicula.Size = new System.Drawing.Size(442, 20);
            this.txtNamePelicula.TabIndex = 2;
            this.txtNamePelicula.Text = "Nombre de la película";
            this.txtNamePelicula.Enter += new System.EventHandler(this.txtNamePelicula_Enter);
            this.txtNamePelicula.Leave += new System.EventHandler(this.txtNamePelicula_Leave);
            // 
            // txtDescripcionPeli
            // 
            this.txtDescripcionPeli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.txtDescripcionPeli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescripcionPeli.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPeli.ForeColor = System.Drawing.Color.DimGray;
            this.txtDescripcionPeli.Location = new System.Drawing.Point(61, 226);
            this.txtDescripcionPeli.Name = "txtDescripcionPeli";
            this.txtDescripcionPeli.Size = new System.Drawing.Size(442, 20);
            this.txtDescripcionPeli.TabIndex = 3;
            this.txtDescripcionPeli.Text = "Descripción";
            this.txtDescripcionPeli.Enter += new System.EventHandler(this.txtDescripcionPeli_Enter);
            this.txtDescripcionPeli.Leave += new System.EventHandler(this.txtDescripcionPeli_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(58, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(343, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Selecciona una imagen para la película";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchImage
            // 
            this.btnSearchImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.btnSearchImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchImage.FlatAppearance.BorderSize = 0;
            this.btnSearchImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnSearchImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchImage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchImage.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSearchImage.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchImage.Image")));
            this.btnSearchImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchImage.Location = new System.Drawing.Point(407, 318);
            this.btnSearchImage.Name = "btnSearchImage";
            this.btnSearchImage.Size = new System.Drawing.Size(95, 23);
            this.btnSearchImage.TabIndex = 6;
            this.btnSearchImage.Text = "Search";
            this.btnSearchImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchImage.UseVisualStyleBackColor = false;
            this.btnSearchImage.Click += new System.EventHandler(this.btnSearchImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddPelicula
            // 
            this.btnAddPelicula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(130)))), ((int)(((byte)(115)))));
            this.btnAddPelicula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPelicula.FlatAppearance.BorderSize = 0;
            this.btnAddPelicula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(65)))));
            this.btnAddPelicula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPelicula.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPelicula.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddPelicula.Location = new System.Drawing.Point(61, 412);
            this.btnAddPelicula.Name = "btnAddPelicula";
            this.btnAddPelicula.Size = new System.Drawing.Size(442, 40);
            this.btnAddPelicula.TabIndex = 4;
            this.btnAddPelicula.Text = "Agregar";
            this.btnAddPelicula.UseVisualStyleBackColor = false;
            this.btnAddPelicula.Click += new System.EventHandler(this.btnAddPelicula_Click);
            // 
            // agregarPelicula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(43)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(581, 519);
            this.Controls.Add(this.btnSearchImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddPelicula);
            this.Controls.Add(this.txtDescripcionPeli);
            this.Controls.Add(this.txtNamePelicula);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "agregarPelicula";
            this.Opacity = 0.9D;
            this.Text = "agregarPelicula";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.TextBox txtNamePelicula;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.TextBox txtDescripcionPeli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddPelicula;
    }
}