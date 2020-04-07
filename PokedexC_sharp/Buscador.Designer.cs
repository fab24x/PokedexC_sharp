namespace PokedexC_sharp
{
    partial class Buscador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscador));
            this.ponNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.busca = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ponNombre
            // 
            this.ponNombre.AutoSize = true;
            this.ponNombre.BackColor = System.Drawing.Color.Turquoise;
            this.ponNombre.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ponNombre.Location = new System.Drawing.Point(73, 9);
            this.ponNombre.Name = "ponNombre";
            this.ponNombre.Size = new System.Drawing.Size(232, 21);
            this.ponNombre.TabIndex = 0;
            this.ponNombre.Text = "Pon en nombre del pokemon";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(139, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "ACEPTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // busca
            // 
            this.busca.BackColor = System.Drawing.Color.Turquoise;
            this.busca.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busca.Location = new System.Drawing.Point(73, 55);
            this.busca.Name = "busca";
            this.busca.Size = new System.Drawing.Size(232, 29);
            this.busca.TabIndex = 3;
            // 
            // Buscador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(377, 158);
            this.Controls.Add(this.busca);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ponNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Buscador";
            this.Text = "BUSCADOR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ponNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox busca;
    }
}