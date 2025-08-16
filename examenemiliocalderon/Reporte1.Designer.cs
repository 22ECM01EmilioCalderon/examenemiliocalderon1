namespace examenemiliocalderon
{
    partial class Reporte1
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
            this.producto2DataSet = new examenemiliocalderon.Producto2DataSet();
            this.producto2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfumesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.perfumesTableAdapter = new examenemiliocalderon.Producto2DataSetTableAdapters.perfumesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.producto2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.perfumesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "examenemiliocalderon.reportes.Categorias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(662, 393);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // producto2DataSet
            // 
            this.producto2DataSet.DataSetName = "Producto2DataSet";
            this.producto2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producto2DataSetBindingSource
            // 
            this.producto2DataSetBindingSource.DataSource = this.producto2DataSet;
            this.producto2DataSetBindingSource.Position = 0;
            // 
            // perfumesBindingSource
            // 
            this.perfumesBindingSource.DataMember = "perfumes";
            this.perfumesBindingSource.DataSource = this.producto2DataSetBindingSource;
            // 
            // perfumesTableAdapter
            // 
            this.perfumesTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // Reporte1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 393);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte1";
            this.Text = "Reporte1";
            this.Load += new System.EventHandler(this.Reporte1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.producto2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producto2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfumesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Producto2DataSet producto2DataSet;
        private System.Windows.Forms.BindingSource producto2DataSetBindingSource;
        private System.Windows.Forms.BindingSource perfumesBindingSource;
        private Producto2DataSetTableAdapters.perfumesTableAdapter perfumesTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
    }
}