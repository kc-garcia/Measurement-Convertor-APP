
namespace Measurement_Convertor_APP
{
    partial class ConvertorGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMeasurement = new System.Windows.Forms.TextBox();
            this.labelConvert = new System.Windows.Forms.Label();
            this.labelOperation = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxMeasurement
            // 
            this.textBoxMeasurement.Location = new System.Drawing.Point(143, 55);
            this.textBoxMeasurement.Name = "textBoxMeasurement";
            this.textBoxMeasurement.Size = new System.Drawing.Size(392, 27);
            this.textBoxMeasurement.TabIndex = 0;
            this.textBoxMeasurement.Text = "Only Numbers";
            this.textBoxMeasurement.TextChanged += new System.EventHandler(this.textBoxMeasurement_TextChanged);
            // 
            // labelConvert
            // 
            this.labelConvert.AutoSize = true;
            this.labelConvert.Location = new System.Drawing.Point(56, 62);
            this.labelConvert.Name = "labelConvert";
            this.labelConvert.Size = new System.Drawing.Size(60, 20);
            this.labelConvert.TabIndex = 1;
            this.labelConvert.Text = "Convert";
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.Location = new System.Drawing.Point(56, 117);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(43, 20);
            this.labelOperation.TabIndex = 3;
            this.labelOperation.Text = "From";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(143, 229);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(392, 27);
            this.textBoxResult.TabIndex = 4;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(56, 236);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(49, 20);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "Result";
            // 
            // buttonConvert
            // 
            this.buttonConvert.Location = new System.Drawing.Point(265, 178);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(94, 29);
            this.buttonConvert.TabIndex = 6;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.buttonConvert_Click);
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(143, 117);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(392, 28);
            this.comboBoxOperations.TabIndex = 7;
            this.comboBoxOperations.Items.AddRange(new object[] {
            "Centimeters To Inches",
            "Feet To Meters",
            "Inches To Centimeters",
            "Kilometers To Miles",
            "Meters To Feet",
            "Miles To Kilometers"});
            // 
            // ConvertorGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(626, 288);
            this.Controls.Add(this.comboBoxOperations);
            this.Controls.Add(this.buttonConvert);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.labelConvert);
            this.Controls.Add(this.textBoxMeasurement);
            this.Name = "ConvertorGUI";
            this.Text = "Measurement Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMeasurement;
        private System.Windows.Forms.Label labelConvert;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ComboBox comboBoxOperations;
    }
}

