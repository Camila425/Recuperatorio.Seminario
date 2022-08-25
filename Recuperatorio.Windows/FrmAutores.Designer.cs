
namespace Recuperatorio.Windows
{
    partial class FrmAutores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GrillaPanel = new System.Windows.Forms.Panel();
            this.DatosDataGridView = new System.Windows.Forms.DataGridView();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.Salirbutton = new System.Windows.Forms.Button();
            this.Editarbutton = new System.Windows.Forms.Button();
            this.Borrarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.ColAutorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrillaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrillaPanel
            // 
            this.GrillaPanel.Controls.Add(this.DatosDataGridView);
            this.GrillaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPanel.Location = new System.Drawing.Point(0, 100);
            this.GrillaPanel.Name = "GrillaPanel";
            this.GrillaPanel.Size = new System.Drawing.Size(800, 350);
            this.GrillaPanel.TabIndex = 9;
            // 
            // DatosDataGridView
            // 
            this.DatosDataGridView.AllowUserToAddRows = false;
            this.DatosDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DatosDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DatosDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DatosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColAutorId,
            this.ColApellido,
            this.ColNombre,
            this.ColNacionalidad});
            this.DatosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.DatosDataGridView.MultiSelect = false;
            this.DatosDataGridView.Name = "DatosDataGridView";
            this.DatosDataGridView.ReadOnly = true;
            this.DatosDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosDataGridView.RowTemplate.Height = 28;
            this.DatosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatosDataGridView.Size = new System.Drawing.Size(800, 350);
            this.DatosDataGridView.TabIndex = 1;
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ToolBarPanel.Controls.Add(this.Salirbutton);
            this.ToolBarPanel.Controls.Add(this.Editarbutton);
            this.ToolBarPanel.Controls.Add(this.Borrarbutton);
            this.ToolBarPanel.Controls.Add(this.Nuevobutton);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(800, 100);
            this.ToolBarPanel.TabIndex = 8;
            // 
            // Salirbutton
            // 
            this.Salirbutton.Image = global::Recuperatorio.Windows.Properties.Resources.close_window_36px;
            this.Salirbutton.Location = new System.Drawing.Point(700, 31);
            this.Salirbutton.Name = "Salirbutton";
            this.Salirbutton.Size = new System.Drawing.Size(75, 63);
            this.Salirbutton.TabIndex = 3;
            this.Salirbutton.UseVisualStyleBackColor = true;
            this.Salirbutton.Click += new System.EventHandler(this.Salirbutton_Click);
            // 
            // Editarbutton
            // 
            this.Editarbutton.Image = global::Recuperatorio.Windows.Properties.Resources.edit;
            this.Editarbutton.Location = new System.Drawing.Point(166, 31);
            this.Editarbutton.Name = "Editarbutton";
            this.Editarbutton.Size = new System.Drawing.Size(75, 66);
            this.Editarbutton.TabIndex = 2;
            this.Editarbutton.UseVisualStyleBackColor = true;
            // 
            // Borrarbutton
            // 
            this.Borrarbutton.Image = global::Recuperatorio.Windows.Properties.Resources.delete;
            this.Borrarbutton.Location = new System.Drawing.Point(84, 31);
            this.Borrarbutton.Name = "Borrarbutton";
            this.Borrarbutton.Size = new System.Drawing.Size(75, 66);
            this.Borrarbutton.TabIndex = 1;
            this.Borrarbutton.UseVisualStyleBackColor = true;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Image = global::Recuperatorio.Windows.Properties.Resources.add_36px;
            this.Nuevobutton.Location = new System.Drawing.Point(3, 31);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 63);
            this.Nuevobutton.TabIndex = 0;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            // 
            // ColAutorId
            // 
            this.ColAutorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAutorId.HeaderText = "AutorId";
            this.ColAutorId.Name = "ColAutorId";
            this.ColAutorId.ReadOnly = true;
            // 
            // ColApellido
            // 
            this.ColApellido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColApellido.HeaderText = "Apellido";
            this.ColApellido.Name = "ColApellido";
            this.ColApellido.ReadOnly = true;
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Nombre";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColNacionalidad
            // 
            this.ColNacionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNacionalidad.HeaderText = "Nacionalidad";
            this.ColNacionalidad.Name = "ColNacionalidad";
            this.ColNacionalidad.ReadOnly = true;
            // 
            // FrmAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrillaPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.Name = "FrmAutores";
            this.Text = "FrmAutores";
            this.Load += new System.EventHandler(this.FrmAutores_Load);
            this.GrillaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DatosDataGridView)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GrillaPanel;
        private System.Windows.Forms.DataGridView DatosDataGridView;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Borrarbutton;
        private System.Windows.Forms.Button Editarbutton;
        private System.Windows.Forms.Button Salirbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNacionalidad;
    }
}