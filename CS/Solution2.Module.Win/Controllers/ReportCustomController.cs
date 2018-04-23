using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using DevExpress.XtraReports.UI;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using DevExpress.ExpressApp.Reports.Win;

namespace Solution2.Module.Win.Controllers {
    public partial class ReportCustomController : ViewController {
        public ReportCustomController() {
            InitializeComponent();
            RegisterActions(components);
        }
        private WinReportServiceController reportService;
        protected override void OnFrameAssigned() {
            base.OnFrameAssigned();

            reportService = Frame.GetController<WinReportServiceController>();
            if(reportService != null) {
                reportService.CustomShowPreview += reportService_CustomShowPreview;
            }
        }
        private void reportService_CustomShowPreview(
            object sender, CustomShowPreviewEventArgs e) {
            XtraReport1 coverPageReport = new XtraReport1();
            coverPageReport.CreateDocument();

            e.Report.CreateDocument();

            coverPageReport.Pages.AddRange(e.Report.Pages);

            ReportPrintTool printTool = new ReportPrintTool(coverPageReport);
            printTool.ShowPreviewDialog();

            e.Handled = true;
        }
    }
}
