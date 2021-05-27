<!-- default file list -->
*Files to look at*:

* [ReportCustomController.cs](./CS/Solution2.Module.Win/Controllers/ReportCustomController.cs) (VB: [ReportCustomController.vb](./VB/Solution2.Module.Win/Controllers/ReportCustomController.vb))
<!-- default file list end -->
# How to merge reports in XAF


<p>In the XtraReports documentation <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument3321"><u>How to: Merge Pages of Two Reports</u></a>  article it is described how to merge two XtraReports.</p><p>To embed this solution in an XAF application, use the <a href="https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.ReportsV2.ReportServiceController.CustomShowPreview"><u>WinReportServiceController.CustomShowPreview</u></a> event and combine the passed e.Report report with the customized XtraReport1 report:<br />


```cs
        private void reportService_CustomShowPreview(
            object sender, CustomShowPreviewEventArgs e) {
            XtraReport1 coverPageReport = new XtraReport1();
            coverPageReport.CreateDocument();

            e.Report.CreateDocument();

            coverPageReport.Pages.AddRange(e.Report.Pages);
            coverPageReport.ShowPreviewDialog();

            e.Handled = true;
        }

```

 </p>

<br/>


