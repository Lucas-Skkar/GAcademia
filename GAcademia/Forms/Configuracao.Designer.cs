
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
            this.components = new System.ComponentModel.Container();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btn_NewLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteButtons = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_db = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelChildrens = new System.Windows.Forms.Panel();
            this.PanelNewLogin = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.bnt_salvarN = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBoxLoginN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxSenhaN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxInfLoginN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxInfSenhaN = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PanelTrocarLoginPadrao = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.TextBoxInfSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxSenha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxUsuario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.PanelMySqlConfig = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_testConnect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.userControlMySqlConfig1 = new GAcademia.UserControlMySqlConfig();
            this.ComboBoxPrivilegio = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.panelButtons.SuspendLayout();
            this.panelChildrens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelNewLogin)).BeginInit();
            this.PanelNewLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTrocarLoginPadrao)).BeginInit();
            this.PanelTrocarLoginPadrao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMySqlConfig)).BeginInit();
            this.PanelMySqlConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPrivilegio)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelButtons.Controls.Add(this.btn_NewLogin);
            this.panelButtons.Controls.Add(this.btn_db);
            this.panelButtons.Controls.Add(this.btn_Login);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(150, 450);
            this.panelButtons.TabIndex = 0;
            // 
            // btn_NewLogin
            // 
            this.btn_NewLogin.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_NewLogin.Location = new System.Drawing.Point(0, 106);
            this.btn_NewLogin.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_NewLogin.Name = "btn_NewLogin";
            this.btn_NewLogin.Palette = this.kryptonPaletteButtons;
            this.btn_NewLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_NewLogin.Size = new System.Drawing.Size(160, 53);
            this.btn_NewLogin.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_NewLogin.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_NewLogin.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_NewLogin.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_NewLogin.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_NewLogin.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_NewLogin.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewLogin.TabIndex = 8;
            this.btn_NewLogin.Values.Text = "Adicionar Novo Login";
            this.btn_NewLogin.Click += new System.EventHandler(this.btn_NewLogin_Click);
            // 
            // kryptonPaletteButtons
            // 
            this.kryptonPaletteButtons.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalOffice2003;
            this.kryptonPaletteButtons.ButtonSpecs.Close.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom1;
            this.kryptonPaletteButtons.ButtonSpecs.Close.Text = "O";
            this.kryptonPaletteButtons.ButtonSpecs.FormClose.AllowInheritImage = false;
            this.kryptonPaletteButtons.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonSpecs.FormClose.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom1;
            this.kryptonPaletteButtons.ButtonSpecs.FormClose.Text = "O";
            this.kryptonPaletteButtons.ButtonSpecs.FormMax.AllowInheritImage = false;
            this.kryptonPaletteButtons.ButtonSpecs.FormMax.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom2;
            this.kryptonPaletteButtons.ButtonSpecs.FormMax.Text = "O";
            this.kryptonPaletteButtons.ButtonSpecs.FormMin.AllowInheritImage = false;
            this.kryptonPaletteButtons.ButtonSpecs.FormMin.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom2;
            this.kryptonPaletteButtons.ButtonSpecs.FormMin.Text = "O";
            this.kryptonPaletteButtons.ButtonSpecs.FormRestore.AllowInheritImage = false;
            this.kryptonPaletteButtons.ButtonSpecs.FormRestore.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom2;
            this.kryptonPaletteButtons.ButtonSpecs.FormRestore.Text = "O";
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 4;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DarkRed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DarkRed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Montserrat", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom1.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Back.Color1 = System.Drawing.Color.Maroon;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Back.Color2 = System.Drawing.Color.DarkRed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateNormal.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StatePressed.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StatePressed.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.kryptonPaletteButtons.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.kryptonPaletteButtons.ControlStyles.ControlCommon.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ControlStyles.ControlCommon.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ControlStyles.ControlCommon.StateNormal.Back.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.ControlStyles.ControlCommon.StateNormal.Back.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPaletteButtons.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.kryptonPaletteButtons.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.kryptonPaletteButtons.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.kryptonPaletteButtons.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPaletteButtons.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.kryptonPaletteButtons.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.kryptonPaletteButtons.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            // 
            // btn_db
            // 
            this.btn_db.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_db.Location = new System.Drawing.Point(0, 53);
            this.btn_db.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_db.Name = "btn_db";
            this.btn_db.Palette = this.kryptonPaletteButtons;
            this.btn_db.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_db.Size = new System.Drawing.Size(160, 53);
            this.btn_db.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_db.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_db.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_db.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_db.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_db.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_db.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_db.TabIndex = 7;
            this.btn_db.Values.Text = "Configurar MySql";
            this.btn_db.Click += new System.EventHandler(this.btn_db_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_Login.Location = new System.Drawing.Point(0, 0);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Palette = this.kryptonPaletteButtons;
            this.btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Login.Size = new System.Drawing.Size(160, 53);
            this.btn_Login.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Login.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Login.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Login.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Login.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Login.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Login.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.TabIndex = 6;
            this.btn_Login.Values.Text = "Trocar Senha Admin";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panelChildrens
            // 
            this.panelChildrens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.panelChildrens.Controls.Add(this.PanelNewLogin);
            this.panelChildrens.Controls.Add(this.PanelTrocarLoginPadrao);
            this.panelChildrens.Controls.Add(this.PanelMySqlConfig);
            this.panelChildrens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildrens.Location = new System.Drawing.Point(150, 0);
            this.panelChildrens.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelChildrens.Name = "panelChildrens";
            this.panelChildrens.Size = new System.Drawing.Size(650, 450);
            this.panelChildrens.TabIndex = 1;
            // 
            // PanelNewLogin
            // 
            this.PanelNewLogin.Controls.Add(this.ComboBoxPrivilegio);
            this.PanelNewLogin.Controls.Add(this.bnt_salvarN);
            this.PanelNewLogin.Controls.Add(this.textBoxLoginN);
            this.PanelNewLogin.Controls.Add(this.textBoxSenhaN);
            this.PanelNewLogin.Controls.Add(this.textBoxInfLoginN);
            this.PanelNewLogin.Controls.Add(this.textBoxInfSenhaN);
            this.PanelNewLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNewLogin.Location = new System.Drawing.Point(0, 0);
            this.PanelNewLogin.Name = "PanelNewLogin";
            this.PanelNewLogin.Size = new System.Drawing.Size(650, 450);
            this.PanelNewLogin.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelNewLogin.TabIndex = 63;
            // 
            // bnt_salvarN
            // 
            this.bnt_salvarN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bnt_salvarN.Location = new System.Drawing.Point(208, 303);
            this.bnt_salvarN.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.bnt_salvarN.Name = "bnt_salvarN";
            this.bnt_salvarN.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bnt_salvarN.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bnt_salvarN.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.bnt_salvarN.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.bnt_salvarN.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.bnt_salvarN.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.bnt_salvarN.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.bnt_salvarN.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.OverrideFocus.Border.Rounding = 20;
            this.bnt_salvarN.Size = new System.Drawing.Size(198, 32);
            this.bnt_salvarN.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bnt_salvarN.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.bnt_salvarN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.StateCommon.Border.Rounding = 20;
            this.bnt_salvarN.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bnt_salvarN.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnt_salvarN.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bnt_salvarN.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.bnt_salvarN.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bnt_salvarN.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.StateNormal.Border.Rounding = 20;
            this.bnt_salvarN.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.bnt_salvarN.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.bnt_salvarN.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.bnt_salvarN.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.bnt_salvarN.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.bnt_salvarN.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.bnt_salvarN.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.bnt_salvarN.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.bnt_salvarN.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.bnt_salvarN.TabIndex = 67;
            this.bnt_salvarN.Values.Text = "Salvar";
            this.bnt_salvarN.Click += new System.EventHandler(this.bnt_salvarN_Click);
            // 
            // textBoxLoginN
            // 
            this.textBoxLoginN.AlwaysActive = false;
            this.textBoxLoginN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLoginN.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxLoginN.Location = new System.Drawing.Point(252, 106);
            this.textBoxLoginN.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxLoginN.MinimumSize = new System.Drawing.Size(138, 32);
            this.textBoxLoginN.Name = "textBoxLoginN";
            this.textBoxLoginN.Size = new System.Drawing.Size(253, 32);
            this.textBoxLoginN.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxLoginN.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxLoginN.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxLoginN.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxLoginN.StateActive.Border.Rounding = 20;
            this.textBoxLoginN.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxLoginN.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginN.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxLoginN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxLoginN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxLoginN.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxLoginN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxLoginN.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxLoginN.StateDisabled.Border.Rounding = 20;
            this.textBoxLoginN.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLoginN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxLoginN.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxLoginN.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxLoginN.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxLoginN.StateNormal.Border.Rounding = 20;
            this.textBoxLoginN.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxLoginN.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginN.TabIndex = 66;
            this.textBoxLoginN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSenhaN
            // 
            this.textBoxSenhaN.AlwaysActive = false;
            this.textBoxSenhaN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenhaN.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxSenhaN.Location = new System.Drawing.Point(252, 168);
            this.textBoxSenhaN.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxSenhaN.MinimumSize = new System.Drawing.Size(138, 32);
            this.textBoxSenhaN.Name = "textBoxSenhaN";
            this.textBoxSenhaN.PasswordChar = '●';
            this.textBoxSenhaN.Size = new System.Drawing.Size(253, 32);
            this.textBoxSenhaN.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenhaN.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxSenhaN.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxSenhaN.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenhaN.StateActive.Border.Rounding = 20;
            this.textBoxSenhaN.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxSenhaN.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaN.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxSenhaN.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenhaN.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenhaN.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenhaN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenhaN.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenhaN.StateDisabled.Border.Rounding = 20;
            this.textBoxSenhaN.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSenhaN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenhaN.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenhaN.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxSenhaN.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenhaN.StateNormal.Border.Rounding = 20;
            this.textBoxSenhaN.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSenhaN.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenhaN.TabIndex = 65;
            this.textBoxSenhaN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxSenhaN.UseSystemPasswordChar = true;
            // 
            // textBoxInfLoginN
            // 
            this.textBoxInfLoginN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfLoginN.Enabled = false;
            this.textBoxInfLoginN.Location = new System.Drawing.Point(106, 106);
            this.textBoxInfLoginN.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxInfLoginN.MaximumSize = new System.Drawing.Size(146, 32);
            this.textBoxInfLoginN.MaxLength = 1000;
            this.textBoxInfLoginN.MinimumSize = new System.Drawing.Size(146, 32);
            this.textBoxInfLoginN.Name = "textBoxInfLoginN";
            this.textBoxInfLoginN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.textBoxInfLoginN.ReadOnly = true;
            this.textBoxInfLoginN.ShortcutsEnabled = false;
            this.textBoxInfLoginN.Size = new System.Drawing.Size(146, 32);
            this.textBoxInfLoginN.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfLoginN.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxInfLoginN.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxInfLoginN.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxInfLoginN.StateActive.Border.Rounding = 20;
            this.textBoxInfLoginN.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxInfLoginN.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfLoginN.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.textBoxInfLoginN.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfLoginN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxInfLoginN.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxInfLoginN.StateDisabled.Border.Rounding = 20;
            this.textBoxInfLoginN.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfLoginN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfLoginN.TabIndex = 64;
            this.textBoxInfLoginN.TabStop = false;
            this.textBoxInfLoginN.Text = "Login";
            this.textBoxInfLoginN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInfSenhaN
            // 
            this.textBoxInfSenhaN.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInfSenhaN.Enabled = false;
            this.textBoxInfSenhaN.Location = new System.Drawing.Point(106, 168);
            this.textBoxInfSenhaN.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxInfSenhaN.MaximumSize = new System.Drawing.Size(146, 32);
            this.textBoxInfSenhaN.MaxLength = 1000;
            this.textBoxInfSenhaN.MinimumSize = new System.Drawing.Size(146, 32);
            this.textBoxInfSenhaN.Name = "textBoxInfSenhaN";
            this.textBoxInfSenhaN.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.textBoxInfSenhaN.ReadOnly = true;
            this.textBoxInfSenhaN.ShortcutsEnabled = false;
            this.textBoxInfSenhaN.Size = new System.Drawing.Size(146, 32);
            this.textBoxInfSenhaN.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfSenhaN.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxInfSenhaN.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxInfSenhaN.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxInfSenhaN.StateActive.Border.Rounding = 20;
            this.textBoxInfSenhaN.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxInfSenhaN.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfSenhaN.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.textBoxInfSenhaN.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfSenhaN.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxInfSenhaN.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxInfSenhaN.StateDisabled.Border.Rounding = 20;
            this.textBoxInfSenhaN.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfSenhaN.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.textBoxInfSenhaN.TabIndex = 63;
            this.textBoxInfSenhaN.TabStop = false;
            this.textBoxInfSenhaN.Text = "Senha";
            this.textBoxInfSenhaN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelTrocarLoginPadrao
            // 
            this.PanelTrocarLoginPadrao.Controls.Add(this.TextBoxInfSenha);
            this.PanelTrocarLoginPadrao.Controls.Add(this.textBoxSenha);
            this.PanelTrocarLoginPadrao.Controls.Add(this.TextBoxInfUser);
            this.PanelTrocarLoginPadrao.Controls.Add(this.textBoxUsuario);
            this.PanelTrocarLoginPadrao.Controls.Add(this.btn_Save);
            this.PanelTrocarLoginPadrao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTrocarLoginPadrao.Location = new System.Drawing.Point(0, 0);
            this.PanelTrocarLoginPadrao.Name = "PanelTrocarLoginPadrao";
            this.PanelTrocarLoginPadrao.Size = new System.Drawing.Size(650, 450);
            this.PanelTrocarLoginPadrao.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelTrocarLoginPadrao.TabIndex = 58;
            // 
            // TextBoxInfSenha
            // 
            this.TextBoxInfSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInfSenha.Enabled = false;
            this.TextBoxInfSenha.Location = new System.Drawing.Point(124, 132);
            this.TextBoxInfSenha.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfSenha.MaximumSize = new System.Drawing.Size(146, 32);
            this.TextBoxInfSenha.MaxLength = 1000;
            this.TextBoxInfSenha.MinimumSize = new System.Drawing.Size(146, 32);
            this.TextBoxInfSenha.Name = "TextBoxInfSenha";
            this.TextBoxInfSenha.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfSenha.ReadOnly = true;
            this.TextBoxInfSenha.ShortcutsEnabled = false;
            this.TextBoxInfSenha.Size = new System.Drawing.Size(146, 32);
            this.TextBoxInfSenha.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfSenha.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfSenha.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfSenha.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfSenha.StateActive.Border.Rounding = 20;
            this.TextBoxInfSenha.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfSenha.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfSenha.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfSenha.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfSenha.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfSenha.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfSenha.StateDisabled.Border.Rounding = 20;
            this.TextBoxInfSenha.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfSenha.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfSenha.TabIndex = 62;
            this.TextBoxInfSenha.TabStop = false;
            this.TextBoxInfSenha.Text = "Senha";
            this.TextBoxInfSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.AlwaysActive = false;
            this.textBoxSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSenha.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxSenha.Location = new System.Drawing.Point(268, 132);
            this.textBoxSenha.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxSenha.MinimumSize = new System.Drawing.Size(138, 32);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(253, 32);
            this.textBoxSenha.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenha.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxSenha.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxSenha.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenha.StateActive.Border.Rounding = 20;
            this.textBoxSenha.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxSenha.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxSenha.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenha.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenha.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenha.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenha.StateDisabled.Border.Rounding = 20;
            this.textBoxSenha.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSenha.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxSenha.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxSenha.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxSenha.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxSenha.StateNormal.Border.Rounding = 20;
            this.textBoxSenha.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxSenha.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSenha.TabIndex = 61;
            this.textBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfUser
            // 
            this.TextBoxInfUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxInfUser.Enabled = false;
            this.TextBoxInfUser.Location = new System.Drawing.Point(124, 70);
            this.TextBoxInfUser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfUser.MaximumSize = new System.Drawing.Size(146, 32);
            this.TextBoxInfUser.MaxLength = 1000;
            this.TextBoxInfUser.MinimumSize = new System.Drawing.Size(146, 32);
            this.TextBoxInfUser.Name = "TextBoxInfUser";
            this.TextBoxInfUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfUser.ReadOnly = true;
            this.TextBoxInfUser.ShortcutsEnabled = false;
            this.TextBoxInfUser.Size = new System.Drawing.Size(146, 32);
            this.TextBoxInfUser.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfUser.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfUser.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfUser.StateActive.Border.Rounding = 20;
            this.TextBoxInfUser.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfUser.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfUser.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfUser.StateDisabled.Border.Rounding = 20;
            this.TextBoxInfUser.StateDisabled.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfUser.TabIndex = 60;
            this.TextBoxInfUser.TabStop = false;
            this.TextBoxInfUser.Text = "Usuário";
            this.TextBoxInfUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.AlwaysActive = false;
            this.textBoxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUsuario.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxUsuario.Location = new System.Drawing.Point(268, 70);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxUsuario.MinimumSize = new System.Drawing.Size(138, 32);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(253, 32);
            this.textBoxUsuario.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxUsuario.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxUsuario.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxUsuario.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsuario.StateActive.Border.Rounding = 20;
            this.textBoxUsuario.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxUsuario.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxUsuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxUsuario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsuario.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxUsuario.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxUsuario.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsuario.StateDisabled.Border.Rounding = 20;
            this.textBoxUsuario.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxUsuario.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxUsuario.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxUsuario.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxUsuario.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxUsuario.StateNormal.Border.Rounding = 20;
            this.textBoxUsuario.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxUsuario.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.TabIndex = 59;
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Save.Location = new System.Drawing.Point(229, 201);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_Save.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_Save.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_Save.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_Save.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_Save.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_Save.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_Save.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.OverrideFocus.Border.Rounding = 20;
            this.btn_Save.Size = new System.Drawing.Size(198, 32);
            this.btn_Save.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_Save.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_Save.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.StateCommon.Border.Rounding = 20;
            this.btn_Save.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Save.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_Save.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_Save.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.StateNormal.Border.Rounding = 20;
            this.btn_Save.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_Save.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_Save.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btn_Save.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_Save.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_Save.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_Save.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_Save.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_Save.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Save.TabIndex = 58;
            this.btn_Save.Values.Text = "Salvar";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // PanelMySqlConfig
            // 
            this.PanelMySqlConfig.Controls.Add(this.btn_testConnect);
            this.PanelMySqlConfig.Controls.Add(this.userControlMySqlConfig1);
            this.PanelMySqlConfig.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMySqlConfig.Location = new System.Drawing.Point(0, 0);
            this.PanelMySqlConfig.Name = "PanelMySqlConfig";
            this.PanelMySqlConfig.Size = new System.Drawing.Size(650, 450);
            this.PanelMySqlConfig.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.StateDisabled.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.StateDisabled.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.StateNormal.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.StateNormal.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.PanelMySqlConfig.TabIndex = 0;
            // 
            // btn_testConnect
            // 
            this.btn_testConnect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_testConnect.Location = new System.Drawing.Point(274, 283);
            this.btn_testConnect.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_testConnect.Name = "btn_testConnect";
            this.btn_testConnect.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_testConnect.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_testConnect.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_testConnect.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_testConnect.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_testConnect.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_testConnect.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_testConnect.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.OverrideFocus.Border.Rounding = 20;
            this.btn_testConnect.Size = new System.Drawing.Size(207, 32);
            this.btn_testConnect.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_testConnect.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_testConnect.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.StateCommon.Border.Rounding = 20;
            this.btn_testConnect.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_testConnect.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_testConnect.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_testConnect.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_testConnect.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_testConnect.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.StateNormal.Border.Rounding = 20;
            this.btn_testConnect.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_testConnect.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_testConnect.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btn_testConnect.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_testConnect.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_testConnect.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_testConnect.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_testConnect.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_testConnect.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_testConnect.TabIndex = 28;
            this.btn_testConnect.Values.Text = "Testar Conexão";
            this.btn_testConnect.Click += new System.EventHandler(this.btn_testConnect_Click);
            // 
            // userControlMySqlConfig1
            // 
            this.userControlMySqlConfig1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.userControlMySqlConfig1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMySqlConfig1.Location = new System.Drawing.Point(0, 0);
            this.userControlMySqlConfig1.Name = "userControlMySqlConfig1";
            this.userControlMySqlConfig1.Size = new System.Drawing.Size(650, 450);
            this.userControlMySqlConfig1.TabIndex = 0;
            // 
            // ComboBoxPrivilegio
            // 
            this.ComboBoxPrivilegio.AlwaysActive = false;
            this.ComboBoxPrivilegio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxPrivilegio.DropDownWidth = 174;
            this.ComboBoxPrivilegio.Location = new System.Drawing.Point(180, 227);
            this.ComboBoxPrivilegio.Name = "ComboBoxPrivilegio";
            this.ComboBoxPrivilegio.Size = new System.Drawing.Size(266, 33);
            this.ComboBoxPrivilegio.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateActive.ComboBox.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.ComboBoxPrivilegio.StateActive.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ComboBoxPrivilegio.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxPrivilegio.StateActive.ComboBox.Border.Rounding = 20;
            this.ComboBoxPrivilegio.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ComboBoxPrivilegio.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPrivilegio.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxPrivilegio.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPrivilegio.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxPrivilegio.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Border.Rounding = 20;
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxPrivilegio.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxPrivilegio.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateNormal.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ComboBoxPrivilegio.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ComboBoxPrivilegio.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxPrivilegio.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxPrivilegio.StateTracking.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ComboBoxPrivilegio.StateTracking.Item.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.ComboBoxPrivilegio.StateTracking.Item.Border.Color2 = System.Drawing.SystemColors.HotTrack;
            this.ComboBoxPrivilegio.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxPrivilegio.TabIndex = 68;
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
            this.panelChildrens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PanelNewLogin)).EndInit();
            this.PanelNewLogin.ResumeLayout(false);
            this.PanelNewLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelTrocarLoginPadrao)).EndInit();
            this.PanelTrocarLoginPadrao.ResumeLayout(false);
            this.PanelTrocarLoginPadrao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PanelMySqlConfig)).EndInit();
            this.PanelMySqlConfig.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxPrivilegio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelChildrens;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelMySqlConfig;
        private UserControlMySqlConfig userControlMySqlConfig1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_testConnect;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelTrocarLoginPadrao;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSenha;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxUsuario;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_NewLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_db;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel PanelNewLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonButton bnt_salvarN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxLoginN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxSenhaN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxInfLoginN;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxInfSenhaN;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxPrivilegio;
    }
}