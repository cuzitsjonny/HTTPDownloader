namespace HTTPDownloader
{
    partial class MainForm
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
            this._FormBase = new System.Windows.Forms.TableLayoutPanel();
            this._DownloadButton = new System.Windows.Forms.Button();
            this._SourceLabel = new System.Windows.Forms.Label();
            this._DestinationLabel = new System.Windows.Forms.Label();
            this._ProgressBar = new System.Windows.Forms.ProgressBar();
            this._DestinationButton = new System.Windows.Forms.Button();
            this._ProgressLabel = new System.Windows.Forms.Label();
            this._SourceField = new System.Windows.Forms.RichTextBox();
            this._DestinationField = new System.Windows.Forms.RichTextBox();
            this._FormBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // _FormBase
            // 
            this._FormBase.ColumnCount = 4;
            this._FormBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.Controls.Add(this._DownloadButton, 1, 3);
            this._FormBase.Controls.Add(this._SourceLabel, 0, 0);
            this._FormBase.Controls.Add(this._DestinationLabel, 0, 1);
            this._FormBase.Controls.Add(this._ProgressBar, 1, 2);
            this._FormBase.Controls.Add(this._DestinationButton, 2, 1);
            this._FormBase.Controls.Add(this._ProgressLabel, 0, 2);
            this._FormBase.Controls.Add(this._SourceField, 1, 0);
            this._FormBase.Controls.Add(this._DestinationField, 1, 1);
            this._FormBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this._FormBase.Location = new System.Drawing.Point(0, 0);
            this._FormBase.Name = "_FormBase";
            this._FormBase.Padding = new System.Windows.Forms.Padding(5);
            this._FormBase.RowCount = 4;
            this._FormBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._FormBase.Size = new System.Drawing.Size(674, 270);
            this._FormBase.TabIndex = 0;
            // 
            // _DownloadButton
            // 
            this._FormBase.SetColumnSpan(this._DownloadButton, 2);
            this._DownloadButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DownloadButton.Enabled = false;
            this._DownloadButton.Location = new System.Drawing.Point(174, 203);
            this._DownloadButton.Name = "_DownloadButton";
            this._DownloadButton.Size = new System.Drawing.Size(326, 59);
            this._DownloadButton.TabIndex = 0;
            this._DownloadButton.Text = "Download";
            this._DownloadButton.UseVisualStyleBackColor = true;
            this._DownloadButton.Click += new System.EventHandler(this._DownloadButton_Click);
            // 
            // _SourceLabel
            // 
            this._SourceLabel.AutoSize = true;
            this._SourceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SourceLabel.Location = new System.Drawing.Point(10, 10);
            this._SourceLabel.Margin = new System.Windows.Forms.Padding(5);
            this._SourceLabel.Name = "_SourceLabel";
            this._SourceLabel.Size = new System.Drawing.Size(156, 55);
            this._SourceLabel.TabIndex = 1;
            this._SourceLabel.Text = "Source URL";
            this._SourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _DestinationLabel
            // 
            this._DestinationLabel.AutoSize = true;
            this._DestinationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DestinationLabel.Location = new System.Drawing.Point(10, 75);
            this._DestinationLabel.Margin = new System.Windows.Forms.Padding(5);
            this._DestinationLabel.Name = "_DestinationLabel";
            this._DestinationLabel.Size = new System.Drawing.Size(156, 55);
            this._DestinationLabel.TabIndex = 2;
            this._DestinationLabel.Text = "Destination File";
            this._DestinationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _ProgressBar
            // 
            this._FormBase.SetColumnSpan(this._ProgressBar, 3);
            this._ProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ProgressBar.Enabled = false;
            this._ProgressBar.Location = new System.Drawing.Point(174, 144);
            this._ProgressBar.Margin = new System.Windows.Forms.Padding(3, 9, 3, 9);
            this._ProgressBar.Name = "_ProgressBar";
            this._ProgressBar.Size = new System.Drawing.Size(492, 47);
            this._ProgressBar.Step = 1;
            this._ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this._ProgressBar.TabIndex = 5;
            // 
            // _DestinationButton
            // 
            this._DestinationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DestinationButton.Location = new System.Drawing.Point(506, 73);
            this._DestinationButton.Name = "_DestinationButton";
            this._DestinationButton.Size = new System.Drawing.Size(160, 59);
            this._DestinationButton.TabIndex = 6;
            this._DestinationButton.Text = "Browse";
            this._DestinationButton.UseVisualStyleBackColor = true;
            this._DestinationButton.Click += new System.EventHandler(this._DestinationButton_Click);
            // 
            // _ProgressLabel
            // 
            this._ProgressLabel.AutoSize = true;
            this._ProgressLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ProgressLabel.Location = new System.Drawing.Point(10, 140);
            this._ProgressLabel.Margin = new System.Windows.Forms.Padding(5);
            this._ProgressLabel.Name = "_ProgressLabel";
            this._ProgressLabel.Size = new System.Drawing.Size(156, 55);
            this._ProgressLabel.TabIndex = 7;
            this._ProgressLabel.Text = "Progress";
            this._ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _SourceField
            // 
            this._FormBase.SetColumnSpan(this._SourceField, 3);
            this._SourceField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._SourceField.Location = new System.Drawing.Point(174, 8);
            this._SourceField.Name = "_SourceField";
            this._SourceField.Size = new System.Drawing.Size(492, 59);
            this._SourceField.TabIndex = 8;
            this._SourceField.Text = "";
            this._SourceField.TextChanged += new System.EventHandler(this._SourceField_TextChanged);
            // 
            // _DestinationField
            // 
            this._FormBase.SetColumnSpan(this._DestinationField, 2);
            this._DestinationField.Dock = System.Windows.Forms.DockStyle.Fill;
            this._DestinationField.Location = new System.Drawing.Point(174, 73);
            this._DestinationField.Name = "_DestinationField";
            this._DestinationField.Size = new System.Drawing.Size(326, 59);
            this._DestinationField.TabIndex = 9;
            this._DestinationField.Text = "";
            this._DestinationField.TextChanged += new System.EventHandler(this._DestinationField_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 270);
            this.Controls.Add(this._FormBase);
            this.Name = "MainForm";
            this.Text = "HTTP(S) Downloader";
            this._FormBase.ResumeLayout(false);
            this._FormBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _FormBase;
        private System.Windows.Forms.Button _DownloadButton;
        private System.Windows.Forms.Label _SourceLabel;
        private System.Windows.Forms.Label _DestinationLabel;
        private System.Windows.Forms.ProgressBar _ProgressBar;
        private System.Windows.Forms.Button _DestinationButton;
        private System.Windows.Forms.Label _ProgressLabel;
        private System.Windows.Forms.RichTextBox _SourceField;
        private System.Windows.Forms.RichTextBox _DestinationField;
    }
}

