namespace WindowsFormsApp1
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.value_box = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.add_value_button = new System.Windows.Forms.Button();
            this.values_label = new System.Windows.Forms.Label();
            this.add_series_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.values_label);
            this.groupBox1.Controls.Add(this.add_value_button);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.value_box);
            this.groupBox1.Location = new System.Drawing.Point(142, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 268);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // value_box
            // 
            this.value_box.Location = new System.Drawing.Point(86, 53);
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(100, 20);
            this.value_box.TabIndex = 0;
            this.value_box.TextChanged += new System.EventHandler(this.Value_box_TextChanged);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(103, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Add Value";
            // 
            // add_value_button
            // 
            this.add_value_button.Location = new System.Drawing.Point(97, 79);
            this.add_value_button.Name = "add_value_button";
            this.add_value_button.Size = new System.Drawing.Size(75, 23);
            this.add_value_button.TabIndex = 2;
            this.add_value_button.Text = "Add";
            this.add_value_button.UseVisualStyleBackColor = true;
            this.add_value_button.Click += new System.EventHandler(this.Add_value_button_Click);
            // 
            // values_label
            // 
            this.values_label.AutoSize = true;
            this.values_label.Location = new System.Drawing.Point(7, 156);
            this.values_label.Name = "values_label";
            this.values_label.Size = new System.Drawing.Size(23, 13);
            this.values_label.TabIndex = 3;
            this.values_label.Text = "null";
            // 
            // add_series_button
            // 
            this.add_series_button.Location = new System.Drawing.Point(239, 304);
            this.add_series_button.Name = "add_series_button";
            this.add_series_button.Size = new System.Drawing.Size(75, 23);
            this.add_series_button.TabIndex = 4;
            this.add_series_button.Text = "Add Series";
            this.add_series_button.UseVisualStyleBackColor = true;
            this.add_series_button.Click += new System.EventHandler(this.Add_series_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 388);
            this.Controls.Add(this.add_series_button);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label values_label;
        private System.Windows.Forms.Button add_value_button;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox value_box;
        private System.Windows.Forms.Button add_series_button;
    }
}