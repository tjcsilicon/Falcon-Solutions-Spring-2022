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
            this.initialPositionSet_groupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updatePosButton = new System.Windows.Forms.Button();
            this.pos_x_field = new System.Windows.Forms.TextBox();
            this.pos_y_field = new System.Windows.Forms.TextBox();
            this.latitude_label = new System.Windows.Forms.Label();
            this.longitude_label = new System.Windows.Forms.Label();
            this.initialPositionSet_groupBox.SuspendLayout();
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
            this.gMapControl.MaxZoom = 25;
            this.gMapControl.MinZoom = 2;
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
            // initialPositionSet_groupBox
            // 
            this.initialPositionSet_groupBox.Controls.Add(this.pos_y_field);
            this.initialPositionSet_groupBox.Controls.Add(this.pos_x_field);
            this.initialPositionSet_groupBox.Controls.Add(this.label2);
            this.initialPositionSet_groupBox.Controls.Add(this.label1);
            this.initialPositionSet_groupBox.Controls.Add(this.updatePosButton);
            this.initialPositionSet_groupBox.Location = new System.Drawing.Point(491, 386);
            this.initialPositionSet_groupBox.Name = "initialPositionSet_groupBox";
            this.initialPositionSet_groupBox.Size = new System.Drawing.Size(200, 100);
            this.initialPositionSet_groupBox.TabIndex = 2;
            this.initialPositionSet_groupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Longitute";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Latitude";
            // 
            // updatePosButton
            // 
            this.updatePosButton.Location = new System.Drawing.Point(40, 71);
            this.updatePosButton.Name = "updatePosButton";
            this.updatePosButton.Size = new System.Drawing.Size(114, 23);
            this.updatePosButton.TabIndex = 2;
            this.updatePosButton.Text = "Update Position";
            this.updatePosButton.UseVisualStyleBackColor = true;
            this.updatePosButton.Click += new System.EventHandler(this.UpdatePosButton_Click);
            // 
            // pos_x_field
            // 
            this.pos_x_field.Location = new System.Drawing.Point(68, 18);
            this.pos_x_field.Name = "pos_x_field";
            this.pos_x_field.Size = new System.Drawing.Size(100, 20);
            this.pos_x_field.TabIndex = 5;
            this.pos_x_field.Text = "0";
            this.pos_x_field.TextChanged += new System.EventHandler(this.Pos_x_field_TextChanged);
            // 
            // pos_y_field
            // 
            this.pos_y_field.Location = new System.Drawing.Point(68, 44);
            this.pos_y_field.Name = "pos_y_field";
            this.pos_y_field.Size = new System.Drawing.Size(100, 20);
            this.pos_y_field.TabIndex = 6;
            this.pos_y_field.Text = "0";
            this.pos_y_field.TextChanged += new System.EventHandler(this.Pos_y_field_TextChanged);
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
            // TestingFormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 601);
            this.Controls.Add(this.longitude_label);
            this.Controls.Add(this.latitude_label);
            this.Controls.Add(this.initialPositionSet_groupBox);
            this.Controls.Add(this.gMapControl);
            this.Name = "TestingFormApplication";
            this.Text = "GMap Test Form";
            this.Load += new System.EventHandler(this.TestingFormApplication_Load);
            this.initialPositionSet_groupBox.ResumeLayout(false);
            this.initialPositionSet_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.GroupBox initialPositionSet_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatePosButton;
        private System.Windows.Forms.TextBox pos_y_field;
        private System.Windows.Forms.TextBox pos_x_field;
        private System.Windows.Forms.Label latitude_label;
        private System.Windows.Forms.Label longitude_label;
    }
}

