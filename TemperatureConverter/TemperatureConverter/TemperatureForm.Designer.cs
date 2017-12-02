namespace TemperatureConverter
{
    partial class TemperatureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemperatureForm));
            this.convertButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tempLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.degreesLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.CtoFradioButton = new System.Windows.Forms.RadioButton();
            this.FtoCradioButton = new System.Windows.Forms.RadioButton();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.developerButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.GreenYellow;
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(37, 186);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(74, 23);
            this.convertButton.TabIndex = 3;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.GreenYellow;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(204, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.GreenYellow;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.Black;
            this.tempLabel.Location = new System.Drawing.Point(-2, 0);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(334, 22);
            this.tempLabel.TabIndex = 7;
            this.tempLabel.Text = "Jennifer Sutton";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.GreenYellow;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(123, 186);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(57, 141);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(210, 23);
            this.errorLabel.TabIndex = 9;
            // 
            // degreesLabel
            // 
            this.degreesLabel.AutoSize = true;
            this.degreesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.degreesLabel.ForeColor = System.Drawing.Color.White;
            this.degreesLabel.Location = new System.Drawing.Point(57, 126);
            this.degreesLabel.Name = "degreesLabel";
            this.degreesLabel.Size = new System.Drawing.Size(58, 13);
            this.degreesLabel.TabIndex = 10;
            this.degreesLabel.Text = "Degrees:";
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.Black;
            this.resultLabel.Location = new System.Drawing.Point(119, 118);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(109, 23);
            this.resultLabel.TabIndex = 11;
            // 
            // CtoFradioButton
            // 
            this.CtoFradioButton.AutoSize = true;
            this.CtoFradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CtoFradioButton.ForeColor = System.Drawing.Color.White;
            this.CtoFradioButton.Location = new System.Drawing.Point(60, 45);
            this.CtoFradioButton.Name = "CtoFradioButton";
            this.CtoFradioButton.Size = new System.Drawing.Size(161, 19);
            this.CtoFradioButton.TabIndex = 1;
            this.CtoFradioButton.Text = "Celsius to Fahrenheit";
            this.CtoFradioButton.UseVisualStyleBackColor = true;
            // 
            // FtoCradioButton
            // 
            this.FtoCradioButton.AutoSize = true;
            this.FtoCradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FtoCradioButton.ForeColor = System.Drawing.Color.White;
            this.FtoCradioButton.Location = new System.Drawing.Point(60, 92);
            this.FtoCradioButton.Name = "FtoCradioButton";
            this.FtoCradioButton.Size = new System.Drawing.Size(161, 19);
            this.FtoCradioButton.TabIndex = 2;
            this.FtoCradioButton.Text = "Fahrenheit to Celsius";
            this.FtoCradioButton.UseVisualStyleBackColor = true;
            // 
            // tempTextBox
            // 
            this.tempTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTextBox.Location = new System.Drawing.Point(141, 70);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(80, 20);
            this.tempTextBox.TabIndex = 0;
            this.tempTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tempTextBox_KeyDown);
            this.tempTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tempTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Temperature";
            // 
            // developerButton
            // 
            this.developerButton.BackColor = System.Drawing.Color.GreenYellow;
            this.developerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developerButton.Location = new System.Drawing.Point(123, 215);
            this.developerButton.Name = "developerButton";
            this.developerButton.Size = new System.Drawing.Size(75, 16);
            this.developerButton.TabIndex = 16;
            this.developerButton.Text = "About";
            this.developerButton.UseVisualStyleBackColor = false;
            this.developerButton.Click += new System.EventHandler(this.developerButton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // TemperatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(330, 233);
            this.Controls.Add(this.developerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.FtoCradioButton);
            this.Controls.Add(this.CtoFradioButton);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.degreesLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.convertButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TemperatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter";
            this.Load += new System.EventHandler(this.clearButton_Click);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label degreesLabel;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RadioButton CtoFradioButton;
        private System.Windows.Forms.RadioButton FtoCradioButton;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button developerButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

