
namespace Recuperatorio.Windows
{
    partial class FrmPrincipal
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
            this.label2 = new System.Windows.Forms.Label();
            this.BombonesButton = new System.Windows.Forms.Button();
            this.FabricasButton = new System.Windows.Forms.Button();
            this.RellenosButton = new System.Windows.Forms.Button();
            this.NuecesButton = new System.Windows.Forms.Button();
            this.ChocolatesButton = new System.Windows.Forms.Button();
            this.PaisesButton = new System.Windows.Forms.Button();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Biblioteca";
            // 
            // BombonesButton
            // 
            this.BombonesButton.Location = new System.Drawing.Point(190, 227);
            this.BombonesButton.Name = "BombonesButton";
            this.BombonesButton.Size = new System.Drawing.Size(143, 67);
            this.BombonesButton.TabIndex = 10;
            this.BombonesButton.Text = "Usuarios";
            this.BombonesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BombonesButton.UseVisualStyleBackColor = true;
            this.BombonesButton.Click += new System.EventHandler(this.BombonesButton_Click);
            // 
            // FabricasButton
            // 
            this.FabricasButton.Location = new System.Drawing.Point(41, 227);
            this.FabricasButton.Name = "FabricasButton";
            this.FabricasButton.Size = new System.Drawing.Size(143, 67);
            this.FabricasButton.TabIndex = 11;
            this.FabricasButton.Text = "Libros";
            this.FabricasButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FabricasButton.UseVisualStyleBackColor = true;
            this.FabricasButton.Click += new System.EventHandler(this.FabricasButton_Click);
            // 
            // RellenosButton
            // 
            this.RellenosButton.Location = new System.Drawing.Point(488, 121);
            this.RellenosButton.Name = "RellenosButton";
            this.RellenosButton.Size = new System.Drawing.Size(143, 67);
            this.RellenosButton.TabIndex = 12;
            this.RellenosButton.Text = "idiomas";
            this.RellenosButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RellenosButton.UseVisualStyleBackColor = true;
            // 
            // NuecesButton
            // 
            this.NuecesButton.Location = new System.Drawing.Point(339, 121);
            this.NuecesButton.Name = "NuecesButton";
            this.NuecesButton.Size = new System.Drawing.Size(143, 67);
            this.NuecesButton.TabIndex = 13;
            this.NuecesButton.Text = "GenerosLiterarios";
            this.NuecesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NuecesButton.UseVisualStyleBackColor = true;
            // 
            // ChocolatesButton
            // 
            this.ChocolatesButton.Location = new System.Drawing.Point(190, 121);
            this.ChocolatesButton.Name = "ChocolatesButton";
            this.ChocolatesButton.Size = new System.Drawing.Size(143, 67);
            this.ChocolatesButton.TabIndex = 14;
            this.ChocolatesButton.Text = "Editoriales";
            this.ChocolatesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChocolatesButton.UseVisualStyleBackColor = true;
            this.ChocolatesButton.Click += new System.EventHandler(this.ChocolatesButton_Click);
            // 
            // PaisesButton
            // 
            this.PaisesButton.Location = new System.Drawing.Point(41, 121);
            this.PaisesButton.Name = "PaisesButton";
            this.PaisesButton.Size = new System.Drawing.Size(143, 67);
            this.PaisesButton.TabIndex = 15;
            this.PaisesButton.Text = "Autores";
            this.PaisesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaisesButton.UseVisualStyleBackColor = true;
            this.PaisesButton.Click += new System.EventHandler(this.PaisesButton_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(684, 354);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 59);
            this.CerrarButton.TabIndex = 9;
            this.CerrarButton.Text = "Salir";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BombonesButton);
            this.Controls.Add(this.FabricasButton);
            this.Controls.Add(this.RellenosButton);
            this.Controls.Add(this.NuecesButton);
            this.Controls.Add(this.ChocolatesButton);
            this.Controls.Add(this.PaisesButton);
            this.Controls.Add(this.CerrarButton);
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BombonesButton;
        private System.Windows.Forms.Button FabricasButton;
        private System.Windows.Forms.Button RellenosButton;
        private System.Windows.Forms.Button NuecesButton;
        private System.Windows.Forms.Button ChocolatesButton;
        private System.Windows.Forms.Button PaisesButton;
        private System.Windows.Forms.Button CerrarButton;
    }
}

