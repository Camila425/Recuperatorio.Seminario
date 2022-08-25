
namespace Recuperatorio.Windows
{
    partial class FrmUsuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.colDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Salirbutton
            // 
            this.Salirbutton.Image = global::Recuperatorio.Windows.Properties.Resources.close_window_36px;
            this.Salirbutton.Location = new System.Drawing.Point(703, 7);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(75, 56);
            this.Salirbutton.TabIndex = 11;
            this.Salirbutton.UseVisualStyleBackColor = true;
            // 
            // Editarbutton
            // 
            this.Editarbutton.Image = global::Recuperatorio.Windows.Properties.Resources.edit;
            this.Editarbutton.Location = new System.Drawing.Point(191, 7);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(75, 56);
            this.Editarbutton.TabIndex = 10;
            this.Editarbutton.UseVisualStyleBackColor = true;
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Image = global::Recuperatorio.Windows.Properties.Resources.delete;
            this.Borrarbutton.Location = new System.Drawing.Point(94, 7);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(75, 57);
            this.Borrarbutton.TabIndex = 9;
            this.Borrarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Recuperatorio.Windows.Properties.Resources.add_36px;
            this.Nuevobutton.Location = new System.Drawing.Point(13, 7);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDni,
            this.colApellido,
            this.colnombre,
            this.coldireccion,
            this.collocalidad});
            this.DatosDataGridView.Location = new System.Drawing.Point(-9, 70);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(818, 373);
            this.DatosDataGridView.TabIndex = 7;
            // 
            // colDni
            // 
            this.colDni.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDni.HeaderText = "DNI";
            this.colDni.Name = "colDni";
            this.colDni.ReadOnly = true;
            // 
            // colApellido
            // 
            this.colApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellido.HeaderText = "Apellido";
            this.colApellido.Name = "colApellido";
            this.colApellido.ReadOnly = true;
            // 
            // colnombre
            // 
            this.colnombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colnombre.HeaderText = "Nombre";
            this.colnombre.Name = "colnombre";
            this.colnombre.ReadOnly = true;
            // 
            // coldireccion
            // 
            this.coldireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.coldireccion.HeaderText = "Direccion";
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.ReadOnly = true;
            // 
            // collocalidad
            // 
            this.collocalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.collocalidad.HeaderText = "Localidad";
            this.collocalidad.Name = "collocalidad";
            this.collocalidad.ReadOnly = true;
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Salirbutton);
            this.Controls.Add(this.Editarbutton);
            this.Controls.Add(this.Borrarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.DatosDataGridView);
            this.Name = "FrmUsuarios";
            this.Text = "FrmUsuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn collocalidad;
    }
}