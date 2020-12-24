
namespace TheGraphingOfEquations
{
    partial class theGraphingOfEquations
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphicsGroupBox = new System.Windows.Forms.GroupBox();
            this.sinCosCheckBox = new System.Windows.Forms.CheckBox();
            this.cosCheckBox = new System.Windows.Forms.CheckBox();
            this.sinCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.coefficientTextBox1 = new System.Windows.Forms.TextBox();
            this.toGraphTheEquationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.coefficientTextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.coefficientTextBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.leftLimitTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rightLimitTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stepTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.graphicsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea6.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.mainChart.Legends.Add(legend6);
            this.mainChart.Location = new System.Drawing.Point(12, 12);
            this.mainChart.Name = "mainChart";
            series21.BorderWidth = 3;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series21.Color = System.Drawing.Color.Black;
            series21.Legend = "Legend1";
            series21.Name = "variations of sine";
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Color = System.Drawing.Color.Red;
            series22.Legend = "Legend1";
            series22.Name = "y = sin(x)";
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.Green;
            series23.Legend = "Legend1";
            series23.Name = "y = cos(x)";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series24.Color = System.Drawing.Color.Blue;
            series24.Legend = "Legend1";
            series24.Name = "y = sin(x) + cos(x)";
            this.mainChart.Series.Add(series21);
            this.mainChart.Series.Add(series22);
            this.mainChart.Series.Add(series23);
            this.mainChart.Series.Add(series24);
            this.mainChart.Size = new System.Drawing.Size(776, 340);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "mainChart";
            // 
            // graphicsGroupBox
            // 
            this.graphicsGroupBox.Controls.Add(this.sinCosCheckBox);
            this.graphicsGroupBox.Controls.Add(this.cosCheckBox);
            this.graphicsGroupBox.Controls.Add(this.sinCheckBox);
            this.graphicsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.graphicsGroupBox.Location = new System.Drawing.Point(12, 384);
            this.graphicsGroupBox.Name = "graphicsGroupBox";
            this.graphicsGroupBox.Size = new System.Drawing.Size(351, 54);
            this.graphicsGroupBox.TabIndex = 1;
            this.graphicsGroupBox.TabStop = false;
            this.graphicsGroupBox.Text = "Graphics";
            // 
            // sinCosCheckBox
            // 
            this.sinCosCheckBox.AutoSize = true;
            this.sinCosCheckBox.Location = new System.Drawing.Point(201, 25);
            this.sinCosCheckBox.Name = "sinCosCheckBox";
            this.sinCosCheckBox.Size = new System.Drawing.Size(148, 24);
            this.sinCosCheckBox.TabIndex = 2;
            this.sinCosCheckBox.Text = "y = sin(x) + cos(x)";
            this.sinCosCheckBox.UseVisualStyleBackColor = true;
            this.sinCosCheckBox.CheckedChanged += new System.EventHandler(this.SinCosCheckBox3_CheckedChanged);
            // 
            // cosCheckBox
            // 
            this.cosCheckBox.AutoSize = true;
            this.cosCheckBox.Location = new System.Drawing.Point(101, 24);
            this.cosCheckBox.Name = "cosCheckBox";
            this.cosCheckBox.Size = new System.Drawing.Size(94, 24);
            this.cosCheckBox.TabIndex = 1;
            this.cosCheckBox.Text = "y = cos(x)";
            this.cosCheckBox.UseVisualStyleBackColor = true;
            this.cosCheckBox.CheckedChanged += new System.EventHandler(this.CosCheckBox2_CheckedChanged);
            // 
            // sinCheckBox
            // 
            this.sinCheckBox.AutoSize = true;
            this.sinCheckBox.Location = new System.Drawing.Point(6, 25);
            this.sinCheckBox.Name = "sinCheckBox";
            this.sinCheckBox.Size = new System.Drawing.Size(89, 24);
            this.sinCheckBox.TabIndex = 0;
            this.sinCheckBox.Text = "y = sin(x)";
            this.sinCheckBox.UseVisualStyleBackColor = true;
            this.sinCheckBox.CheckedChanged += new System.EventHandler(this.SinCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "y = sin (";
            // 
            // coefficientTextBox1
            // 
            this.coefficientTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefficientTextBox1.Location = new System.Drawing.Point(80, 358);
            this.coefficientTextBox1.Name = "coefficientTextBox1";
            this.coefficientTextBox1.Size = new System.Drawing.Size(78, 26);
            this.coefficientTextBox1.TabIndex = 3;
            this.coefficientTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoefficientTextBox1_KeyPress);
            // 
            // toGraphTheEquationButton
            // 
            this.toGraphTheEquationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toGraphTheEquationButton.Location = new System.Drawing.Point(369, 390);
            this.toGraphTheEquationButton.Name = "toGraphTheEquationButton";
            this.toGraphTheEquationButton.Size = new System.Drawing.Size(419, 48);
            this.toGraphTheEquationButton.TabIndex = 4;
            this.toGraphTheEquationButton.Text = "Plot the sine graph";
            this.toGraphTheEquationButton.UseVisualStyleBackColor = true;
            this.toGraphTheEquationButton.Click += new System.EventHandler(this.ToGraphTheEquationButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "x +";
            // 
            // coefficientTextBox2
            // 
            this.coefficientTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefficientTextBox2.Location = new System.Drawing.Point(199, 358);
            this.coefficientTextBox2.Name = "coefficientTextBox2";
            this.coefficientTextBox2.Size = new System.Drawing.Size(78, 26);
            this.coefficientTextBox2.TabIndex = 6;
            this.coefficientTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoefficientTextBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(283, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = ") +";
            // 
            // coefficientTextBox3
            // 
            this.coefficientTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefficientTextBox3.Location = new System.Drawing.Point(317, 358);
            this.coefficientTextBox3.Name = "coefficientTextBox3";
            this.coefficientTextBox3.Size = new System.Drawing.Size(78, 26);
            this.coefficientTextBox3.TabIndex = 8;
            this.coefficientTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CoefficientTextBox3_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(401, 361);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "   a:";
            // 
            // leftLimitTextBox
            // 
            this.leftLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.leftLimitTextBox.Location = new System.Drawing.Point(441, 358);
            this.leftLimitTextBox.Name = "leftLimitTextBox";
            this.leftLimitTextBox.Size = new System.Drawing.Size(78, 26);
            this.leftLimitTextBox.TabIndex = 10;
            this.leftLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LeftLimitTextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(525, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "b:";
            // 
            // rightLimitTextBox
            // 
            this.rightLimitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rightLimitTextBox.Location = new System.Drawing.Point(553, 358);
            this.rightLimitTextBox.Name = "rightLimitTextBox";
            this.rightLimitTextBox.Size = new System.Drawing.Size(78, 26);
            this.rightLimitTextBox.TabIndex = 12;
            this.rightLimitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RightLimitTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(641, 361);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "    Step:";
            // 
            // stepTextBox
            // 
            this.stepTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stepTextBox.Location = new System.Drawing.Point(710, 358);
            this.stepTextBox.Name = "stepTextBox";
            this.stepTextBox.Size = new System.Drawing.Size(78, 26);
            this.stepTextBox.TabIndex = 14;
            this.stepTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StepTextBox_KeyPress);
            // 
            // theGraphingOfEquations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stepTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rightLimitTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.leftLimitTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.coefficientTextBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coefficientTextBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toGraphTheEquationButton);
            this.Controls.Add(this.coefficientTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.graphicsGroupBox);
            this.Controls.Add(this.mainChart);
            this.Name = "theGraphingOfEquations";
            this.Text = "The graphing of equations";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.graphicsGroupBox.ResumeLayout(false);
            this.graphicsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox graphicsGroupBox;
        private System.Windows.Forms.CheckBox sinCosCheckBox;
        private System.Windows.Forms.CheckBox cosCheckBox;
        private System.Windows.Forms.CheckBox sinCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coefficientTextBox1;
        private System.Windows.Forms.Button toGraphTheEquationButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox coefficientTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox coefficientTextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox leftLimitTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rightLimitTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stepTextBox;
    }
}

