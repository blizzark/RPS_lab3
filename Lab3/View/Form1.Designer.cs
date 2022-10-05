namespace Lab33
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LeftBorder = new System.Windows.Forms.TextBox();
            this.RightBorder = new System.Windows.Forms.TextBox();
            this.ParamA = new System.Windows.Forms.TextBox();
            this.DotsList = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotsList)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(427, 35);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Декартов лист \"-\"";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(672, 265);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // LeftBorder
            // 
            this.LeftBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LeftBorder.Location = new System.Drawing.Point(22, 96);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(129, 20);
            this.LeftBorder.TabIndex = 1;
            // 
            // RightBorder
            // 
            this.RightBorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RightBorder.Location = new System.Drawing.Point(22, 135);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(129, 20);
            this.RightBorder.TabIndex = 2;
            // 
            // ParamA
            // 
            this.ParamA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ParamA.CausesValidation = false;
            this.ParamA.Location = new System.Drawing.Point(22, 51);
            this.ParamA.Name = "ParamA";
            this.ParamA.Size = new System.Drawing.Size(129, 20);
            this.ParamA.TabIndex = 3;
            // 
            // DotsList
            // 
            this.DotsList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DotsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DotsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y1,
            this.Y2});
            this.DotsList.Location = new System.Drawing.Point(167, 35);
            this.DotsList.Name = "DotsList";
            this.DotsList.Size = new System.Drawing.Size(254, 265);
            this.DotsList.TabIndex = 4;
            // 
            // X
            // 
            this.X.FillWeight = 70F;
            this.X.HeaderText = "X";
            this.X.Name = "X";
            this.X.Width = 70;
            // 
            // Y1
            // 
            this.Y1.FillWeight = 70F;
            this.Y1.HeaderText = "Y1";
            this.Y1.Name = "Y1";
            this.Y1.Width = 70;
            // 
            // Y2
            // 
            this.Y2.FillWeight = 70F;
            this.Y2.HeaderText = "Y2";
            this.Y2.Name = "Y2";
            this.Y2.Width = 70;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(22, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Левая граница";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Правая граница";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ненулевая константа - а";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(22, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Шаг";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(22, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 40);
            this.button2.TabIndex = 13;
            this.button2.Text = "Информация";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Кубика Чирнгауза";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 337);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DotsList);
            this.Controls.Add(this.ParamA);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №3 Кубика Чирнгауза";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DotsList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox LeftBorder;
        private System.Windows.Forms.TextBox RightBorder;
        private System.Windows.Forms.TextBox ParamA;
        private System.Windows.Forms.DataGridView DotsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
    }
}

