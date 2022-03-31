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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.beginButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(100, 13);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(90, 13);
            this.label_1.TabIndex = 0;
            this.label_1.Text = "Set Initial Position";
            // 
            // pos_x_field
            // 
            this.pos_x_field.Location = new System.Drawing.Point(153, 29);
            this.pos_x_field.Name = "pos_x_field";
            this.pos_x_field.Size = new System.Drawing.Size(136, 20);
            this.pos_x_field.TabIndex = 1;
            this.pos_x_field.TextChanged += new System.EventHandler(this.Pos_x_field_TextChanged);
            // 
            // pos_y_field
            // 
            this.pos_y_field.Location = new System.Drawing.Point(153, 55);
            this.pos_y_field.Name = "pos_y_field";
            this.pos_y_field.Size = new System.Drawing.Size(136, 20);
            this.pos_y_field.TabIndex = 2;
            this.pos_y_field.TextChanged += new System.EventHandler(this.Pos_y_field_TextChanged);
            // 
            // Latitude_label
            // 
            this.Latitude_label.AutoSize = true;
            this.Latitude_label.Location = new System.Drawing.Point(70, 32);
            this.Latitude_label.Name = "Latitude_label";
            this.Latitude_label.Size = new System.Drawing.Size(45, 13);
            this.Latitude_label.TabIndex = 3;
            this.Latitude_label.Text = "Latitude";
            // 
            // long_label
            // 
            this.long_label.AutoSize = true;
            this.long_label.Location = new System.Drawing.Point(61, 58);
            this.long_label.Name = "long_label";
            this.long_label.Size = new System.Drawing.Size(54, 13);
            this.long_label.TabIndex = 4;
            this.long_label.Text = "Longitude";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Location = new System.Drawing.Point(51, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 287);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Simulation Parameters";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label_1);
            this.panel2.Controls.Add(this.pos_x_field);
            this.panel2.Controls.Add(this.long_label);
            this.panel2.Controls.Add(this.pos_y_field);
            this.panel2.Controls.Add(this.Latitude_label);
            this.panel2.Location = new System.Drawing.Point(18, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 100);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vaccine Count";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 58);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Display Connections";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(98, 81);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(264, 316);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(144, 23);
            this.beginButton.TabIndex = 0;
            this.beginButton.Text = "Run Simulation";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.BeginButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Fetch Dataset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SetInitialPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.beginButton);
            this.Name = "SetInitialPosition";
            this.Text = "Simulation Setup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox pos_x_field;
        private System.Windows.Forms.TextBox pos_y_field;
        private System.Windows.Forms.Label Latitude_label;
        private System.Windows.Forms.Label long_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button button2;
    }
}