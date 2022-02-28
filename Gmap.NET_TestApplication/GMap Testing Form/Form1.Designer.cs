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
            this.gMapControl.Location = new System.Drawing.Point(45, 30);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 13;
            this.gMapControl.MinZoom = 13;
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
            this.latitude_label.Location = new System.Drawing.Point(45, 386);
            this.latitude_label.Name = "latitude_label";
            this.latitude_label.Size = new System.Drawing.Size(35, 13);
            this.latitude_label.TabIndex = 3;
            this.latitude_label.Text = "label3";
            // 
            // longitude_label
            // 
            this.longitude_label.AutoSize = true;
            this.longitude_label.Location = new System.Drawing.Point(146, 386);
            this.longitude_label.Name = "longitude_label";
            this.longitude_label.Size = new System.Drawing.Size(35, 13);
            this.longitude_label.TabIndex = 4;
            this.longitude_label.Text = "label3";
            // 
            // data_graph
            // 
            this.data_graph.Location = new System.Drawing.Point(45, 423);
            this.data_graph.Name = "data_graph";
            this.data_graph.Size = new System.Drawing.Size(600, 150);
            this.data_graph.TabIndex = 5;
            this.data_graph.Text = "cartesianChart1";
            // 
            // add_series_button
            // 
            this.add_series_button.Location = new System.Drawing.Point(5, 402);
            this.add_series_button.Name = "add_series_button";
            this.add_series_button.Size = new System.Drawing.Size(75, 23);
            this.add_series_button.TabIndex = 6;
            this.add_series_button.Text = "Add Series";
            this.add_series_button.UseVisualStyleBackColor = true;
            this.add_series_button.Click += new System.EventHandler(this.Add_series_button_Click);
            // 
            // TestingFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 601);
            this.Controls.Add(this.add_series_button);
            this.Controls.Add(this.data_graph);
            this.Controls.Add(this.longitude_label);
            this.Controls.Add(this.latitude_label);
            this.Controls.Add(this.gMapControl);
            this.Name = "TestingFormApplication";
            this.Text = "GMap Test Form";
            this.Load += new System.EventHandler(this.TestingFormApplication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Label latitude_label;
        private System.Windows.Forms.Label longitude_label;
        private LiveCharts.WinForms.CartesianChart data_graph;
        private System.Windows.Forms.Button add_series_button;
    }
}

