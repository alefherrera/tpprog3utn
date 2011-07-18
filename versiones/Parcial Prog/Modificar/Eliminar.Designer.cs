namespace WindowsFormsApplication1
{
    partial class Eliminar
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
            this.cb_tipo = new System.Windows.Forms.ComboBox();
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.cb_artxprov = new System.Windows.Forms.ComboBox();
            this.botoneliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_tipo
            // 
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Location = new System.Drawing.Point(12, 12);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 0;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.cb_tipo_SelectedIndexChanged);
            // 
            // cb_id
            // 
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Location = new System.Drawing.Point(139, 12);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(121, 21);
            this.cb_id.TabIndex = 1;
            this.cb_id.SelectedIndexChanged += new System.EventHandler(this.cb_id_SelectedIndexChanged);
            this.cb_id.Enter += new System.EventHandler(this.cb_id_Enter);
            // 
            // cb_artxprov
            // 
            this.cb_artxprov.FormattingEnabled = true;
            this.cb_artxprov.Location = new System.Drawing.Point(266, 12);
            this.cb_artxprov.Name = "cb_artxprov";
            this.cb_artxprov.Size = new System.Drawing.Size(121, 21);
            this.cb_artxprov.TabIndex = 2;
            this.cb_artxprov.SelectedIndexChanged += new System.EventHandler(this.cb_artxprov_SelectedIndexChanged);
            this.cb_artxprov.TextChanged += new System.EventHandler(this.cb_artxprov_TextChanged);
            // 
            // botoneliminar
            // 
            this.botoneliminar.Location = new System.Drawing.Point(312, 48);
            this.botoneliminar.Name = "botoneliminar";
            this.botoneliminar.Size = new System.Drawing.Size(75, 23);
            this.botoneliminar.TabIndex = 3;
            this.botoneliminar.Text = "Eliminar";
            this.botoneliminar.UseVisualStyleBackColor = true;
            this.botoneliminar.Click += new System.EventHandler(this.botoneliminar_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 82);
            this.Controls.Add(this.botoneliminar);
            this.Controls.Add(this.cb_artxprov);
            this.Controls.Add(this.cb_id);
            this.Controls.Add(this.cb_tipo);
            this.Name = "Eliminar";
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_tipo;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.ComboBox cb_artxprov;
        private System.Windows.Forms.Button botoneliminar;
    }
}