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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelDistanceWalked = new System.Windows.Forms.Label();
            this.labelDistanceWalkedResult = new System.Windows.Forms.Label();
            this.panelDistanceResults = new System.Windows.Forms.Panel();
            this.labelDistanceEstimated = new System.Windows.Forms.Label();
            this.labelDistanceEstimatedResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelHistogram = new System.Windows.Forms.Panel();
            this.chartHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControlCharts.SuspendLayout();
            this.tabPagePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPath)).BeginInit();
            this.tabPageDistance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelDistanceResults.SuspendLayout();
            this.panelHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonClose.Location = new System.Drawing.Point(35, 410);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "Fechar";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRun.Location = new System.Drawing.Point(35, 352);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(75, 23);
            this.buttonRun.TabIndex = 4;
            this.buttonRun.Text = "Gerar";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // textBoxRepetitions
            // 
            this.textBoxRepetitions.Location = new System.Drawing.Point(12, 77);
            this.textBoxRepetitions.Name = "textBoxRepetitions";
            this.textBoxRepetitions.Size = new System.Drawing.Size(124, 20);
            this.textBoxRepetitions.TabIndex = 3;
            // 
            // labelRepetitions
            // 
            this.labelRepetitions.AutoSize = true;
            this.labelRepetitions.Location = new System.Drawing.Point(9, 61);
            this.labelRepetitions.Name = "labelRepetitions";
            this.labelRepetitions.Size = new System.Drawing.Size(61, 13);
            this.labelRepetitions.TabIndex = 2;
            this.labelRepetitions.Text = "Repetições";
            // 
            // textBoxSteps
            // 
            this.textBoxSteps.Location = new System.Drawing.Point(12, 34);
            this.textBoxSteps.Name = "textBoxSteps";
            this.textBoxSteps.Size = new System.Drawing.Size(124, 20);
            this.textBoxSteps.TabIndex = 1;
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(9, 17);
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
            this.tabControlCharts.Location = new System.Drawing.Point(164, 12);
            this.tabControlCharts.Name = "tabControlCharts";
            this.tabControlCharts.SelectedIndex = 0;
            this.tabControlCharts.Size = new System.Drawing.Size(558, 437);
            this.tabControlCharts.TabIndex = 1;
            // 
            // tabPagePath
            // 
            this.tabPagePath.Controls.Add(this.chartPath);
            this.tabPagePath.Location = new System.Drawing.Point(4, 22);
            this.tabPagePath.Name = "tabPagePath";
            this.tabPagePath.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePath.Size = new System.Drawing.Size(550, 411);
            this.tabPagePath.TabIndex = 0;
            this.tabPagePath.Text = "Caminho";
            this.tabPagePath.UseVisualStyleBackColor = true;
            // 
            // chartPath
            // 
            this.chartPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartArea1";
            this.chartPath.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartPath.Legends.Add(legend4);
            this.chartPath.Location = new System.Drawing.Point(6, 6);
            this.chartPath.Name = "chartPath";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chartPath.Series.Add(series4);
            this.chartPath.Size = new System.Drawing.Size(538, 399);
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
            chartArea5.Name = "ChartArea1";
            this.chartDistance.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartDistance.Legends.Add(legend5);
            this.chartDistance.Location = new System.Drawing.Point(6, 6);
            this.chartDistance.Name = "chartDistance";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartDistance.Series.Add(series5);
            this.chartDistance.Size = new System.Drawing.Size(570, 399);
            this.chartDistance.TabIndex = 0;
            this.chartDistance.Text = "chartLine";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.buttonClear);
            this.groupBox1.Controls.Add(this.panelDistanceResults);
            this.groupBox1.Controls.Add(this.textBoxSteps);
            this.groupBox1.Controls.Add(this.labelRepetitions);
            this.groupBox1.Controls.Add(this.buttonClose);
            this.groupBox1.Controls.Add(this.labelSteps);
            this.groupBox1.Controls.Add(this.buttonRun);
            this.groupBox1.Controls.Add(this.textBoxRepetitions);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 443);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // labelDistanceWalked
            // 
            this.labelDistanceWalked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanceWalked.Location = new System.Drawing.Point(0, 2);
            this.labelDistanceWalked.Name = "labelDistanceWalked";
            this.labelDistanceWalked.Size = new System.Drawing.Size(134, 44);
            this.labelDistanceWalked.TabIndex = 6;
            this.labelDistanceWalked.Text = "Distância Final Percorrida";
            this.labelDistanceWalked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDistanceWalkedResult
            // 
            this.labelDistanceWalkedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanceWalkedResult.Location = new System.Drawing.Point(0, 45);
            this.labelDistanceWalkedResult.Name = "labelDistanceWalkedResult";
            this.labelDistanceWalkedResult.Size = new System.Drawing.Size(134, 23);
            this.labelDistanceWalkedResult.TabIndex = 7;
            this.labelDistanceWalkedResult.Text = "900";
            this.labelDistanceWalkedResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDistanceResults
            // 
            this.panelDistanceResults.Controls.Add(this.labelDistanceEstimated);
            this.panelDistanceResults.Controls.Add(this.labelDistanceEstimatedResult);
            this.panelDistanceResults.Controls.Add(this.labelDistanceWalked);
            this.panelDistanceResults.Controls.Add(this.labelDistanceWalkedResult);
            this.panelDistanceResults.Location = new System.Drawing.Point(6, 103);
            this.panelDistanceResults.Name = "panelDistanceResults";
            this.panelDistanceResults.Size = new System.Drawing.Size(134, 180);
            this.panelDistanceResults.TabIndex = 8;
            this.panelDistanceResults.Visible = false;
            // 
            // labelDistanceEstimated
            // 
            this.labelDistanceEstimated.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanceEstimated.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelDistanceEstimated.Location = new System.Drawing.Point(0, 69);
            this.labelDistanceEstimated.Name = "labelDistanceEstimated";
            this.labelDistanceEstimated.Size = new System.Drawing.Size(134, 54);
            this.labelDistanceEstimated.TabIndex = 8;
            this.labelDistanceEstimated.Text = "Diferença Distância Estimada";
            this.labelDistanceEstimated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDistanceEstimatedResult
            // 
            this.labelDistanceEstimatedResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDistanceEstimatedResult.Location = new System.Drawing.Point(1, 119);
            this.labelDistanceEstimatedResult.Name = "labelDistanceEstimatedResult";
            this.labelDistanceEstimatedResult.Size = new System.Drawing.Size(133, 24);
            this.labelDistanceEstimatedResult.TabIndex = 9;
            this.labelDistanceEstimatedResult.Text = "900";
            this.labelDistanceEstimatedResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClear.Location = new System.Drawing.Point(35, 381);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Limpar";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelHistogram
            // 
            this.panelHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHistogram.Controls.Add(this.chartHistogram);
            this.panelHistogram.Location = new System.Drawing.Point(164, 13);
            this.panelHistogram.Name = "panelHistogram";
            this.panelHistogram.Size = new System.Drawing.Size(556, 435);
            this.panelHistogram.TabIndex = 7;
            this.panelHistogram.Visible = false;
            // 
            // chartHistogram
            // 
            this.chartHistogram.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chartHistogram.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartHistogram.Legends.Add(legend6);
            this.chartHistogram.Location = new System.Drawing.Point(0, 0);
            this.chartHistogram.Name = "chartHistogram";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartHistogram.Series.Add(series6);
            this.chartHistogram.Size = new System.Drawing.Size(558, 435);
            this.chartHistogram.TabIndex = 0;
            this.chartHistogram.Text = "Histogram";
            // 
            // Principal
            // 
            this.AcceptButton = this.buttonRun;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.panelHistogram);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControlCharts);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulador";
            this.tabControlCharts.ResumeLayout(false);
            this.tabPagePath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPath)).EndInit();
            this.tabPageDistance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDistance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelDistanceResults.ResumeLayout(false);
            this.panelHistogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDistanceWalkedResult;
        private System.Windows.Forms.Label labelDistanceWalked;
        private System.Windows.Forms.Panel panelDistanceResults;
        private System.Windows.Forms.Label labelDistanceEstimated;
        private System.Windows.Forms.Label labelDistanceEstimatedResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHistogram;
    }
}

