namespace Task2_Code_LL_000013680_Baines_C
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnWeather = new System.Windows.Forms.Button();
            this.txtWeather = new System.Windows.Forms.TextBox();
            this.btnTemperature = new System.Windows.Forms.Button();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtForecastLocation = new System.Windows.Forms.TextBox();
            this.txtAirQuality = new System.Windows.Forms.TextBox();
            this.btnAirQuality = new System.Windows.Forms.Button();
            this.txtDisplayTemperature = new System.Windows.Forms.TextBox();
            this.txtDisplayAirQuality = new System.Windows.Forms.TextBox();
            this.temperatureIcon = new System.Windows.Forms.PictureBox();
            this.airQualityIcon = new System.Windows.Forms.PictureBox();
            this.settingsIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtDisplayTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weather Forecast";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(124, 698);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ShortcutsEnabled = false;
            this.textBox1.Size = new System.Drawing.Size(193, 14);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = "Copyright © Health Advice Group";
            // 
            // btnWeather
            // 
            this.btnWeather.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeather.Location = new System.Drawing.Point(166, 262);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(102, 23);
            this.btnWeather.TabIndex = 31;
            this.btnWeather.Text = "Weather Type";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeather
            // 
            this.txtWeather.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeather.Location = new System.Drawing.Point(71, 291);
            this.txtWeather.Multiline = true;
            this.txtWeather.Name = "txtWeather";
            this.txtWeather.Size = new System.Drawing.Size(303, 20);
            this.txtWeather.TabIndex = 34;
            // 
            // btnTemperature
            // 
            this.btnTemperature.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemperature.Location = new System.Drawing.Point(166, 338);
            this.btnTemperature.Name = "btnTemperature";
            this.btnTemperature.Size = new System.Drawing.Size(102, 23);
            this.btnTemperature.TabIndex = 35;
            this.btnTemperature.Text = "Temperature";
            this.btnTemperature.UseVisualStyleBackColor = true;
            this.btnTemperature.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperature.Location = new System.Drawing.Point(70, 367);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(304, 20);
            this.txtTemperature.TabIndex = 36;
            // 
            // txtForecastLocation
            // 
            this.txtForecastLocation.BackColor = System.Drawing.SystemColors.Menu;
            this.txtForecastLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtForecastLocation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForecastLocation.Location = new System.Drawing.Point(130, 105);
            this.txtForecastLocation.Multiline = true;
            this.txtForecastLocation.Name = "txtForecastLocation";
            this.txtForecastLocation.Size = new System.Drawing.Size(182, 20);
            this.txtForecastLocation.TabIndex = 37;
            this.txtForecastLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAirQuality
            // 
            this.txtAirQuality.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirQuality.Location = new System.Drawing.Point(70, 434);
            this.txtAirQuality.Multiline = true;
            this.txtAirQuality.Name = "txtAirQuality";
            this.txtAirQuality.Size = new System.Drawing.Size(304, 21);
            this.txtAirQuality.TabIndex = 39;
            // 
            // btnAirQuality
            // 
            this.btnAirQuality.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirQuality.Location = new System.Drawing.Point(166, 405);
            this.btnAirQuality.Name = "btnAirQuality";
            this.btnAirQuality.Size = new System.Drawing.Size(102, 23);
            this.btnAirQuality.TabIndex = 38;
            this.btnAirQuality.Text = "Air Quality";
            this.btnAirQuality.UseVisualStyleBackColor = true;
            this.btnAirQuality.Click += new System.EventHandler(this.btnAirQuality_Click);
            // 
            // txtDisplayTemperature
            // 
            this.txtDisplayTemperature.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDisplayTemperature.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayTemperature.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayTemperature.Location = new System.Drawing.Point(70, 131);
            this.txtDisplayTemperature.Multiline = true;
            this.txtDisplayTemperature.Name = "txtDisplayTemperature";
            this.txtDisplayTemperature.Size = new System.Drawing.Size(301, 47);
            this.txtDisplayTemperature.TabIndex = 40;
            this.txtDisplayTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisplayAirQuality
            // 
            this.txtDisplayAirQuality.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDisplayAirQuality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayAirQuality.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayAirQuality.ForeColor = System.Drawing.Color.Black;
            this.txtDisplayAirQuality.Location = new System.Drawing.Point(297, 175);
            this.txtDisplayAirQuality.Multiline = true;
            this.txtDisplayAirQuality.Name = "txtDisplayAirQuality";
            this.txtDisplayAirQuality.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayAirQuality.TabIndex = 42;
            this.txtDisplayAirQuality.Text = ":";
            this.txtDisplayAirQuality.TextChanged += new System.EventHandler(this.txtDisplayAirQuality_TextChanged);
            // 
            // temperatureIcon
            // 
            this.temperatureIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temperatureIcon.Image = global::Task2_Code_LL_000013680_Baines_C.Properties.Resources.temperature_icon;
            this.temperatureIcon.Location = new System.Drawing.Point(71, 164);
            this.temperatureIcon.Name = "temperatureIcon";
            this.temperatureIcon.Size = new System.Drawing.Size(41, 40);
            this.temperatureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.temperatureIcon.TabIndex = 43;
            this.temperatureIcon.TabStop = false;
            // 
            // airQualityIcon
            // 
            this.airQualityIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airQualityIcon.Image = global::Task2_Code_LL_000013680_Baines_C.Properties.Resources.air_quality_index_icon;
            this.airQualityIcon.Location = new System.Drawing.Point(250, 164);
            this.airQualityIcon.Name = "airQualityIcon";
            this.airQualityIcon.Size = new System.Drawing.Size(41, 40);
            this.airQualityIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.airQualityIcon.TabIndex = 41;
            this.airQualityIcon.TabStop = false;
            // 
            // settingsIcon
            // 
            this.settingsIcon.BackColor = System.Drawing.Color.Transparent;
            this.settingsIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settingsIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsIcon.Image = global::Task2_Code_LL_000013680_Baines_C.Properties.Resources.black_settings_icon_2;
            this.settingsIcon.Location = new System.Drawing.Point(393, 12);
            this.settingsIcon.Name = "settingsIcon";
            this.settingsIcon.Size = new System.Drawing.Size(37, 34);
            this.settingsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.settingsIcon.TabIndex = 33;
            this.settingsIcon.TabStop = false;
            this.settingsIcon.Click += new System.EventHandler(this.settingsIcon_Click);
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.White;
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.homeIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homeIcon.Image = global::Task2_Code_LL_000013680_Baines_C.Properties.Resources.home_icon;
            this.homeIcon.Location = new System.Drawing.Point(196, 658);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(37, 34);
            this.homeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.homeIcon.TabIndex = 32;
            this.homeIcon.TabStop = false;
            this.homeIcon.Click += new System.EventHandler(this.homeIcon_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 645);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(448, 73);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // txtDisplayTemp
            // 
            this.txtDisplayTemp.BackColor = System.Drawing.SystemColors.Menu;
            this.txtDisplayTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplayTemp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayTemp.ForeColor = System.Drawing.Color.Black;
            this.txtDisplayTemp.Location = new System.Drawing.Point(118, 175);
            this.txtDisplayTemp.Multiline = true;
            this.txtDisplayTemp.Name = "txtDisplayTemp";
            this.txtDisplayTemp.Size = new System.Drawing.Size(100, 20);
            this.txtDisplayTemp.TabIndex = 44;
            this.txtDisplayTemp.Text = ":";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 717);
            this.Controls.Add(this.txtDisplayTemp);
            this.Controls.Add(this.temperatureIcon);
            this.Controls.Add(this.txtDisplayAirQuality);
            this.Controls.Add(this.airQualityIcon);
            this.Controls.Add(this.txtDisplayTemperature);
            this.Controls.Add(this.txtAirQuality);
            this.Controls.Add(this.btnAirQuality);
            this.Controls.Add(this.txtForecastLocation);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.btnTemperature);
            this.Controls.Add(this.txtWeather);
            this.Controls.Add(this.settingsIcon);
            this.Controls.Add(this.homeIcon);
            this.Controls.Add(this.btnWeather);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Weather Forecast Page";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airQualityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.PictureBox settingsIcon;
        private System.Windows.Forms.TextBox txtWeather;
        private System.Windows.Forms.Button btnTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtForecastLocation;
        private System.Windows.Forms.TextBox txtAirQuality;
        private System.Windows.Forms.Button btnAirQuality;
        private System.Windows.Forms.TextBox txtDisplayTemperature;
        private System.Windows.Forms.PictureBox airQualityIcon;
        private System.Windows.Forms.TextBox txtDisplayAirQuality;
        private System.Windows.Forms.PictureBox temperatureIcon;
        private System.Windows.Forms.TextBox txtDisplayTemp;
    }
}