
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelButtons = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.btn_Detalhes = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPaletteButtons = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.btn_Mensalidades = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panelChildrens = new System.Windows.Forms.Panel();
            this.DataGridDetalhes = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Aluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxInfAtrasado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxAtrasado = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TextBoxInfRecebeu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.textBoxRecebeu = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.ComboBoxMes = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelChildrens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetalhes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxMes)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btn_Detalhes);
            this.panelButtons.Controls.Add(this.btn_Mensalidades);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(120, 450);
            this.panelButtons.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.panelButtons.TabIndex = 3;
            // 
            // btn_Detalhes
            // 
            this.btn_Detalhes.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_Detalhes.Location = new System.Drawing.Point(0, 0);
            this.btn_Detalhes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Detalhes.Name = "btn_Detalhes";
            this.btn_Detalhes.Palette = this.kryptonPaletteButtons;
            this.btn_Detalhes.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Detalhes.Size = new System.Drawing.Size(128, 53);
            this.btn_Detalhes.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Detalhes.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Detalhes.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Detalhes.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Detalhes.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Detalhes.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Detalhes.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Detalhes.TabIndex = 5;
            this.btn_Detalhes.Values.Text = "Detalhes";
            this.btn_Detalhes.Click += new System.EventHandler(this.btn_Detalhes_Click);
            // 
            // kryptonPaletteButtons
            // 
            this.kryptonPaletteButtons.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Global;
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
            // btn_Mensalidades
            // 
            this.btn_Mensalidades.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Custom2;
            this.btn_Mensalidades.Location = new System.Drawing.Point(0, 53);
            this.btn_Mensalidades.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btn_Mensalidades.Name = "btn_Mensalidades";
            this.btn_Mensalidades.Palette = this.kryptonPaletteButtons;
            this.btn_Mensalidades.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.btn_Mensalidades.Size = new System.Drawing.Size(128, 53);
            this.btn_Mensalidades.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Mensalidades.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Mensalidades.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Mensalidades.StateNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.btn_Mensalidades.StateNormal.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btn_Mensalidades.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_Mensalidades.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Mensalidades.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mensalidades.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Mensalidades.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Mensalidades.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btn_Mensalidades.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_Mensalidades.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Mensalidades.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.btn_Mensalidades.TabIndex = 4;
            this.btn_Mensalidades.Values.Text = "Mensalidades";
            this.btn_Mensalidades.Click += new System.EventHandler(this.btn_Mensalidades_Click);
            // 
            // panelChildrens
            // 
            this.panelChildrens.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.panelChildrens.Controls.Add(this.DataGridDetalhes);
            this.panelChildrens.Controls.Add(this.TextBoxInfAtrasado);
            this.panelChildrens.Controls.Add(this.textBoxAtrasado);
            this.panelChildrens.Controls.Add(this.TextBoxInfRecebeu);
            this.panelChildrens.Controls.Add(this.textBoxRecebeu);
            this.panelChildrens.Controls.Add(this.ComboBoxMes);
            this.panelChildrens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildrens.Location = new System.Drawing.Point(120, 0);
            this.panelChildrens.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panelChildrens.Name = "panelChildrens";
            this.panelChildrens.Size = new System.Drawing.Size(680, 450);
            this.panelChildrens.TabIndex = 4;
            // 
            // DataGridDetalhes
            // 
            this.DataGridDetalhes.AllowUserToAddRows = false;
            this.DataGridDetalhes.AllowUserToDeleteRows = false;
            this.DataGridDetalhes.AllowUserToOrderColumns = true;
            this.DataGridDetalhes.AllowUserToResizeColumns = false;
            this.DataGridDetalhes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridDetalhes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridDetalhes.ColumnHeadersHeight = 24;
            this.DataGridDetalhes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Aluno,
            this.valor,
            this.statusM,
            this.mes,
            this.DiaM,
            this.contato});
            this.DataGridDetalhes.Enabled = false;
            this.DataGridDetalhes.HideOuterBorders = true;
            this.DataGridDetalhes.Location = new System.Drawing.Point(16, 142);
            this.DataGridDetalhes.Name = "DataGridDetalhes";
            this.DataGridDetalhes.ReadOnly = true;
            this.DataGridDetalhes.RowHeadersVisible = false;
            this.DataGridDetalhes.RowTemplate.Height = 30;
            this.DataGridDetalhes.RowTemplate.ReadOnly = true;
            this.DataGridDetalhes.Size = new System.Drawing.Size(652, 296);
            this.DataGridDetalhes.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridDetalhes.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.DataGridDetalhes.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.DataGridDetalhes.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StateCommon.DataCell.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.Black;
            this.DataGridDetalhes.StateCommon.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(21)))), ((int)(((byte)(26)))));
            this.DataGridDetalhes.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DataGridDetalhes.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DataGridDetalhes.StateCommon.HeaderRow.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.DataGridDetalhes.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateCommon.HeaderRow.Border.Rounding = 20;
            this.DataGridDetalhes.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateNormal.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateNormal.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateNormal.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.DataGridDetalhes.StateNormal.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StateNormal.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateNormal.HeaderRow.Border.Rounding = 20;
            this.DataGridDetalhes.StateNormal.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StatePressed.HeaderColumn.Border.Rounding = 20;
            this.DataGridDetalhes.StatePressed.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGridDetalhes.StatePressed.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DataGridDetalhes.StatePressed.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StatePressed.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StatePressed.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StatePressed.HeaderRow.Border.Rounding = 20;
            this.DataGridDetalhes.StateSelected.DataCell.Back.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.DataGridDetalhes.StateSelected.DataCell.Back.Color2 = System.Drawing.SystemColors.MenuHighlight;
            this.DataGridDetalhes.StateSelected.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateSelected.DataCell.Border.Rounding = 20;
            this.DataGridDetalhes.StateSelected.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.DataGridDetalhes.StateSelected.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridDetalhes.StateSelected.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DataGridDetalhes.StateSelected.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.DataGridDetalhes.StateSelected.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateSelected.HeaderRow.Border.Rounding = 20;
            this.DataGridDetalhes.StateTracking.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StateTracking.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridDetalhes.StateTracking.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.DataGridDetalhes.StateTracking.HeaderRow.Border.Rounding = 20;
            this.DataGridDetalhes.TabIndex = 82;
            // 
            // Aluno
            // 
            this.Aluno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Aluno.DataPropertyName = "nome";
            this.Aluno.HeaderText = "Aluno";
            this.Aluno.Name = "Aluno";
            this.Aluno.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.valor.DataPropertyName = "valor";
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 62;
            // 
            // statusM
            // 
            this.statusM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.statusM.DataPropertyName = "status";
            this.statusM.HeaderText = "Status da mensalidade";
            this.statusM.Name = "statusM";
            this.statusM.ReadOnly = true;
            this.statusM.Width = 154;
            // 
            // mes
            // 
            this.mes.DataPropertyName = "mes";
            this.mes.HeaderText = "Mês";
            this.mes.Name = "mes";
            this.mes.ReadOnly = true;
            // 
            // DiaM
            // 
            this.DiaM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DiaM.DataPropertyName = "dia";
            this.DiaM.HeaderText = "Dia Vencimento";
            this.DiaM.Name = "DiaM";
            this.DiaM.ReadOnly = true;
            this.DiaM.Width = 119;
            // 
            // contato
            // 
            this.contato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.contato.DataPropertyName = "celular";
            this.contato.HeaderText = "contato";
            this.contato.Name = "contato";
            this.contato.ReadOnly = true;
            this.contato.Width = 77;
            // 
            // TextBoxInfAtrasado
            // 
            this.TextBoxInfAtrasado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxInfAtrasado.Location = new System.Drawing.Point(328, 83);
            this.TextBoxInfAtrasado.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfAtrasado.MaximumSize = new System.Drawing.Size(101, 32);
            this.TextBoxInfAtrasado.MaxLength = 10;
            this.TextBoxInfAtrasado.MinimumSize = new System.Drawing.Size(101, 32);
            this.TextBoxInfAtrasado.Name = "TextBoxInfAtrasado";
            this.TextBoxInfAtrasado.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfAtrasado.ReadOnly = true;
            this.TextBoxInfAtrasado.Size = new System.Drawing.Size(101, 32);
            this.TextBoxInfAtrasado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfAtrasado.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfAtrasado.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfAtrasado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfAtrasado.StateActive.Border.Rounding = 20;
            this.TextBoxInfAtrasado.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfAtrasado.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfAtrasado.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfAtrasado.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfAtrasado.TabIndex = 81;
            this.TextBoxInfAtrasado.TabStop = false;
            this.TextBoxInfAtrasado.Text = "Valor Pendente";
            this.TextBoxInfAtrasado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAtrasado
            // 
            this.textBoxAtrasado.AlwaysActive = false;
            this.textBoxAtrasado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAtrasado.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxAtrasado.Location = new System.Drawing.Point(429, 83);
            this.textBoxAtrasado.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxAtrasado.Name = "textBoxAtrasado";
            this.textBoxAtrasado.Size = new System.Drawing.Size(109, 32);
            this.textBoxAtrasado.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxAtrasado.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxAtrasado.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxAtrasado.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxAtrasado.StateActive.Border.Rounding = 20;
            this.textBoxAtrasado.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxAtrasado.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAtrasado.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxAtrasado.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxAtrasado.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxAtrasado.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxAtrasado.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxAtrasado.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxAtrasado.StateDisabled.Border.Rounding = 20;
            this.textBoxAtrasado.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAtrasado.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxAtrasado.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxAtrasado.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxAtrasado.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxAtrasado.StateNormal.Border.Rounding = 20;
            this.textBoxAtrasado.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxAtrasado.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAtrasado.TabIndex = 80;
            // 
            // TextBoxInfRecebeu
            // 
            this.TextBoxInfRecebeu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextBoxInfRecebeu.Location = new System.Drawing.Point(119, 83);
            this.TextBoxInfRecebeu.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.TextBoxInfRecebeu.MaximumSize = new System.Drawing.Size(100, 32);
            this.TextBoxInfRecebeu.MaxLength = 10;
            this.TextBoxInfRecebeu.MinimumSize = new System.Drawing.Size(100, 32);
            this.TextBoxInfRecebeu.Name = "TextBoxInfRecebeu";
            this.TextBoxInfRecebeu.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Black;
            this.TextBoxInfRecebeu.ReadOnly = true;
            this.TextBoxInfRecebeu.Size = new System.Drawing.Size(100, 32);
            this.TextBoxInfRecebeu.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfRecebeu.StateActive.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.TextBoxInfRecebeu.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.TextBoxInfRecebeu.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.TextBoxInfRecebeu.StateActive.Border.Rounding = 20;
            this.TextBoxInfRecebeu.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.TextBoxInfRecebeu.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxInfRecebeu.StateActive.Content.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxInfRecebeu.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(36)))), ((int)(((byte)(41)))));
            this.TextBoxInfRecebeu.TabIndex = 79;
            this.TextBoxInfRecebeu.TabStop = false;
            this.TextBoxInfRecebeu.Text = "Valor Recebido";
            this.TextBoxInfRecebeu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxRecebeu
            // 
            this.textBoxRecebeu.AlwaysActive = false;
            this.textBoxRecebeu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxRecebeu.InputControlStyle = ComponentFactory.Krypton.Toolkit.InputControlStyle.Custom1;
            this.textBoxRecebeu.Location = new System.Drawing.Point(219, 83);
            this.textBoxRecebeu.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.textBoxRecebeu.Name = "textBoxRecebeu";
            this.textBoxRecebeu.Size = new System.Drawing.Size(84, 32);
            this.textBoxRecebeu.StateActive.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRecebeu.StateActive.Border.Color1 = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxRecebeu.StateActive.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxRecebeu.StateActive.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRecebeu.StateActive.Border.Rounding = 20;
            this.textBoxRecebeu.StateActive.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.textBoxRecebeu.StateActive.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecebeu.StateActive.Content.Padding = new System.Windows.Forms.Padding(5, 1, 1, 1);
            this.textBoxRecebeu.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRecebeu.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRecebeu.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRecebeu.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRecebeu.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left)));
            this.textBoxRecebeu.StateDisabled.Border.Rounding = 20;
            this.textBoxRecebeu.StateDisabled.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRecebeu.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.textBoxRecebeu.StateNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.textBoxRecebeu.StateNormal.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.textBoxRecebeu.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)(((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textBoxRecebeu.StateNormal.Border.Rounding = 20;
            this.textBoxRecebeu.StateNormal.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxRecebeu.StateNormal.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRecebeu.TabIndex = 78;
            // 
            // ComboBoxMes
            // 
            this.ComboBoxMes.AlwaysActive = false;
            this.ComboBoxMes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComboBoxMes.DropDownWidth = 419;
            this.ComboBoxMes.Location = new System.Drawing.Point(119, 23);
            this.ComboBoxMes.Name = "ComboBoxMes";
            this.ComboBoxMes.Size = new System.Drawing.Size(419, 33);
            this.ComboBoxMes.StateActive.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateActive.ComboBox.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.ComboBoxMes.StateActive.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ComboBoxMes.StateActive.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxMes.StateActive.ComboBox.Border.Rounding = 20;
            this.ComboBoxMes.StateActive.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.ComboBoxMes.StateActive.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMes.StateCommon.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxMes.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMes.StateCommon.DropBack.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateCommon.DropBack.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateCommon.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateCommon.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateCommon.Item.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxMes.StateCommon.Item.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMes.StateNormal.ComboBox.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateNormal.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ComboBoxMes.StateNormal.ComboBox.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.ComboBoxMes.StateNormal.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxMes.StateNormal.ComboBox.Border.Rounding = 20;
            this.ComboBoxMes.StateNormal.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ComboBoxMes.StateNormal.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMes.StateNormal.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateNormal.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateNormal.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ComboBoxMes.StateNormal.Item.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(57)))), ((int)(((byte)(61)))));
            this.ComboBoxMes.StateNormal.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxMes.StateTracking.Item.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateTracking.Item.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(36)))));
            this.ComboBoxMes.StateTracking.Item.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.ComboBoxMes.StateTracking.Item.Border.Color1 = System.Drawing.SystemColors.Highlight;
            this.ComboBoxMes.StateTracking.Item.Border.Color2 = System.Drawing.SystemColors.HotTrack;
            this.ComboBoxMes.StateTracking.Item.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ComboBoxMes.TabIndex = 2;
            this.ComboBoxMes.SelectionChangeCommitted += new System.EventHandler(this.ComboBoxMes_SelectedIndexChanged);
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
            this.Load += new System.EventHandler(this.Financas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelButtons)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelChildrens.ResumeLayout(false);
            this.panelChildrens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridDetalhes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxMes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPanel panelButtons;
        private System.Windows.Forms.Panel panelChildrens;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Mensalidades;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Detalhes;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxMes;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfAtrasado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxAtrasado;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TextBoxInfRecebeu;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox textBoxRecebeu;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridDetalhes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusM;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaM;
        private System.Windows.Forms.DataGridViewTextBoxColumn contato;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPaletteButtons;
    }
}