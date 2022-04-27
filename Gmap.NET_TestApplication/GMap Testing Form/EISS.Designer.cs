namespace WindowsFormsApp1
{
    partial class MainSimulation
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.run_simulation_button = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.individual_listbox = new System.Windows.Forms.ListBox();
            this.individual_data = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.individual_data_connections = new System.Windows.Forms.ListBox();
            this.individual_data_status = new System.Windows.Forms.Label();
            this.individual_data_name = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.outputBox = new System.Windows.Forms.ListBox();
            this.simulation_update_timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.individual_data.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.gMapControl.MaxZoom = 14;
            this.gMapControl.MinZoom = 14;
            this.gMapControl.MouseWheelZoomEnabled = true;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = true;
            this.gMapControl.Size = new System.Drawing.Size(1668, 696);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 14D;
            // 
            // data_graph
            // 
            this.data_graph.Location = new System.Drawing.Point(6, 708);
            this.data_graph.Name = "data_graph";
            this.data_graph.Size = new System.Drawing.Size(1392, 259);
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
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1710, 999);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.run_simulation_button);
            this.tabPage1.Controls.Add(this.gMapControl);
            this.tabPage1.Controls.Add(this.data_graph);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1702, 973);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Simulation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1414, 708);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 183);
            this.panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.IndividualIcon_Vaccinated_large;
            this.pictureBox1.Location = new System.Drawing.Point(14, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // run_simulation_button
            // 
            this.run_simulation_button.Location = new System.Drawing.Point(1514, 912);
            this.run_simulation_button.Name = "run_simulation_button";
            this.run_simulation_button.Size = new System.Drawing.Size(75, 23);
            this.run_simulation_button.TabIndex = 7;
            this.run_simulation_button.Text = "Run";
            this.run_simulation_button.UseVisualStyleBackColor = true;
            this.run_simulation_button.Click += new System.EventHandler(this.run_simulation_button_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.individual_listbox);
            this.tabPage2.Controls.Add(this.individual_data);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1702, 973);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Population Data";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Population";
            // 
            // individual_listbox
            // 
            this.individual_listbox.FormattingEnabled = true;
            this.individual_listbox.Location = new System.Drawing.Point(129, 45);
            this.individual_listbox.Name = "individual_listbox";
            this.individual_listbox.Size = new System.Drawing.Size(210, 498);
            this.individual_listbox.TabIndex = 1;
            this.individual_listbox.SelectedIndexChanged += new System.EventHandler(this.OnListboxSelect);
            // 
            // individual_data
            // 
            this.individual_data.Controls.Add(this.label2);
            this.individual_data.Controls.Add(this.individual_data_connections);
            this.individual_data.Controls.Add(this.individual_data_status);
            this.individual_data.Controls.Add(this.individual_data_name);
            this.individual_data.Location = new System.Drawing.Point(372, 45);
            this.individual_data.Name = "individual_data";
            this.individual_data.Size = new System.Drawing.Size(200, 498);
            this.individual_data.TabIndex = 0;
            this.individual_data.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connections -- Weights";
            // 
            // individual_data_connections
            // 
            this.individual_data_connections.FormattingEnabled = true;
            this.individual_data_connections.Location = new System.Drawing.Point(9, 96);
            this.individual_data_connections.Name = "individual_data_connections";
            this.individual_data_connections.Size = new System.Drawing.Size(174, 381);
            this.individual_data_connections.TabIndex = 4;
            // 
            // individual_data_status
            // 
            this.individual_data_status.AutoSize = true;
            this.individual_data_status.Location = new System.Drawing.Point(6, 42);
            this.individual_data_status.Name = "individual_data_status";
            this.individual_data_status.Size = new System.Drawing.Size(0, 13);
            this.individual_data_status.TabIndex = 1;
            // 
            // individual_data_name
            // 
            this.individual_data_name.AutoSize = true;
            this.individual_data_name.Location = new System.Drawing.Point(6, 16);
            this.individual_data_name.Name = "individual_data_name";
            this.individual_data_name.Size = new System.Drawing.Size(0, 13);
            this.individual_data_name.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.outputBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1702, 973);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            this.outputBox.FormattingEnabled = true;
            this.outputBox.Location = new System.Drawing.Point(3, 3);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(721, 589);
            this.outputBox.TabIndex = 0;
            // 
            // simulation_update_timer
            // 
            this.simulation_update_timer.Interval = 1500;
            this.simulation_update_timer.Tick += new System.EventHandler(this.OnDummyTimer);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.IndividualIcon_Recovered_large;
            this.pictureBox2.Location = new System.Drawing.Point(14, 75);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApp1.Properties.Resources.IndividualIcon_Infected_large;
            this.pictureBox3.Location = new System.Drawing.Point(14, 106);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApp1.Properties.Resources.IndividualIcon_Susceptable_large;
            this.pictureBox4.Location = new System.Drawing.Point(14, 137);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vaccinated";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Recovered";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Infected";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Susceptible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Individuals";
            // 
            // MainSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 1013);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.add_series_button);
            this.Name = "MainSimulation";
            this.Text = "EISS";
            this.Load += new System.EventHandler(this.OnLoad);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.individual_data.ResumeLayout(false);
            this.individual_data.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

