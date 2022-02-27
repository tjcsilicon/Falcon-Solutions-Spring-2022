namespace WindowsFormsApp1
{
    partial class SetInitialPosition
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
            this.label_1 = new System.Windows.Forms.Label();
            this.pos_x_field = new System.Windows.Forms.TextBox();
            this.pos_y_field = new System.Windows.Forms.TextBox();
            this.Latitude_label = new System.Windows.Forms.Label();
            this.long_label = new System.Windows.Forms.Label();
            this.beginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(192, 9);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(90, 13);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Set Initial Position";
            // 
            // pos_x_field
            // 
            this.pos_x_field.Location = new System.Drawing.Point(170, 25);
            this.pos_x_field.Name = "pos_x_field";
            this.pos_x_field.Size = new System.Drawing.Size(136, 20);
            this.pos_x_field.TabIndex = 1;
            this.pos_x_field.TextChanged += new System.EventHandler(this.Pos_x_field_TextChanged);
            // 
            // pos_y_field
            // 
            this.pos_y_field.Location = new System.Drawing.Point(170, 51);
            this.pos_y_field.Name = "pos_y_field";
            this.pos_y_field.Size = new System.Drawing.Size(136, 20);
            this.pos_y_field.TabIndex = 2;
            this.pos_y_field.TextChanged += new System.EventHandler(this.Pos_y_field_TextChanged);
            // 
            // Latitude_label
            // 
            this.Latitude_label.AutoSize = true;
            this.Latitude_label.Location = new System.Drawing.Point(119, 28);
            this.Latitude_label.Name = "Latitude_label";
            this.Latitude_label.Size = new System.Drawing.Size(45, 13);
            this.Latitude_label.TabIndex = 3;
            this.Latitude_label.Text = "Latitude";
            // 
            // long_label
            // 
            this.long_label.AutoSize = true;
            this.long_label.Location = new System.Drawing.Point(110, 54);
            this.long_label.Name = "long_label";
            this.long_label.Size = new System.Drawing.Size(54, 13);
            this.long_label.TabIndex = 4;
            this.long_label.Text = "Longitude";
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(195, 77);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(75, 23);
            this.beginButton.TabIndex = 5;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // SetInitialPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 140);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.long_label);
            this.Controls.Add(this.Latitude_label);
            this.Controls.Add(this.pos_y_field);
            this.Controls.Add(this.pos_x_field);
            this.Controls.Add(this.label_1);
            this.Name = "SetInitialPosition";
            this.Text = "SetInitialPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox pos_x_field;
        private System.Windows.Forms.TextBox pos_y_field;
        private System.Windows.Forms.Label Latitude_label;
        private System.Windows.Forms.Label long_label;
        private System.Windows.Forms.Button beginButton;
    }
}