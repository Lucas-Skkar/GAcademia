using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.Reporting.WinForms;

namespace GAcademia.Forms.Comprovante
{
    public partial class Comprovante : KryptonForm
    {
        public Comprovante(string Nome, string Valor, string Mes, string Data)
        {
            InitializeComponent();

            reportViewer1.LocalReport.ReportEmbeddedResource = "GAcademia.Forms.Comprovante.Comprovante.rdlc";

            ReportParameter[] p =
            new ReportParameter[4];
            p[0] = new ReportParameter("Nome", Nome);
            p[1] = new ReportParameter("Valor", Valor);
            p[2] = new ReportParameter("Mes", Mes);
            p[3] = new ReportParameter("Data", Data);
            reportViewer1.LocalReport.SetParameters(p);
        }

        private void Comprovante_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Comprovante_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }

    }
}
