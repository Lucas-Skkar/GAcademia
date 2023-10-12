
namespace GAcademia.Forms
{
    partial class Configuracao
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelChildrens = new System.Windows.Forms.Panel();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_db = new System.Windows.Forms.Button();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelButtons.Controls.Add(this.btn_db);
            this.panelButtons.Controls.Add(this.btn_Login);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(171, 450);
            this.panelButtons.TabIndex = 0;
            // 
            // panelChildrens
            // 
            this.panelChildrens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.panelChildrens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildrens.Location = new System.Drawing.Point(171, 0);
            this.panelChildrens.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelChildrens.Name = "panelChildrens";
            this.panelChildrens.Size = new System.Drawing.Size(629, 450);
            this.panelChildrens.TabIndex = 1;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.Location = new System.Drawing.Point(12, 28);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(143, 39);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Trocar Senha Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_db
            // 
            this.btn_db.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_db.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_db.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_db.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_db.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_db.Location = new System.Drawing.Point(12, 93);
            this.btn_db.Name = "btn_db";
            this.btn_db.Size = new System.Drawing.Size(143, 39);
            this.btn_db.TabIndex = 1;
            this.btn_db.Text = "Configurar Database";
            this.btn_db.UseVisualStyleBackColor = false;
            this.btn_db.Click += new System.EventHandler(this.btn_db_Click);
            // 
            // Configuracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelChildrens);
            this.Controls.Add(this.panelButtons);
            this.Name = "Configuracao";
            this.Text = "Configuracao";
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelChildrens;
        private System.Windows.Forms.Button btn_db;
        private System.Windows.Forms.Button btn_Login;
    }
}