﻿namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.data_graph = new LiveCharts.WinForms.CartesianChart();
            this.add_series_button = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.run_simulation_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.individual_listbox = new System.Windows.Forms.ListBox();
            this.individual_data = new System.Windows.Forms.GroupBox();
            this.individual_data_connections = new System.Windows.Forms.ListBox();
            this.individual_data_status = new System.Windows.Forms.Label();
            this.individual_data_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.simulation_update_timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.individual_data.SuspendLayout();
            this.tabPage3.SuspendLayout();
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
            this.gMapControl.Location = new System.Drawing.Point(6, 6);
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
            this.gMapControl.Size = new System.Drawing.Size(1042, 372);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            // 
            // data_graph
            // 
            this.data_graph.Location = new System.Drawing.Point(6, 384);
            this.data_graph.Name = "data_graph";
            this.data_graph.Size = new System.Drawing.Size(905, 215);
            this.data_graph.TabIndex = 5;
            this.data_graph.Text = "cartesianChart1";
            // 
            // add_series_button
            // 
            this.add_series_button.Location = new System.Drawing.Point(1022, 635);
            this.add_series_button.Name = "add_series_button";
            this.add_series_button.Size = new System.Drawing.Size(75, 10);
            this.add_series_button.TabIndex = 6;
            this.add_series_button.Text = "Add Series";
            this.add_series_button.UseVisualStyleBackColor = true;
            this.add_series_button.Click += new System.EventHandler(this.Add_series_button_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1073, 631);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.run_simulation_button);
            this.tabPage1.Controls.Add(this.gMapControl);
            this.tabPage1.Controls.Add(this.data_graph);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1065, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // run_simulation_button
            // 
            this.run_simulation_button.Location = new System.Drawing.Point(959, 408);
            this.run_simulation_button.Name = "run_simulation_button";
            this.run_simulation_button.Size = new System.Drawing.Size(75, 23);
            this.run_simulation_button.TabIndex = 7;
            this.run_simulation_button.Text = "Run";
            this.run_simulation_button.UseVisualStyleBackColor = true;
            this.run_simulation_button.Click += new System.EventHandler(this.run_simulation_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.individual_listbox);
            this.tabPage2.Controls.Add(this.individual_data);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1065, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Population Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // individual_listbox
            // 
            this.individual_listbox.FormattingEnabled = true;
            this.individual_listbox.Location = new System.Drawing.Point(57, 36);
            this.individual_listbox.Name = "individual_listbox";
            this.individual_listbox.Size = new System.Drawing.Size(120, 537);
            this.individual_listbox.TabIndex = 1;
            this.individual_listbox.SelectedIndexChanged += new System.EventHandler(this.Individual_listbox_SelectedIndexChanged);
            // 
            // individual_data
            // 
            this.individual_data.Controls.Add(this.individual_data_connections);
            this.individual_data.Controls.Add(this.individual_data_status);
            this.individual_data.Controls.Add(this.individual_data_name);
            this.individual_data.Location = new System.Drawing.Point(787, 36);
            this.individual_data.Name = "individual_data";
            this.individual_data.Size = new System.Drawing.Size(200, 549);
            this.individual_data.TabIndex = 0;
            this.individual_data.TabStop = false;
            // 
            // individual_data_connections
            // 
            this.individual_data_connections.FormattingEnabled = true;
            this.individual_data_connections.Location = new System.Drawing.Point(9, 135);
            this.individual_data_connections.Name = "individual_data_connections";
            this.individual_data_connections.Size = new System.Drawing.Size(174, 147);
            this.individual_data_connections.TabIndex = 4;
            // 
            // individual_data_status
            // 
            this.individual_data_status.AutoSize = true;
            this.individual_data_status.Location = new System.Drawing.Point(7, 67);
            this.individual_data_status.Name = "individual_data_status";
            this.individual_data_status.Size = new System.Drawing.Size(35, 13);
            this.individual_data_status.TabIndex = 1;
            this.individual_data_status.Text = "label2";
            // 
            // individual_data_name
            // 
            this.individual_data_name.AutoSize = true;
            this.individual_data_name.Location = new System.Drawing.Point(7, 20);
            this.individual_data_name.Name = "individual_data_name";
            this.individual_data_name.Size = new System.Drawing.Size(35, 13);
            this.individual_data_name.TabIndex = 0;
            this.individual_data_name.Text = "label1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.outputBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1065, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(4, 13);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(1058, 576);
            this.outputBox.TabIndex = 0;
            // 
            // simulation_update_timer
            // 
            this.simulation_update_timer.Tick += new System.EventHandler(this.simulation_update_timer_Tick);
            // 
            // TestingFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 645);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.add_series_button);
            this.Name = "TestingFormApplication";
            this.Text = "GMap Test Form";
            this.Load += new System.EventHandler(this.TestingFormApplication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.individual_data.ResumeLayout(false);
            this.individual_data.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private LiveCharts.WinForms.CartesianChart data_graph;
        private System.Windows.Forms.Button add_series_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox individual_listbox;
        private System.Windows.Forms.GroupBox individual_data;
        private System.Windows.Forms.ListBox individual_data_connections;
        private System.Windows.Forms.Label individual_data_status;
        private System.Windows.Forms.Label individual_data_name;
        private System.Windows.Forms.Button run_simulation_button;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox outputBox;
        private System.Windows.Forms.Timer simulation_update_timer;
    }
}

