
namespace GAcademia.Forms.Notifications
{
    partial class MySqlConfig
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
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.textBoxBancoDados = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.textBoxPorta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.Location = new System.Drawing.Point(41, 50);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(100, 23);
            this.textBoxServidor.TabIndex = 0;
            // 
            // textBoxBancoDados
            // 
            this.textBoxBancoDados.Location = new System.Drawing.Point(41, 97);
            this.textBoxBancoDados.Name = "textBoxBancoDados";
            this.textBoxBancoDados.Size = new System.Drawing.Size(100, 23);
            this.textBoxBancoDados.TabIndex = 1;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(41, 143);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(100, 23);
            this.textBoxUsuario.TabIndex = 2;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(41, 189);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(100, 23);
            this.textBoxSenha.TabIndex = 3;
            // 
            // textBoxPorta
            // 
            this.textBoxPorta.Location = new System.Drawing.Point(41, 238);
            this.textBoxPorta.Name = "textBoxPorta";
            this.textBoxPorta.Size = new System.Drawing.Size(100, 23);
            this.textBoxPorta.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MySqlConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(518, 333);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxPorta);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.textBoxBancoDados);
            this.Controls.Add(this.textBoxServidor);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MySqlConfig";
            this.Text = "MySqlConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.TextBox textBoxBancoDados;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.TextBox textBoxPorta;
        private System.Windows.Forms.Button button1;
    }
}