
namespace GAcademia.Forms
{
    partial class Alunos
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
            this.tBoxSearchUser = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_searchUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBoxId = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfNome = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfNasc = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxRg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxEndereco = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxCidade = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxObjetivo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfRg = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfTelefone = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfEndeco = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfCidade = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfObjetivo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxBairro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxEstado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxObs = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfCpf = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfBairro = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfEstado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfObs = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfNumero = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxNumComp1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfNumComp = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btn_addUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_UpdUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_DelUser = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.searchResult = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MtextBoxTelefone = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.MtextBoxCpf = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            this.MtextBoxNascimento = new ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxSearchUser
            // 
            this.tBoxSearchUser.AlwaysActive = false;
            this.tBoxSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tBoxSearchUser.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.tBoxSearchUser.Location = new System.Drawing.Point(120, 15);
            this.tBoxSearchUser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.tBoxSearchUser.Name = "tBoxSearchUser";
            this.tBoxSearchUser.Size = new System.Drawing.Size(387, 32);
            this.tBoxSearchUser.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.tBoxSearchUser.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.tBoxSearchUser.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.tBoxSearchUser.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBoxSearchUser.StateActive.Border.Rounding = 20;
            this.tBoxSearchUser.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.tBoxSearchUser.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSearchUser.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.tBoxSearchUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tBoxSearchUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBoxSearchUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.tBoxSearchUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tBoxSearchUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBoxSearchUser.StateDisabled.Border.Rounding = 20;
            this.tBoxSearchUser.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBoxSearchUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.tBoxSearchUser.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.tBoxSearchUser.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.tBoxSearchUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tBoxSearchUser.StateNormal.Border.Rounding = 20;
            this.tBoxSearchUser.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tBoxSearchUser.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxSearchUser.TabIndex = 33;
            this.tBoxSearchUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxSearchUser.TextChanged += new System.EventHandler(this.tBoxSearchUser_TextChanged);
            // 
            // btn_searchUser
            // 
            this.btn_searchUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_searchUser.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.LowProfile;
            this.btn_searchUser.Location = new System.Drawing.Point(41, 15);
            this.btn_searchUser.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_searchUser.MaximumSize = new System.Drawing.Size(0, 32);
            this.btn_searchUser.MinimumSize = new System.Drawing.Size(79, 32);
            this.btn_searchUser.Name = "btn_searchUser";
            this.btn_searchUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_searchUser.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_searchUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_searchUser.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_searchUser.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_searchUser.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_searchUser.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.OverrideFocus.Border.Rounding = 20;
            this.btn_searchUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_searchUser.Size = new System.Drawing.Size(79, 32);
            this.btn_searchUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_searchUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_searchUser.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_searchUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.StateCommon.Border.Rounding = 20;
            this.btn_searchUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_searchUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_searchUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_searchUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_searchUser.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_searchUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.StateNormal.Border.Rounding = 20;
            this.btn_searchUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_searchUser.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_searchUser.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_searchUser.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_searchUser.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_searchUser.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_searchUser.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.btn_searchUser.TabIndex = 34;
            this.btn_searchUser.Values.Text = "Selecionar";
            this.btn_searchUser.Click += new System.EventHandler(this.btn_searchUser_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.AlwaysActive = false;
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxId.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxId.Location = new System.Drawing.Point(589, 12);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(86, 32);
            this.textBoxId.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxId.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxId.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxId.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxId.StateActive.Border.Rounding = 20;
            this.textBoxId.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxId.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxId.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxId.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxId.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxId.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxId.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxId.StateDisabled.Border.Rounding = 20;
            this.textBoxId.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxId.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxId.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxId.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxId.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxId.StateNormal.Border.Rounding = 20;
            this.textBoxId.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxId.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.TabIndex = 35;
            this.textBoxId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfID
            // 
            this.TextBoxInfID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfID.Location = new System.Drawing.Point(675, 12);
            this.TextBoxInfID.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfID.MaxLength = 10;
            this.TextBoxInfID.Name = "TextBoxInfID";
            this.TextBoxInfID.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfID.ReadOnly = true;
            this.TextBoxInfID.Size = new System.Drawing.Size(40, 32);
            this.TextBoxInfID.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfID.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfID.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfID.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfID.StateActive.Border.Rounding = 20;
            this.TextBoxInfID.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfID.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfID.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfID.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfID.TabIndex = 36;
            this.TextBoxInfID.TabStop = false;
            this.TextBoxInfID.Text = "ID";
            this.TextBoxInfID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNome
            // 
            this.textBoxNome.AlwaysActive = false;
            this.textBoxNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNome.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxNome.Location = new System.Drawing.Point(99, 68);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(273, 32);
            this.textBoxNome.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNome.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNome.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNome.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNome.StateActive.Border.Rounding = 20;
            this.textBoxNome.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxNome.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxNome.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNome.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNome.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNome.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNome.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxNome.StateDisabled.Border.Rounding = 20;
            this.textBoxNome.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNome.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNome.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNome.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNome.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNome.StateNormal.Border.Rounding = 20;
            this.textBoxNome.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNome.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.TabIndex = 37;
            this.textBoxNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfNome
            // 
            this.TextBoxInfNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfNome.Location = new System.Drawing.Point(39, 68);
            this.TextBoxInfNome.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfNome.MaxLength = 10;
            this.TextBoxInfNome.Name = "TextBoxInfNome";
            this.TextBoxInfNome.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfNome.ReadOnly = true;
            this.TextBoxInfNome.Size = new System.Drawing.Size(60, 32);
            this.TextBoxInfNome.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNome.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfNome.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfNome.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfNome.StateActive.Border.Rounding = 20;
            this.TextBoxInfNome.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfNome.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfNome.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfNome.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNome.TabIndex = 38;
            this.TextBoxInfNome.TabStop = false;
            this.TextBoxInfNome.Text = "Nome";
            this.TextBoxInfNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfNasc
            // 
            this.TextBoxInfNasc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfNasc.Location = new System.Drawing.Point(635, 68);
            this.TextBoxInfNasc.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfNasc.MaxLength = 10;
            this.TextBoxInfNasc.Name = "TextBoxInfNasc";
            this.TextBoxInfNasc.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfNasc.ReadOnly = true;
            this.TextBoxInfNasc.Size = new System.Drawing.Size(80, 32);
            this.TextBoxInfNasc.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNasc.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfNasc.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfNasc.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfNasc.StateActive.Border.Rounding = 20;
            this.TextBoxInfNasc.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfNasc.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfNasc.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfNasc.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNasc.TabIndex = 40;
            this.TextBoxInfNasc.TabStop = false;
            this.TextBoxInfNasc.Text = "Nascimento";
            this.TextBoxInfNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRg
            // 
            this.textBoxRg.AlwaysActive = false;
            this.textBoxRg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxRg.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxRg.Location = new System.Drawing.Point(99, 116);
            this.textBoxRg.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxRg.Name = "textBoxRg";
            this.textBoxRg.Size = new System.Drawing.Size(273, 32);
            this.textBoxRg.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRg.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxRg.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxRg.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRg.StateActive.Border.Rounding = 20;
            this.textBoxRg.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxRg.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRg.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxRg.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRg.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRg.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRg.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRg.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxRg.StateDisabled.Border.Rounding = 20;
            this.textBoxRg.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRg.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRg.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRg.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxRg.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRg.StateNormal.Border.Rounding = 20;
            this.textBoxRg.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRg.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRg.TabIndex = 41;
            this.textBoxRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEndereco
            // 
            this.textBoxEndereco.AlwaysActive = false;
            this.textBoxEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxEndereco.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxEndereco.Location = new System.Drawing.Point(99, 221);
            this.textBoxEndereco.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxEndereco.Name = "textBoxEndereco";
            this.textBoxEndereco.Size = new System.Drawing.Size(273, 32);
            this.textBoxEndereco.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEndereco.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEndereco.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEndereco.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEndereco.StateActive.Border.Rounding = 20;
            this.textBoxEndereco.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxEndereco.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxEndereco.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEndereco.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEndereco.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEndereco.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEndereco.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEndereco.StateDisabled.Border.Rounding = 20;
            this.textBoxEndereco.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEndereco.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEndereco.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEndereco.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEndereco.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEndereco.StateNormal.Border.Rounding = 20;
            this.textBoxEndereco.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEndereco.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEndereco.TabIndex = 43;
            this.textBoxEndereco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxCidade
            // 
            this.textBoxCidade.AlwaysActive = false;
            this.textBoxCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxCidade.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxCidade.Location = new System.Drawing.Point(99, 282);
            this.textBoxCidade.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxCidade.Name = "textBoxCidade";
            this.textBoxCidade.Size = new System.Drawing.Size(273, 32);
            this.textBoxCidade.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxCidade.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxCidade.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxCidade.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxCidade.StateActive.Border.Rounding = 20;
            this.textBoxCidade.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxCidade.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxCidade.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxCidade.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxCidade.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxCidade.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxCidade.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxCidade.StateDisabled.Border.Rounding = 20;
            this.textBoxCidade.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCidade.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxCidade.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxCidade.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxCidade.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxCidade.StateNormal.Border.Rounding = 20;
            this.textBoxCidade.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxCidade.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCidade.TabIndex = 44;
            this.textBoxCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxObjetivo
            // 
            this.textBoxObjetivo.AlwaysActive = false;
            this.textBoxObjetivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxObjetivo.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxObjetivo.Location = new System.Drawing.Point(99, 335);
            this.textBoxObjetivo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxObjetivo.Name = "textBoxObjetivo";
            this.textBoxObjetivo.Size = new System.Drawing.Size(273, 32);
            this.textBoxObjetivo.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObjetivo.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxObjetivo.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxObjetivo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxObjetivo.StateActive.Border.Rounding = 20;
            this.textBoxObjetivo.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxObjetivo.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObjetivo.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxObjetivo.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObjetivo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxObjetivo.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObjetivo.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObjetivo.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxObjetivo.StateDisabled.Border.Rounding = 20;
            this.textBoxObjetivo.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxObjetivo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObjetivo.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObjetivo.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxObjetivo.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxObjetivo.StateNormal.Border.Rounding = 20;
            this.textBoxObjetivo.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxObjetivo.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObjetivo.TabIndex = 45;
            this.textBoxObjetivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfRg
            // 
            this.TextBoxInfRg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfRg.Location = new System.Drawing.Point(39, 116);
            this.TextBoxInfRg.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfRg.MaxLength = 10;
            this.TextBoxInfRg.Name = "TextBoxInfRg";
            this.TextBoxInfRg.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfRg.ReadOnly = true;
            this.TextBoxInfRg.Size = new System.Drawing.Size(61, 32);
            this.TextBoxInfRg.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfRg.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfRg.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfRg.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfRg.StateActive.Border.Rounding = 20;
            this.TextBoxInfRg.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfRg.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfRg.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfRg.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfRg.TabIndex = 46;
            this.TextBoxInfRg.TabStop = false;
            this.TextBoxInfRg.Text = "RG";
            this.TextBoxInfRg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfTelefone
            // 
            this.TextBoxInfTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfTelefone.Location = new System.Drawing.Point(39, 171);
            this.TextBoxInfTelefone.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfTelefone.MaxLength = 10;
            this.TextBoxInfTelefone.Name = "TextBoxInfTelefone";
            this.TextBoxInfTelefone.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfTelefone.ReadOnly = true;
            this.TextBoxInfTelefone.Size = new System.Drawing.Size(61, 32);
            this.TextBoxInfTelefone.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfTelefone.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfTelefone.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfTelefone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfTelefone.StateActive.Border.Rounding = 20;
            this.TextBoxInfTelefone.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfTelefone.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfTelefone.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfTelefone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfTelefone.TabIndex = 47;
            this.TextBoxInfTelefone.TabStop = false;
            this.TextBoxInfTelefone.Text = "Telefone";
            this.TextBoxInfTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfEndeco
            // 
            this.TextBoxInfEndeco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfEndeco.Location = new System.Drawing.Point(39, 221);
            this.TextBoxInfEndeco.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfEndeco.MaxLength = 10;
            this.TextBoxInfEndeco.Name = "TextBoxInfEndeco";
            this.TextBoxInfEndeco.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfEndeco.ReadOnly = true;
            this.TextBoxInfEndeco.Size = new System.Drawing.Size(61, 32);
            this.TextBoxInfEndeco.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEndeco.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfEndeco.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfEndeco.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfEndeco.StateActive.Border.Rounding = 20;
            this.TextBoxInfEndeco.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfEndeco.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfEndeco.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfEndeco.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEndeco.TabIndex = 48;
            this.TextBoxInfEndeco.TabStop = false;
            this.TextBoxInfEndeco.Text = "Endereço";
            this.TextBoxInfEndeco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfCidade
            // 
            this.TextBoxInfCidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfCidade.Location = new System.Drawing.Point(39, 282);
            this.TextBoxInfCidade.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfCidade.MaxLength = 10;
            this.TextBoxInfCidade.Name = "TextBoxInfCidade";
            this.TextBoxInfCidade.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfCidade.ReadOnly = true;
            this.TextBoxInfCidade.Size = new System.Drawing.Size(61, 32);
            this.TextBoxInfCidade.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfCidade.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfCidade.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfCidade.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfCidade.StateActive.Border.Rounding = 20;
            this.TextBoxInfCidade.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfCidade.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfCidade.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfCidade.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfCidade.TabIndex = 49;
            this.TextBoxInfCidade.TabStop = false;
            this.TextBoxInfCidade.Text = "Cidade";
            this.TextBoxInfCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfObjetivo
            // 
            this.TextBoxInfObjetivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfObjetivo.Location = new System.Drawing.Point(39, 335);
            this.TextBoxInfObjetivo.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfObjetivo.MaxLength = 10;
            this.TextBoxInfObjetivo.Name = "TextBoxInfObjetivo";
            this.TextBoxInfObjetivo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfObjetivo.ReadOnly = true;
            this.TextBoxInfObjetivo.Size = new System.Drawing.Size(61, 32);
            this.TextBoxInfObjetivo.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfObjetivo.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfObjetivo.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfObjetivo.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfObjetivo.StateActive.Border.Rounding = 20;
            this.TextBoxInfObjetivo.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfObjetivo.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfObjetivo.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfObjetivo.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfObjetivo.TabIndex = 50;
            this.TextBoxInfObjetivo.TabStop = false;
            this.TextBoxInfObjetivo.Text = "Objetivo";
            this.TextBoxInfObjetivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AlwaysActive = false;
            this.textBoxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxEmail.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxEmail.Location = new System.Drawing.Point(397, 171);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(258, 32);
            this.textBoxEmail.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEmail.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEmail.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEmail.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEmail.StateActive.Border.Rounding = 20;
            this.textBoxEmail.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxEmail.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxEmail.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEmail.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEmail.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEmail.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEmail.StateDisabled.Border.Rounding = 20;
            this.textBoxEmail.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEmail.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEmail.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEmail.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEmail.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEmail.StateNormal.Border.Rounding = 20;
            this.textBoxEmail.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEmail.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.TabIndex = 52;
            this.textBoxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.AlwaysActive = false;
            this.textBoxBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxBairro.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxBairro.Location = new System.Drawing.Point(527, 221);
            this.textBoxBairro.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(138, 32);
            this.textBoxBairro.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxBairro.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxBairro.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxBairro.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxBairro.StateActive.Border.Rounding = 20;
            this.textBoxBairro.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxBairro.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxBairro.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxBairro.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxBairro.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxBairro.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxBairro.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxBairro.StateDisabled.Border.Rounding = 20;
            this.textBoxBairro.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxBairro.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxBairro.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxBairro.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxBairro.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxBairro.StateNormal.Border.Rounding = 20;
            this.textBoxBairro.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxBairro.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBairro.TabIndex = 54;
            // 
            // textBoxEstado
            // 
            this.textBoxEstado.AlwaysActive = false;
            this.textBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxEstado.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxEstado.Location = new System.Drawing.Point(397, 282);
            this.textBoxEstado.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxEstado.Name = "textBoxEstado";
            this.textBoxEstado.Size = new System.Drawing.Size(258, 32);
            this.textBoxEstado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEstado.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxEstado.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEstado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEstado.StateActive.Border.Rounding = 20;
            this.textBoxEstado.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxEstado.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxEstado.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEstado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxEstado.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEstado.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEstado.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEstado.StateDisabled.Border.Rounding = 20;
            this.textBoxEstado.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEstado.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxEstado.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxEstado.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxEstado.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxEstado.StateNormal.Border.Rounding = 20;
            this.textBoxEstado.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxEstado.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEstado.TabIndex = 55;
            this.textBoxEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxObs
            // 
            this.textBoxObs.AlwaysActive = false;
            this.textBoxObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxObs.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxObs.Location = new System.Drawing.Point(397, 335);
            this.textBoxObs.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(238, 32);
            this.textBoxObs.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObs.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxObs.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxObs.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxObs.StateActive.Border.Rounding = 20;
            this.textBoxObs.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxObs.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObs.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxObs.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObs.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxObs.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObs.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObs.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxObs.StateDisabled.Border.Rounding = 20;
            this.textBoxObs.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxObs.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxObs.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxObs.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxObs.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxObs.StateNormal.Border.Rounding = 20;
            this.textBoxObs.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxObs.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxObs.TabIndex = 56;
            this.textBoxObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfCpf
            // 
            this.TextBoxInfCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfCpf.Location = new System.Drawing.Point(655, 116);
            this.TextBoxInfCpf.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfCpf.MaxLength = 10;
            this.TextBoxInfCpf.Name = "TextBoxInfCpf";
            this.TextBoxInfCpf.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfCpf.ReadOnly = true;
            this.TextBoxInfCpf.Size = new System.Drawing.Size(60, 32);
            this.TextBoxInfCpf.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfCpf.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfCpf.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfCpf.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfCpf.StateActive.Border.Rounding = 20;
            this.TextBoxInfCpf.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfCpf.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfCpf.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfCpf.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfCpf.TabIndex = 57;
            this.TextBoxInfCpf.TabStop = false;
            this.TextBoxInfCpf.Text = "CPF";
            this.TextBoxInfCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfEmail
            // 
            this.TextBoxInfEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfEmail.Location = new System.Drawing.Point(655, 171);
            this.TextBoxInfEmail.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfEmail.MaxLength = 10;
            this.TextBoxInfEmail.Name = "TextBoxInfEmail";
            this.TextBoxInfEmail.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfEmail.ReadOnly = true;
            this.TextBoxInfEmail.Size = new System.Drawing.Size(60, 32);
            this.TextBoxInfEmail.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEmail.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfEmail.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfEmail.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfEmail.StateActive.Border.Rounding = 20;
            this.TextBoxInfEmail.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfEmail.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfEmail.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfEmail.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEmail.TabIndex = 58;
            this.TextBoxInfEmail.TabStop = false;
            this.TextBoxInfEmail.Text = "E-mail";
            this.TextBoxInfEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfBairro
            // 
            this.TextBoxInfBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfBairro.Location = new System.Drawing.Point(665, 221);
            this.TextBoxInfBairro.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfBairro.MaxLength = 10;
            this.TextBoxInfBairro.Name = "TextBoxInfBairro";
            this.TextBoxInfBairro.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfBairro.ReadOnly = true;
            this.TextBoxInfBairro.Size = new System.Drawing.Size(50, 32);
            this.TextBoxInfBairro.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfBairro.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfBairro.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfBairro.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfBairro.StateActive.Border.Rounding = 20;
            this.TextBoxInfBairro.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfBairro.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfBairro.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfBairro.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfBairro.TabIndex = 60;
            this.TextBoxInfBairro.TabStop = false;
            this.TextBoxInfBairro.Text = "Bairro";
            this.TextBoxInfBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfEstado
            // 
            this.TextBoxInfEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfEstado.Location = new System.Drawing.Point(655, 282);
            this.TextBoxInfEstado.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfEstado.MaxLength = 10;
            this.TextBoxInfEstado.Name = "TextBoxInfEstado";
            this.TextBoxInfEstado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfEstado.ReadOnly = true;
            this.TextBoxInfEstado.Size = new System.Drawing.Size(60, 32);
            this.TextBoxInfEstado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEstado.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfEstado.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfEstado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfEstado.StateActive.Border.Rounding = 20;
            this.TextBoxInfEstado.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfEstado.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfEstado.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfEstado.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfEstado.TabIndex = 61;
            this.TextBoxInfEstado.TabStop = false;
            this.TextBoxInfEstado.Text = "Estado";
            this.TextBoxInfEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfObs
            // 
            this.TextBoxInfObs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfObs.Location = new System.Drawing.Point(635, 335);
            this.TextBoxInfObs.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfObs.MaxLength = 10;
            this.TextBoxInfObs.Name = "TextBoxInfObs";
            this.TextBoxInfObs.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfObs.ReadOnly = true;
            this.TextBoxInfObs.Size = new System.Drawing.Size(80, 32);
            this.TextBoxInfObs.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfObs.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfObs.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfObs.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfObs.StateActive.Border.Rounding = 20;
            this.TextBoxInfObs.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfObs.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfObs.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfObs.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfObs.TabIndex = 62;
            this.TextBoxInfObs.TabStop = false;
            this.TextBoxInfObs.Text = "Observação";
            this.TextBoxInfObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.AlwaysActive = false;
            this.textBoxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNumero.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxNumero.Location = new System.Drawing.Point(462, 221);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(59, 32);
            this.textBoxNumero.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumero.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNumero.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNumero.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNumero.StateActive.Border.Rounding = 20;
            this.textBoxNumero.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxNumero.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxNumero.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumero.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNumero.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumero.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumero.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxNumero.StateDisabled.Border.Rounding = 20;
            this.textBoxNumero.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumero.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumero.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumero.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNumero.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNumero.StateNormal.Border.Rounding = 20;
            this.textBoxNumero.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumero.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.TabIndex = 63;
            this.textBoxNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxInfNumero
            // 
            this.TextBoxInfNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfNumero.Location = new System.Drawing.Point(397, 221);
            this.TextBoxInfNumero.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfNumero.MaxLength = 10;
            this.TextBoxInfNumero.Name = "TextBoxInfNumero";
            this.TextBoxInfNumero.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfNumero.ReadOnly = true;
            this.TextBoxInfNumero.Size = new System.Drawing.Size(65, 32);
            this.TextBoxInfNumero.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNumero.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfNumero.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfNumero.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfNumero.StateActive.Border.Rounding = 20;
            this.TextBoxInfNumero.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfNumero.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfNumero.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfNumero.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNumero.TabIndex = 64;
            this.TextBoxInfNumero.TabStop = false;
            this.TextBoxInfNumero.Text = "Número";
            this.TextBoxInfNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNumComp1
            // 
            this.textBoxNumComp1.AlwaysActive = false;
            this.textBoxNumComp1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.textBoxNumComp1.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxNumComp1.Location = new System.Drawing.Point(41, 408);
            this.textBoxNumComp1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.textBoxNumComp1.Name = "textBoxNumComp1";
            this.textBoxNumComp1.ReadOnly = true;
            this.textBoxNumComp1.Size = new System.Drawing.Size(59, 32);
            this.textBoxNumComp1.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumComp1.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxNumComp1.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNumComp1.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxNumComp1.StateActive.Border.Rounding = 20;
            this.textBoxNumComp1.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxNumComp1.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumComp1.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxNumComp1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumComp1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxNumComp1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumComp1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumComp1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxNumComp1.StateDisabled.Border.Rounding = 20;
            this.textBoxNumComp1.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumComp1.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxNumComp1.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxNumComp1.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxNumComp1.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxNumComp1.StateNormal.Border.Rounding = 20;
            this.textBoxNumComp1.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxNumComp1.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumComp1.TabIndex = 65;
            this.textBoxNumComp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxNumComp1.Visible = false;
            // 
            // TextBoxInfNumComp
            // 
            this.TextBoxInfNumComp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TextBoxInfNumComp.Location = new System.Drawing.Point(100, 408);
            this.TextBoxInfNumComp.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.TextBoxInfNumComp.MaxLength = 10;
            this.TextBoxInfNumComp.Name = "TextBoxInfNumComp";
            this.TextBoxInfNumComp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfNumComp.ReadOnly = true;
            this.TextBoxInfNumComp.Size = new System.Drawing.Size(47, 32);
            this.TextBoxInfNumComp.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNumComp.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfNumComp.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfNumComp.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TextBoxInfNumComp.StateActive.Border.Rounding = 20;
            this.TextBoxInfNumComp.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfNumComp.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfNumComp.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfNumComp.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfNumComp.TabIndex = 66;
            this.TextBoxInfNumComp.TabStop = false;
            this.TextBoxInfNumComp.Text = "NC";
            this.TextBoxInfNumComp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxInfNumComp.Visible = false;
            // 
            // btn_addUser
            // 
            this.btn_addUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addUser.Location = new System.Drawing.Point(223, 408);
            this.btn_addUser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_addUser.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_addUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_addUser.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_addUser.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_addUser.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_addUser.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_addUser.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.OverrideFocus.Border.Rounding = 20;
            this.btn_addUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_addUser.Size = new System.Drawing.Size(102, 32);
            this.btn_addUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_addUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_addUser.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_addUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.StateCommon.Border.Rounding = 20;
            this.btn_addUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_addUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_addUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_addUser.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_addUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.StateNormal.Border.Rounding = 20;
            this.btn_addUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_addUser.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_addUser.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btn_addUser.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_addUser.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_addUser.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_addUser.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_addUser.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_addUser.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_addUser.TabIndex = 67;
            this.btn_addUser.Values.Text = "Adicionar";
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // btn_UpdUser
            // 
            this.btn_UpdUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_UpdUser.Location = new System.Drawing.Point(328, 408);
            this.btn_UpdUser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_UpdUser.Name = "btn_UpdUser";
            this.btn_UpdUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_UpdUser.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_UpdUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_UpdUser.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_UpdUser.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_UpdUser.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_UpdUser.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_UpdUser.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.OverrideFocus.Border.Rounding = 20;
            this.btn_UpdUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_UpdUser.Size = new System.Drawing.Size(106, 32);
            this.btn_UpdUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_UpdUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_UpdUser.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_UpdUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.StateCommon.Border.Rounding = 20;
            this.btn_UpdUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_UpdUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_UpdUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_UpdUser.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_UpdUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.StateNormal.Border.Rounding = 20;
            this.btn_UpdUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_UpdUser.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_UpdUser.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btn_UpdUser.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_UpdUser.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_UpdUser.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_UpdUser.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_UpdUser.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_UpdUser.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_UpdUser.TabIndex = 68;
            this.btn_UpdUser.Values.Text = "Atualizar Dados";
            this.btn_UpdUser.Click += new System.EventHandler(this.btn_UpdUser_Click);
            // 
            // btn_DelUser
            // 
            this.btn_DelUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_DelUser.Location = new System.Drawing.Point(443, 408);
            this.btn_DelUser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_DelUser.Name = "btn_DelUser";
            this.btn_DelUser.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_DelUser.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_DelUser.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.OverrideFocus.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_DelUser.OverrideFocus.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_DelUser.OverrideFocus.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_DelUser.OverrideFocus.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_DelUser.OverrideFocus.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_DelUser.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.OverrideFocus.Border.Rounding = 20;
            this.btn_DelUser.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleOrange;
            this.btn_DelUser.Size = new System.Drawing.Size(102, 32);
            this.btn_DelUser.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_DelUser.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_DelUser.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_DelUser.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.StateCommon.Border.Rounding = 20;
            this.btn_DelUser.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_DelUser.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DelUser.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_DelUser.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateNormal.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_DelUser.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_DelUser.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.StateNormal.Border.Rounding = 20;
            this.btn_DelUser.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StatePressed.Border.Color1 = System.Drawing.Color.Blue;
            this.btn_DelUser.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.btn_DelUser.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.LinearShadow;
            this.btn_DelUser.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.btn_DelUser.StateTracking.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.btn_DelUser.StateTracking.Border.Color2 = System.Drawing.SystemColors.Highlight;
            this.btn_DelUser.StateTracking.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.btn_DelUser.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Solid;
            this.btn_DelUser.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_DelUser.TabIndex = 69;
            this.btn_DelUser.Values.Text = "Deletar";
            this.btn_DelUser.Click += new System.EventHandler(this.btn_DelUser_Click);
            // 
            // searchResult
            // 
            this.searchResult.AllowUserToAddRows = false;
            this.searchResult.AllowUserToDeleteRows = false;
            this.searchResult.AllowUserToResizeColumns = false;
            this.searchResult.AllowUserToResizeRows = false;
            this.searchResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.ColumnHeadersVisible = false;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Aluno});
            this.searchResult.Location = new System.Drawing.Point(99, 47);
            this.searchResult.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.searchResult.Name = "searchResult";
            this.searchResult.ReadOnly = true;
            this.searchResult.RowHeadersVisible = false;
            this.searchResult.Size = new System.Drawing.Size(396, 0);
            this.searchResult.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchResult.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchResult.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.searchResult.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchResult.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.searchResult.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.searchResult.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.searchResult.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.searchResult.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResult.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.searchResult.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchResult.TabIndex = 70;
            this.searchResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "idalunos";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Aluno
            // 
            this.Aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aluno.DataPropertyName = "nome";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            // 
            // MtextBoxTelefone
            // 
            this.MtextBoxTelefone.AlwaysActive = false;
            this.MtextBoxTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MtextBoxTelefone.Location = new System.Drawing.Point(100, 171);
            this.MtextBoxTelefone.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MtextBoxTelefone.Mask = "(00) 00000 - 0000";
            this.MtextBoxTelefone.Name = "MtextBoxTelefone";
            this.MtextBoxTelefone.Size = new System.Drawing.Size(272, 35);
            this.MtextBoxTelefone.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxTelefone.StateActive.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.MtextBoxTelefone.StateActive.Border.Color2 = System.Drawing.SystemColors.HotTrack;
            this.MtextBoxTelefone.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MtextBoxTelefone.StateActive.Border.Rounding = 20;
            this.MtextBoxTelefone.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxTelefone.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MtextBoxTelefone.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxTelefone.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.MtextBoxTelefone.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MtextBoxTelefone.StateNormal.Border.Rounding = 20;
            this.MtextBoxTelefone.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxTelefone.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtextBoxTelefone.TabIndex = 71;
            this.MtextBoxTelefone.Text = "(  )       - ";
            this.MtextBoxTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MtextBoxCpf
            // 
            this.MtextBoxCpf.AlwaysActive = false;
            this.MtextBoxCpf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MtextBoxCpf.Location = new System.Drawing.Point(397, 116);
            this.MtextBoxCpf.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MtextBoxCpf.Mask = "000.000.000-00";
            this.MtextBoxCpf.Name = "MtextBoxCpf";
            this.MtextBoxCpf.Size = new System.Drawing.Size(258, 35);
            this.MtextBoxCpf.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxCpf.StateActive.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.MtextBoxCpf.StateActive.Border.Color2 = System.Drawing.SystemColors.HotTrack;
            this.MtextBoxCpf.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.MtextBoxCpf.StateActive.Border.Rounding = 20;
            this.MtextBoxCpf.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxCpf.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MtextBoxCpf.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxCpf.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.MtextBoxCpf.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.MtextBoxCpf.StateNormal.Border.Rounding = 20;
            this.MtextBoxCpf.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxCpf.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtextBoxCpf.TabIndex = 72;
            this.MtextBoxCpf.Text = "   ,   ,   -";
            this.MtextBoxCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MtextBoxNascimento
            // 
            this.MtextBoxNascimento.AlwaysActive = false;
            this.MtextBoxNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MtextBoxNascimento.Location = new System.Drawing.Point(397, 68);
            this.MtextBoxNascimento.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.MtextBoxNascimento.Mask = "00 / 00 / 0000";
            this.MtextBoxNascimento.Name = "MtextBoxNascimento";
            this.MtextBoxNascimento.Size = new System.Drawing.Size(238, 35);
            this.MtextBoxNascimento.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxNascimento.StateActive.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.MtextBoxNascimento.StateActive.Border.Color2 = System.Drawing.SystemColors.HotTrack;
            this.MtextBoxNascimento.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.MtextBoxNascimento.StateActive.Border.Rounding = 20;
            this.MtextBoxNascimento.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxNascimento.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MtextBoxNascimento.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.MtextBoxNascimento.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.MtextBoxNascimento.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.MtextBoxNascimento.StateNormal.Border.Rounding = 20;
            this.MtextBoxNascimento.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MtextBoxNascimento.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtextBoxNascimento.TabIndex = 73;
            this.MtextBoxNascimento.Text = "   /    / ";
            this.MtextBoxNascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Alunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.MtextBoxNascimento);
            this.Controls.Add(this.MtextBoxCpf);
            this.Controls.Add(this.MtextBoxTelefone);
            this.Controls.Add(this.btn_DelUser);
            this.Controls.Add(this.btn_UpdUser);
            this.Controls.Add(this.btn_addUser);
            this.Controls.Add(this.TextBoxInfNumComp);
            this.Controls.Add(this.textBoxNumComp1);
            this.Controls.Add(this.TextBoxInfNumero);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.TextBoxInfObs);
            this.Controls.Add(this.TextBoxInfEstado);
            this.Controls.Add(this.TextBoxInfBairro);
            this.Controls.Add(this.TextBoxInfEmail);
            this.Controls.Add(this.TextBoxInfCpf);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.textBoxEstado);
            this.Controls.Add(this.textBoxBairro);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.TextBoxInfObjetivo);
            this.Controls.Add(this.TextBoxInfCidade);
            this.Controls.Add(this.TextBoxInfEndeco);
            this.Controls.Add(this.TextBoxInfTelefone);
            this.Controls.Add(this.TextBoxInfRg);
            this.Controls.Add(this.textBoxObjetivo);
            this.Controls.Add(this.textBoxCidade);
            this.Controls.Add(this.textBoxEndereco);
            this.Controls.Add(this.textBoxRg);
            this.Controls.Add(this.TextBoxInfNasc);
            this.Controls.Add(this.TextBoxInfNome);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.TextBoxInfID);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.btn_searchUser);
            this.Controls.Add(this.tBoxSearchUser);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Alunos";
            this.Text = "Alunos";
            this.Resize += new System.EventHandler(this.Alunos_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tBoxSearchUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_searchUser;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxId;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfID;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfNome;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfNasc;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxRg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxEndereco;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxCidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxObjetivo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfRg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfTelefone;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfEndeco;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfCidade;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfObjetivo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxBairro;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxEstado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxObs;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfCpf;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfBairro;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfEstado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfObs;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfNumero;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxNumComp1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfNumComp;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_addUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_UpdUser;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_DelUser;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView searchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MtextBoxTelefone;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MtextBoxCpf;
        private ComponentFactory.Krypton.Toolkit.KryptonMaskedTextBox MtextBoxNascimento;
    }
}