namespace AlarmZoneApp
{
    partial class ZoneForm
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
            this.txtAlarmRate = new System.Windows.Forms.TextBox();
            this.txtPercentOutside = new System.Windows.Forms.TextBox();
            this.btnDetect = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.grpInputs = new System.Windows.Forms.GroupBox();
            this.lblAlarmRate = new System.Windows.Forms.Label();
            this.lblPercentOutside = new System.Windows.Forms.Label();
            this.lblResult0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAlarmRate
            // 
            this.txtAlarmRate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlarmRate.Location = new System.Drawing.Point(360, 80);
            this.txtAlarmRate.Name = "txtAlarmRate";
            this.txtAlarmRate.Size = new System.Drawing.Size(165, 43);
            this.txtAlarmRate.TabIndex = 0;
            // 
            // txtPercentOutside
            // 
            this.txtPercentOutside.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercentOutside.Location = new System.Drawing.Point(360, 160);
            this.txtPercentOutside.Name = "txtPercentOutside";
            this.txtPercentOutside.Size = new System.Drawing.Size(165, 43);
            this.txtPercentOutside.TabIndex = 1;
            // 
            // btnDetect
            // 
            this.btnDetect.BackColor = System.Drawing.Color.Blue;
            this.btnDetect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetect.ForeColor = System.Drawing.Color.White;
            this.btnDetect.Location = new System.Drawing.Point(60, 310);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(250, 60);
            this.btnDetect.TabIndex = 2;
            this.btnDetect.Text = "Detect Zone";
            this.btnDetect.UseVisualStyleBackColor = false;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Black;
            this.lblResult.Location = new System.Drawing.Point(402, 440);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(101, 45);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "None";
            // 
            // grpInputs
            // 
            this.grpInputs.Controls.Add(this.label1);
            this.grpInputs.Controls.Add(this.txtAlarmRate);
            this.grpInputs.Controls.Add(this.lblAlarmRate);
            this.grpInputs.Controls.Add(this.lblPercentOutside);
            this.grpInputs.Controls.Add(this.txtPercentOutside);
            this.grpInputs.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInputs.Location = new System.Drawing.Point(50, 40);
            this.grpInputs.Name = "grpInputs";
            this.grpInputs.Size = new System.Drawing.Size(600, 250);
            this.grpInputs.TabIndex = 4;
            this.grpInputs.TabStop = false;
            this.grpInputs.Text = "Enter Values To Detect";
            // 
            // lblAlarmRate
            // 
            this.lblAlarmRate.AutoSize = true;
            this.lblAlarmRate.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmRate.Location = new System.Drawing.Point(10, 80);
            this.lblAlarmRate.Name = "lblAlarmRate";
            this.lblAlarmRate.Size = new System.Drawing.Size(256, 37);
            this.lblAlarmRate.TabIndex = 5;
            this.lblAlarmRate.Text = "Average Alarm Rate:";
            // 
            // lblPercentOutside
            // 
            this.lblPercentOutside.AutoSize = true;
            this.lblPercentOutside.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentOutside.Location = new System.Drawing.Point(10, 159);
            this.lblPercentOutside.Name = "lblPercentOutside";
            this.lblPercentOutside.Size = new System.Drawing.Size(333, 37);
            this.lblPercentOutside.TabIndex = 0;
            this.lblPercentOutside.Text = "Percentage Outside Target:";
            // 
            // lblResult0
            // 
            this.lblResult0.AutoSize = true;
            this.lblResult0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult0.ForeColor = System.Drawing.Color.Black;
            this.lblResult0.Location = new System.Drawing.Point(60, 440);
            this.lblResult0.Name = "lblResult0";
            this.lblResult0.Size = new System.Drawing.Size(335, 45);
            this.lblResult0.TabIndex = 5;
            this.lblResult0.Text = "The detected zone is:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(531, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "%";
            // 
            // ZoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(674, 529);
            this.Controls.Add(this.lblResult0);
            this.Controls.Add(this.grpInputs);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnDetect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ZoneForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm Zone Detection";
            this.grpInputs.ResumeLayout(false);
            this.grpInputs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlarmRate;
        private System.Windows.Forms.TextBox txtPercentOutside;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox grpInputs;
        private System.Windows.Forms.Label lblPercentOutside;
        private System.Windows.Forms.Label lblAlarmRate;
        private System.Windows.Forms.Label lblResult0;
        private System.Windows.Forms.Label label1;
    }
}

