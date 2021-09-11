
namespace ClimateSensors
{
    partial class ClimateSensorsForm
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
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbHumidity = new System.Windows.Forms.TextBox();
            this.tbWindSpeed = new System.Windows.Forms.TextBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelWindSpeed = new System.Windows.Forms.Label();
            this.groupBoxDataEntry = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelSensorReadings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.groupBoxDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 20);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.Size = new System.Drawing.Size(341, 257);
            this.dataGrid1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save Values";
            this.toolTip1.SetToolTip(this.btnSave, "Click this to save the contents of the textbox to the CSV file.");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbTemp
            // 
            this.tbTemp.Location = new System.Drawing.Point(112, 19);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(100, 20);
            this.tbTemp.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tbTemp, "Enter Temperature");
            // 
            // tbHumidity
            // 
            this.tbHumidity.Location = new System.Drawing.Point(112, 45);
            this.tbHumidity.Name = "tbHumidity";
            this.tbHumidity.Size = new System.Drawing.Size(100, 20);
            this.tbHumidity.TabIndex = 8;
            this.toolTip1.SetToolTip(this.tbHumidity, "Enter Humidity");
            // 
            // tbWindSpeed
            // 
            this.tbWindSpeed.Location = new System.Drawing.Point(112, 71);
            this.tbWindSpeed.Name = "tbWindSpeed";
            this.tbWindSpeed.Size = new System.Drawing.Size(100, 20);
            this.tbWindSpeed.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tbWindSpeed, "Enter Wind Speed");
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(218, 22);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(87, 13);
            this.labelTemp.TabIndex = 10;
            this.labelTemp.Text = "Temperature (°C)";
            this.toolTip1.SetToolTip(this.labelTemp, "Stumbling hopelessly through the void, we look to the tooltips for guidance; but " +
        "often we find the tooltips are as empty as we are");
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(218, 48);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(103, 13);
            this.labelHumidity.TabIndex = 11;
            this.labelHumidity.Text = "Humidity (Relative%)";
            // 
            // labelWindSpeed
            // 
            this.labelWindSpeed.AutoSize = true;
            this.labelWindSpeed.Location = new System.Drawing.Point(218, 71);
            this.labelWindSpeed.Name = "labelWindSpeed";
            this.labelWindSpeed.Size = new System.Drawing.Size(100, 13);
            this.labelWindSpeed.TabIndex = 12;
            this.labelWindSpeed.Text = "Wind Speed (km/h)";
            // 
            // groupBoxDataEntry
            // 
            this.groupBoxDataEntry.Controls.Add(this.btnSearch);
            this.groupBoxDataEntry.Controls.Add(this.btnClear);
            this.groupBoxDataEntry.Controls.Add(this.btnOpen);
            this.groupBoxDataEntry.Controls.Add(this.tbTemp);
            this.groupBoxDataEntry.Controls.Add(this.labelWindSpeed);
            this.groupBoxDataEntry.Controls.Add(this.btnSave);
            this.groupBoxDataEntry.Controls.Add(this.labelHumidity);
            this.groupBoxDataEntry.Controls.Add(this.tbHumidity);
            this.groupBoxDataEntry.Controls.Add(this.labelTemp);
            this.groupBoxDataEntry.Controls.Add(this.tbWindSpeed);
            this.groupBoxDataEntry.Location = new System.Drawing.Point(12, 283);
            this.groupBoxDataEntry.Name = "groupBoxDataEntry";
            this.groupBoxDataEntry.Size = new System.Drawing.Size(341, 131);
            this.groupBoxDataEntry.TabIndex = 13;
            this.groupBoxDataEntry.TabStop = false;
            this.groupBoxDataEntry.Text = "Data Entry";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 71);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.toolTip1.SetToolTip(this.btnClear, "Clears all text boxes");
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(6, 19);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(100, 23);
            this.btnOpen.TabIndex = 14;
            this.btnOpen.Text = "Open CSV File";
            this.toolTip1.SetToolTip(this.btnOpen, "Was the button label not descriptive enough");
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(6, 100);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(206, 23);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search Temperature";
            this.toolTip1.SetToolTip(this.btnSearch, "Enter number in Temperature field and click here to search for it.");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelSensorReadings
            // 
            this.labelSensorReadings.AutoSize = true;
            this.labelSensorReadings.Location = new System.Drawing.Point(9, 4);
            this.labelSensorReadings.Name = "labelSensorReadings";
            this.labelSensorReadings.Size = new System.Drawing.Size(88, 13);
            this.labelSensorReadings.TabIndex = 14;
            this.labelSensorReadings.Text = "Sensor Readings";
            // 
            // ClimateSensorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 425);
            this.Controls.Add(this.labelSensorReadings);
            this.Controls.Add(this.groupBoxDataEntry);
            this.Controls.Add(this.dataGrid1);
            this.Name = "ClimateSensorsForm";
            this.Text = "ClimateSensorsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.groupBoxDataEntry.ResumeLayout(false);
            this.groupBoxDataEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbHumidity;
        private System.Windows.Forms.TextBox tbWindSpeed;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelWindSpeed;
        private System.Windows.Forms.GroupBox groupBoxDataEntry;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelSensorReadings;
    }
}

