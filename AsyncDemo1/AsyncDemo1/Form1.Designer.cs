
namespace AsyncDemo1
{
    partial class Form1
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
            this.executeSync = new System.Windows.Forms.Button();
            this.executeAsync = new System.Windows.Forms.Button();
            this.executeParallelAsync = new System.Windows.Forms.Button();
            this.cancelOperation = new System.Windows.Forms.Button();
            this.dashboardProgress = new System.Windows.Forms.ProgressBar();
            this.lblResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // executeSync
            // 
            this.executeSync.Location = new System.Drawing.Point(90, 12);
            this.executeSync.Name = "executeSync";
            this.executeSync.Size = new System.Drawing.Size(319, 23);
            this.executeSync.TabIndex = 0;
            this.executeSync.Text = "Syncronous";
            this.executeSync.UseVisualStyleBackColor = true;
            this.executeSync.Click += new System.EventHandler(this.executeSync_Click);
            // 
            // executeAsync
            // 
            this.executeAsync.Location = new System.Drawing.Point(90, 41);
            this.executeAsync.Name = "executeAsync";
            this.executeAsync.Size = new System.Drawing.Size(319, 23);
            this.executeAsync.TabIndex = 1;
            this.executeAsync.Text = "Asyncronous";
            this.executeAsync.UseVisualStyleBackColor = true;
            this.executeAsync.Click += new System.EventHandler(this.executeAsync_Click);
            // 
            // executeParallelAsync
            // 
            this.executeParallelAsync.Location = new System.Drawing.Point(90, 70);
            this.executeParallelAsync.Name = "executeParallelAsync";
            this.executeParallelAsync.Size = new System.Drawing.Size(319, 23);
            this.executeParallelAsync.TabIndex = 3;
            this.executeParallelAsync.Text = "Parallel Asyncronous";
            this.executeParallelAsync.UseVisualStyleBackColor = true;
            this.executeParallelAsync.Click += new System.EventHandler(this.executeParallelAsync_Click);
            // 
            // cancelOperation
            // 
            this.cancelOperation.Location = new System.Drawing.Point(90, 99);
            this.cancelOperation.Name = "cancelOperation";
            this.cancelOperation.Size = new System.Drawing.Size(319, 23);
            this.cancelOperation.TabIndex = 4;
            this.cancelOperation.Text = "Cancel Operation";
            this.cancelOperation.UseVisualStyleBackColor = true;
            this.cancelOperation.Click += new System.EventHandler(this.cancelOperation_Click);
            // 
            // dashboardProgress
            // 
            this.dashboardProgress.Location = new System.Drawing.Point(90, 128);
            this.dashboardProgress.Name = "dashboardProgress";
            this.dashboardProgress.Size = new System.Drawing.Size(319, 23);
            this.dashboardProgress.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(415, 14);
            this.lblResult.Multiline = true;
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(478, 321);
            this.lblResult.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 373);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.dashboardProgress);
            this.Controls.Add(this.cancelOperation);
            this.Controls.Add(this.executeParallelAsync);
            this.Controls.Add(this.executeAsync);
            this.Controls.Add(this.executeSync);
            this.Name = "Form1";
            this.Text = "Async Demo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button executeSync;
        private System.Windows.Forms.Button executeAsync;
        private System.Windows.Forms.Button executeParallelAsync;
        private System.Windows.Forms.Button cancelOperation;
        private System.Windows.Forms.ProgressBar dashboardProgress;
        private System.Windows.Forms.TextBox lblResult;
    }
}

