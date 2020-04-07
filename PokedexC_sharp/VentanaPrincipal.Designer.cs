namespace Pokedex_C_Sharp
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.der = new System.Windows.Forms.Button();
            this.nombre = new System.Windows.Forms.Label();
            this.izq = new System.Windows.Forms.Button();
            this.numero = new System.Windows.Forms.Label();
            this.especie = new System.Windows.Forms.Label();
            this.habitat = new System.Windows.Forms.Label();
            this.tipo = new System.Windows.Forms.Label();
            this.proporciones = new System.Windows.Forms.Label();
            this.habilidad = new System.Windows.Forms.Label();
            this.movimiento = new System.Windows.Forms.Label();
            this.movimiento1 = new System.Windows.Forms.Label();
            this.mov = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.der2 = new System.Windows.Forms.Button();
            this.izq2 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 164);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 150);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // der
            // 
            this.der.BackColor = System.Drawing.Color.Transparent;
            this.der.Cursor = System.Windows.Forms.Cursors.Hand;
            this.der.FlatAppearance.BorderSize = 0;
            this.der.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.der.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.der.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.der.ForeColor = System.Drawing.SystemColors.ControlText;
            this.der.Location = new System.Drawing.Point(224, 370);
            this.der.Name = "der";
            this.der.Size = new System.Drawing.Size(31, 24);
            this.der.TabIndex = 2;
            this.der.Text = ">>";
            this.der.UseVisualStyleBackColor = false;
            this.der.Click += new System.EventHandler(this.der_Click);
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.Color.Turquoise;
            this.nombre.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.ForeColor = System.Drawing.Color.Black;
            this.nombre.Location = new System.Drawing.Point(359, 146);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(221, 21);
            this.nombre.TabIndex = 4;
            // 
            // izq
            // 
            this.izq.BackColor = System.Drawing.Color.Transparent;
            this.izq.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izq.FlatAppearance.BorderSize = 0;
            this.izq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.izq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.izq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izq.Location = new System.Drawing.Point(187, 370);
            this.izq.Name = "izq";
            this.izq.Size = new System.Drawing.Size(31, 24);
            this.izq.TabIndex = 3;
            this.izq.Text = "<<";
            this.izq.UseVisualStyleBackColor = false;
            this.izq.Click += new System.EventHandler(this.izq_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.BackColor = System.Drawing.Color.Transparent;
            this.numero.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.numero.Location = new System.Drawing.Point(30, 44);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(0, 21);
            this.numero.TabIndex = 5;
            this.numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // especie
            // 
            this.especie.BackColor = System.Drawing.Color.Turquoise;
            this.especie.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.especie.ForeColor = System.Drawing.Color.Black;
            this.especie.Location = new System.Drawing.Point(359, 188);
            this.especie.Name = "especie";
            this.especie.Size = new System.Drawing.Size(221, 21);
            this.especie.TabIndex = 6;
            // 
            // habitat
            // 
            this.habitat.BackColor = System.Drawing.Color.Turquoise;
            this.habitat.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habitat.ForeColor = System.Drawing.Color.Black;
            this.habitat.Location = new System.Drawing.Point(359, 209);
            this.habitat.Name = "habitat";
            this.habitat.Size = new System.Drawing.Size(221, 21);
            this.habitat.TabIndex = 7;
            // 
            // tipo
            // 
            this.tipo.BackColor = System.Drawing.Color.Turquoise;
            this.tipo.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipo.ForeColor = System.Drawing.Color.Black;
            this.tipo.Location = new System.Drawing.Point(359, 167);
            this.tipo.Name = "tipo";
            this.tipo.Size = new System.Drawing.Size(221, 21);
            this.tipo.TabIndex = 8;
            // 
            // proporciones
            // 
            this.proporciones.BackColor = System.Drawing.Color.Turquoise;
            this.proporciones.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proporciones.ForeColor = System.Drawing.Color.Black;
            this.proporciones.Location = new System.Drawing.Point(359, 230);
            this.proporciones.Name = "proporciones";
            this.proporciones.Size = new System.Drawing.Size(221, 21);
            this.proporciones.TabIndex = 10;
            // 
            // habilidad
            // 
            this.habilidad.BackColor = System.Drawing.Color.Turquoise;
            this.habilidad.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.habilidad.ForeColor = System.Drawing.Color.Black;
            this.habilidad.Location = new System.Drawing.Point(359, 251);
            this.habilidad.Name = "habilidad";
            this.habilidad.Size = new System.Drawing.Size(221, 21);
            this.habilidad.TabIndex = 11;
            // 
            // movimiento
            // 
            this.movimiento.BackColor = System.Drawing.Color.Turquoise;
            this.movimiento.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento.ForeColor = System.Drawing.Color.Black;
            this.movimiento.Location = new System.Drawing.Point(359, 293);
            this.movimiento.Name = "movimiento";
            this.movimiento.Size = new System.Drawing.Size(221, 21);
            this.movimiento.TabIndex = 12;
            // 
            // movimiento1
            // 
            this.movimiento1.BackColor = System.Drawing.Color.Turquoise;
            this.movimiento1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movimiento1.ForeColor = System.Drawing.Color.Black;
            this.movimiento1.Location = new System.Drawing.Point(359, 314);
            this.movimiento1.Name = "movimiento1";
            this.movimiento1.Size = new System.Drawing.Size(221, 21);
            this.movimiento1.TabIndex = 13;
            // 
            // mov
            // 
            this.mov.BackColor = System.Drawing.Color.Turquoise;
            this.mov.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mov.ForeColor = System.Drawing.Color.Black;
            this.mov.Location = new System.Drawing.Point(359, 272);
            this.mov.Name = "mov";
            this.mov.Size = new System.Drawing.Size(221, 21);
            this.mov.TabIndex = 14;
            this.mov.Text = "Movimientos:";
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.Color.Turquoise;
            this.descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descripcion.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(359, 334);
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(221, 87);
            this.descripcion.TabIndex = 15;
            // 
            // der2
            // 
            this.der2.BackColor = System.Drawing.Color.Transparent;
            this.der2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.der2.FlatAppearance.BorderSize = 0;
            this.der2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.der2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.der2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.der2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.der2.Location = new System.Drawing.Point(204, 340);
            this.der2.Name = "der2";
            this.der2.Size = new System.Drawing.Size(31, 24);
            this.der2.TabIndex = 16;
            this.der2.Text = "+>";
            this.der2.UseVisualStyleBackColor = false;
            this.der2.Click += new System.EventHandler(this.der2_Click);
            // 
            // izq2
            // 
            this.izq2.BackColor = System.Drawing.Color.Transparent;
            this.izq2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.izq2.FlatAppearance.BorderSize = 0;
            this.izq2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.izq2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.izq2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izq2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.izq2.Location = new System.Drawing.Point(204, 397);
            this.izq2.Name = "izq2";
            this.izq2.Size = new System.Drawing.Size(31, 24);
            this.izq2.TabIndex = 17;
            this.izq2.Text = "<+";
            this.izq2.UseVisualStyleBackColor = false;
            this.izq2.Click += new System.EventHandler(this.izq2_Click);
            // 
            // data
            // 
            this.data.BackColor = System.Drawing.Color.Transparent;
            this.data.Cursor = System.Windows.Forms.Cursors.Hand;
            this.data.FlatAppearance.BorderSize = 0;
            this.data.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.data.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.data.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.Location = new System.Drawing.Point(95, 383);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(59, 29);
            this.data.TabIndex = 18;
            this.data.Text = "DATA";
            this.data.UseVisualStyleBackColor = false;
            this.data.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PokedexC_sharp.Properties.Resources.pokedex2;
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.data);
            this.Controls.Add(this.izq2);
            this.Controls.Add(this.der2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.mov);
            this.Controls.Add(this.movimiento1);
            this.Controls.Add(this.movimiento);
            this.Controls.Add(this.habilidad);
            this.Controls.Add(this.proporciones);
            this.Controls.Add(this.tipo);
            this.Controls.Add(this.habitat);
            this.Controls.Add(this.especie);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.izq);
            this.Controls.Add(this.der);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaPrincipal";
            this.Text = "POKEDEX";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button der;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Button izq;
        private System.Windows.Forms.Label numero;
        private System.Windows.Forms.Label especie;
        private System.Windows.Forms.Label habitat;
        private System.Windows.Forms.Label tipo;
        private System.Windows.Forms.Label proporciones;
        private System.Windows.Forms.Label habilidad;
        private System.Windows.Forms.Label movimiento;
        private System.Windows.Forms.Label movimiento1;
        private System.Windows.Forms.Label mov;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Button der2;
        private System.Windows.Forms.Button izq2;
        private System.Windows.Forms.Button data;
    }
}

