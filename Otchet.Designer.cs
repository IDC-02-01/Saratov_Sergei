namespace Magazinciks
{
    partial class Otchet
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BD_SeregiDataSet = new Magazinciks.BD_SeregiDataSet();
            this.OtchetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OtchetTableAdapter = new Magazinciks.BD_SeregiDataSetTableAdapters.OtchetTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BD_SeregiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtchetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.OtchetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Magazinciks.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // BD_SeregiDataSet
            // 
            this.BD_SeregiDataSet.DataSetName = "BD_SeregiDataSet";
            this.BD_SeregiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OtchetBindingSource
            // 
            this.OtchetBindingSource.DataMember = "Otchet";
            this.OtchetBindingSource.DataSource = this.BD_SeregiDataSet;
            // 
            // OtchetTableAdapter
            // 
            this.OtchetTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Otchet";
            this.Text = "Otchet";
            this.Load += new System.EventHandler(this.Otchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD_SeregiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OtchetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource OtchetBindingSource;
        private BD_SeregiDataSet BD_SeregiDataSet;
        private BD_SeregiDataSetTableAdapters.OtchetTableAdapter OtchetTableAdapter;
    }
}