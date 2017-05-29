namespace ModelSim
{
    partial class Principal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonRun = new System.Windows.Forms.Button();
            this.textBoxRepetitions = new System.Windows.Forms.TextBox();
            this.labelRepetitions = new System.Windows.Forms.Label();
            this.textBoxSteps = new System.Windows.Forms.TextBox();
            this.labelSteps = new System.Windows.Forms.Label();
            this.tabControlCharts = new System.Windows.Forms.TabControl();
            this.tabPagePath = new System.Windows.Forms.TabPage();
            this.chartPath = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageDistance = new System.Windows.Forms.TabPage();
            this.chartDistance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.tabControlCharts.SuspendLayout();
            this.tabPagePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPath)).BeginInit();
            this.tabPageDistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Controls.Add(this.buttonRun);
            this.panel1.Controls.Add(this.textBoxRepetitions);
            this.panel1.Controls.Add(this.labelRepetitions);
            this.panel1.Controls.Add(this.textBoxSteps);
            this.panel1.Controls.Add(this.labelSteps);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 437);
            this.panel1.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(18, 403);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(18, 109);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Gerar";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxRepetitions
            // 
            this.textBoxRepetitions.Location = new System.Drawing.Point(6, 63);
            this.textBoxRepetitions.Name = "textBoxRepetitions";
            this.textBoxRepetitions.Size = new System.Drawing.Size(100, 20);
            this.textBoxRepetitions.TabIndex = 3;
            // 
            // labelRepetitions
            // 
            this.labelRepetitions.AutoSize = true;
            this.labelRepetitions.Location = new System.Drawing.Point(6, 47);
            this.labelRepetitions.Name = "labelRepetitions";
            this.labelRepetitions.Size = new System.Drawing.Size(61, 13);
            this.labelRepetitions.TabIndex = 2;
            this.labelRepetitions.Text = "Repetições";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(6, 20);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(100, 20);
            this.textBoxSteps.TabIndex = 1;
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(3, 3);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(41, 13);
            this.labelSteps.TabIndex = 0;
            this.labelSteps.Text = "Passos";
            // 
            // tabControlCharts
            // 
            this.tabControlCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCharts.Controls.Add(this.tabPagePath);
            this.tabControlCharts.Controls.Add(this.tabPageDistance);
            this.tabControlCharts.Location = new System.Drawing.Point(132, 12);
            this.tabControlCharts.Name = "tabControlCharts";
            this.tabControlCharts.SelectedIndex = 0;
            this.tabControlCharts.Size = new System.Drawing.Size(590, 437);
            this.tabControlCharts.TabIndex = 1;
            // 
            // tabPagePath
            // 
            this.tabPagePath.Controls.Add(this.chartPath);
            this.tabPagePath.Location = new System.Drawing.Point(4, 22);
            this.tabPagePath.Name = "tabPagePath";
            this.tabPagePath.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePath.Size = new System.Drawing.Size(582, 411);
            this.tabPagePath.TabIndex = 0;
            this.tabPagePath.Text = "Caminho";
            this.tabPagePath.UseVisualStyleBackColor = true;
            // 
            // chartPath
            // 
            this.chartPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartPath.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartPath.Legends.Add(legend3);
            this.chartPath.Location = new System.Drawing.Point(6, 6);
            this.chartPath.Name = "chartPath";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPath.Series.Add(series3);
            this.chartPath.Size = new System.Drawing.Size(570, 399);
            this.chartPath.TabIndex = 0;
            this.chartPath.Text = "chartDispersion";
            // 
            // tabPageDistance
            // 
            this.tabPageDistance.Controls.Add(this.chartDistance);
            this.tabPageDistance.Location = new System.Drawing.Point(4, 22);
            this.tabPageDistance.Name = "tabPageDistance";
            this.tabPageDistance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDistance.Size = new System.Drawing.Size(582, 411);
            this.tabPageDistance.TabIndex = 1;
            this.tabPageDistance.Text = "Distância";
            this.tabPageDistance.UseVisualStyleBackColor = true;
            // 
            // chartDistance
            // 
            this.chartDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartDistance.Legends.Add(legend4);
            this.chartDistance.Location = new System.Drawing.Point(6, 6);
            this.chartDistance.Name = "chartDistance";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartDistance.Series.Add(series4);
            this.chartDistance.Size = new System.Drawing.Size(570, 399);
            this.chartDistance.TabIndex = 0;
            this.chartDistance.Text = "chartLine";
            // 
            // Principal
            // 
            this.AcceptButton = this.buttonRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.tabControlCharts);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlCharts.ResumeLayout(false);
            this.tabPagePath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPath)).EndInit();
            this.tabPageDistance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.TextBox textBoxRepetitions;
        private System.Windows.Forms.Label labelRepetitions;
        private System.Windows.Forms.TextBox textBoxSteps;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.TabControl tabControlCharts;
        private System.Windows.Forms.TabPage tabPagePath;
        private System.Windows.Forms.TabPage tabPageDistance;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPath;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDistance;
    }
}

