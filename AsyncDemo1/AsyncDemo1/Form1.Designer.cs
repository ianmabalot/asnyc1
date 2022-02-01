
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
            this.lblResult = new System.Windows.Forms.Label();
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
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(87, 77);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(37, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 248);
            this.Controls.Add(this.lblResult);
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
        private System.Windows.Forms.Label lblResult;
    }
}

