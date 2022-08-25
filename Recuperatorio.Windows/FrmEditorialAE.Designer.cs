
namespace Recuperatorio.Windows
{
    partial class FrmEditorialAE
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
            this.components = new System.ComponentModel.Container();
            this.EditorialTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.okbutton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorialTextBox
            // 
            this.EditorialTextBox.Location = new System.Drawing.Point(83, 27);
            this.EditorialTextBox.MaxLength = 120;
            this.EditorialTextBox.Name = "EditorialTextBox";
            this.EditorialTextBox.Size = new System.Drawing.Size(282, 20);
            this.EditorialTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Editorial:";
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.Image = global::Recuperatorio.Windows.Properties.Resources.close_window_48px;
            this.Cancelarbutton.Location = new System.Drawing.Point(232, 94);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(110, 66);
            this.Cancelarbutton.TabIndex = 12;
            this.Cancelarbutton.UseVisualStyleBackColor = true;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // okbutton
            // 
            this.okbutton.Image = global::Recuperatorio.Windows.Properties.Resources.ok_36px;
            this.okbutton.Location = new System.Drawing.Point(63, 94);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(108, 66);
            this.okbutton.TabIndex = 11;
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmEditorialAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 172);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.EditorialTextBox);
            this.Controls.Add(this.label1);
            this.Name = "FrmEditorialAE";
            this.Text = "FrmEditorialAE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EditorialTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}