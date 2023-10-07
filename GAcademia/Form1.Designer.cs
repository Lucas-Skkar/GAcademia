
namespace GAcademia
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_Agenda = new System.Windows.Forms.Button();
            this.btn_Men = new System.Windows.Forms.Button();
            this.btn_Instrutor = new System.Windows.Forms.Button();
            this.btn_User = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_min = new System.Windows.Forms.Label();
            this.btn_max = new System.Windows.Forms.Label();
            this.bnt_close = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_Agenda);
            this.panelMenu.Controls.Add(this.btn_Men);
            this.panelMenu.Controls.Add(this.btn_Instrutor);
            this.panelMenu.Controls.Add(this.btn_User);
            this.panelMenu.Controls.Add(this.btn_Home);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btn_Agenda
            // 
            this.btn_Agenda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Agenda.FlatAppearance.BorderSize = 0;
            this.btn_Agenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agenda.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Agenda.Location = new System.Drawing.Point(0, 320);
            this.btn_Agenda.Name = "btn_Agenda";
            this.btn_Agenda.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Agenda.Size = new System.Drawing.Size(200, 60);
            this.btn_Agenda.TabIndex = 5;
            this.btn_Agenda.Text = "Agendamento";
            this.btn_Agenda.UseVisualStyleBackColor = true;
            this.btn_Agenda.Click += new System.EventHandler(this.btn_Agenda_Click);
            // 
            // btn_Men
            // 
            this.btn_Men.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Men.FlatAppearance.BorderSize = 0;
            this.btn_Men.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Men.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Men.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Men.Location = new System.Drawing.Point(0, 260);
            this.btn_Men.Name = "btn_Men";
            this.btn_Men.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Men.Size = new System.Drawing.Size(200, 60);
            this.btn_Men.TabIndex = 4;
            this.btn_Men.Text = "Mensalidades";
            this.btn_Men.UseVisualStyleBackColor = true;
            this.btn_Men.Click += new System.EventHandler(this.btn_Men_Click);
            // 
            // btn_Instrutor
            // 
            this.btn_Instrutor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Instrutor.FlatAppearance.BorderSize = 0;
            this.btn_Instrutor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Instrutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instrutor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Instrutor.Location = new System.Drawing.Point(0, 200);
            this.btn_Instrutor.Name = "btn_Instrutor";
            this.btn_Instrutor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Instrutor.Size = new System.Drawing.Size(200, 60);
            this.btn_Instrutor.TabIndex = 3;
            this.btn_Instrutor.Text = "Instrutores";
            this.btn_Instrutor.UseVisualStyleBackColor = true;
            this.btn_Instrutor.Click += new System.EventHandler(this.btn_Instrutor_Click);
            // 
            // btn_User
            // 
            this.btn_User.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_User.FlatAppearance.BorderSize = 0;
            this.btn_User.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_User.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_User.Location = new System.Drawing.Point(0, 140);
            this.btn_User.Name = "btn_User";
            this.btn_User.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_User.Size = new System.Drawing.Size(200, 60);
            this.btn_User.TabIndex = 2;
            this.btn_User.Text = "Usuários";
            this.btn_User.UseVisualStyleBackColor = true;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Home.Location = new System.Drawing.Point(0, 80);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_Home.Size = new System.Drawing.Size(200, 60);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Location = new System.Drawing.Point(200, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(744, 481);
            this.panelDesktop.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Controls.Add(this.bnt_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 80);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.AutoSize = true;
            this.btn_min.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_min.Location = new System.Drawing.Point(651, 0);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(28, 26);
            this.btn_min.TabIndex = 2;
            this.btn_min.Text = "O";
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_max.AutoSize = true;
            this.btn_max.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_max.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_max.Location = new System.Drawing.Point(685, 0);
            this.btn_max.Name = "btn_max";
            this.btn_max.Size = new System.Drawing.Size(28, 26);
            this.btn_max.TabIndex = 1;
            this.btn_max.Text = "O";
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // bnt_close
            // 
            this.bnt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bnt_close.AutoSize = true;
            this.bnt_close.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_close.ForeColor = System.Drawing.Color.Firebrick;
            this.bnt_close.Location = new System.Drawing.Point(715, 0);
            this.bnt_close.Name = "bnt_close";
            this.bnt_close.Size = new System.Drawing.Size(28, 26);
            this.bnt_close.TabIndex = 0;
            this.bnt_close.Text = "O";
            this.bnt_close.Click += new System.EventHandler(this.bnt_close_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(860, 500);
            this.Name = "FormMain";
            this.Text = "GerAcademia";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_Men;
        private System.Windows.Forms.Button btn_Instrutor;
        private System.Windows.Forms.Button btn_User;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label btn_min;
        private System.Windows.Forms.Label btn_max;
        private System.Windows.Forms.Label bnt_close;
        private System.Windows.Forms.Button btn_Agenda;
    }
}

