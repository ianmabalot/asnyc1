using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncDemo1
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cts = new CancellationTokenSource(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void executeSync_Click(object sender, EventArgs e)
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            var results = DemoMethods.RunDownloadParallelSync(); //run this method syncronously
            PrintResults(results);

            watch.Stop();

            var elapseMs = watch.ElapsedMilliseconds;

            lblResult.Text += $"Total execution time: {elapseMs}";
        }

        private void PrintResults(List<WebsiteDataModel> results)
        {
            lblResult.Text = "";
            foreach(var item in results)
            {
                lblResult.Text += $"{item.WebsiteUrl} downlodead: {item.WebsiteData.Length} characters long. {Environment.NewLine}";
            }
        }

        private async void executeAsync_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                var results = await DemoMethods.RunDownloadAsync(progress, cts.Token);
                PrintResults(results);
            }
            catch (OperationCanceledException)
            {
                lblResult.Text += $"The async download was cancelled {Environment.NewLine}";
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            lblResult.Text += $"Total execution time: {elapsedMs}";
        }

        private void ReportProgress(object sender, ProgressReportModel e)
        {
            dashboardProgress.Value = e.PercentageComplete;
            PrintResults(e.SitesDownloaded);
        }

        private void cancelOperation_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private async void executeParallelAsync_Click(object sender, EventArgs e)
        {
            Progress<ProgressReportModel> progress = new Progress<ProgressReportModel>();
            progress.ProgressChanged += ReportProgress;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            var results = await DemoMethods.RunDownloadParallelAsyncV2(progress);
            PrintResults(results);

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            lblResult.Text += $"Total execution time: {elapsedMs}";
        }
    }
}
