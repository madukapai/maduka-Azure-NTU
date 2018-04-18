namespace IoTDevice
{
    partial class frmMain
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
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.txtDeviceId = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Location = new System.Drawing.Point(12, 19);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(47, 12);
            this.lblDeviceId.TabIndex = 0;
            this.lblDeviceId.Text = "DeviceId";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(12, 55);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(64, 12);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(12, 96);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(49, 12);
            this.lblHumidity.TabIndex = 2;
            this.lblHumidity.Text = "Humidity";
            // 
            // txtDeviceId
            // 
            this.txtDeviceId.Location = new System.Drawing.Point(82, 12);
            this.txtDeviceId.Name = "txtDeviceId";
            this.txtDeviceId.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceId.TabIndex = 3;
            // 
            // txtTemperature
            // 
            this.txtTemperature.Location = new System.Drawing.Point(82, 52);
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(100, 22);
            this.txtTemperature.TabIndex = 4;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(82, 93);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(100, 22);
            this.txtHumidity.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(14, 131);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(168, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 174);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtDeviceId);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblDeviceId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "IoT Device";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.TextBox txtDeviceId;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Button btnSend;
    }
}