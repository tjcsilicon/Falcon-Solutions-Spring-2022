namespace WindowsFormsApp1
{
    partial class TestingFormApplication
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
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.latitude_label = new System.Windows.Forms.Label();
            this.longitude_label = new System.Windows.Forms.Label();
            this.data_graph = new LiveCharts.WinForms.CartesianChart();
            this.add_series_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(224, 28);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 15;
            this.gMapControl.MinZoom = 15;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(600, 350);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            // 
            // latitude_label
            // 
            this.latitude_label.AutoSize = true;
            this.latitude_label.Location = new System.Drawing.Point(880, 302);
            this.latitude_label.Name = "latitude_label";
            this.latitude_label.Size = new System.Drawing.Size(35, 13);
            this.latitude_label.TabIndex = 3;
            this.latitude_label.Text = "label3";
            // 
            // longitude_label
            // 
            this.longitude_label.AutoSize = true;
            this.longitude_label.Location = new System.Drawing.Point(880, 315);
            this.longitude_label.Name = "longitude_label";
            this.longitude_label.Size = new System.Drawing.Size(35, 13);
            this.longitude_label.TabIndex = 4;
            this.longitude_label.Text = "label3";
            // 
            // data_graph
            // 
            this.data_graph.Location = new System.Drawing.Point(224, 436);
            this.data_graph.Name = "data_graph";
            this.data_graph.Size = new System.Drawing.Size(600, 150);
            this.data_graph.TabIndex = 5;
            this.data_graph.Text = "cartesianChart1";
            // 
            // add_series_button
            // 
            this.add_series_button.Location = new System.Drawing.Point(917, 355);
            this.add_series_button.Name = "add_series_button";
            this.add_series_button.Size = new System.Drawing.Size(75, 23);
            this.add_series_button.TabIndex = 6;
            this.add_series_button.Text = "Add Series";
            this.add_series_button.UseVisualStyleBackColor = true;
            this.add_series_button.Click += new System.EventHandler(this.Add_series_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 631);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gMapControl);
            this.tabPage1.Controls.Add(this.add_series_button);
            this.tabPage1.Controls.Add(this.data_graph);
            this.tabPage1.Controls.Add(this.latitude_label);
            this.tabPage1.Controls.Add(this.longitude_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(757, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 549);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(57, 36);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 537);
            this.listBox1.TabIndex = 1;
            // 
            // TestingFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 645);
            this.Controls.Add(this.tabControl1);
            this.Name = "TestingFormApplication";
            this.Text = "GMap Test Form";
            this.Load += new System.EventHandler(this.TestingFormApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label latitude_label;
        private System.Windows.Forms.Label longitude_label;
        private LiveCharts.WinForms.CartesianChart data_graph;
        private System.Windows.Forms.Button add_series_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

