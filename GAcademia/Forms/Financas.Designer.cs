
namespace GAcademia.Forms
{
    partial class Financas
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
            this.btn_Mensalidades = new System.Windows.Forms.Button();
            this.panelButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.panelChildrens = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Mensalidades
            // 
            this.btn_Mensalidades.AutoSize = true;
            this.btn_Mensalidades.FlatAppearance.BorderSize = 0;
            this.btn_Mensalidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mensalidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mensalidades.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Mensalidades.Location = new System.Drawing.Point(-1, 0);
            this.btn_Mensalidades.Name = "btn_Mensalidades";
            this.btn_Mensalidades.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Mensalidades.Size = new System.Drawing.Size(118, 60);
            this.btn_Mensalidades.TabIndex = 2;
            this.btn_Mensalidades.Text = "Mensalidades";
            this.btn_Mensalidades.UseVisualStyleBackColor = true;
            this.btn_Mensalidades.Click += new System.EventHandler(this.btn_Mensalidades_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btn_Mensalidades);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(120, 450);
            this.panelButtons.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelButtons.TabIndex = 3;
            // 
            // panelChildrens
            // 
            this.panelChildrens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.panelChildrens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildrens.Location = new System.Drawing.Point(120, 0);
            this.panelChildrens.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelChildrens.Name = "panelChildrens";
            this.panelChildrens.Size = new System.Drawing.Size(680, 450);
            this.panelChildrens.TabIndex = 4;
            // 
            // Financas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildrens);
            this.Controls.Add(this.panelButtons);
            this.Name = "Financas";
            this.Text = "Financas";
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Mensalidades;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelButtons;
        private System.Windows.Forms.Panel panelChildrens;
    }
}