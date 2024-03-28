namespace GMX_Controller
{
    partial class Form1
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
            this.BtnOn = new System.Windows.Forms.Button();
            this.BtnOff = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblDetectDevice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnOn
            // 
            this.BtnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOn.ForeColor = System.Drawing.Color.White;
            this.BtnOn.Location = new System.Drawing.Point(120, 108);
            this.BtnOn.Name = "BtnOn";
            this.BtnOn.Size = new System.Drawing.Size(115, 77);
            this.BtnOn.TabIndex = 0;
            this.BtnOn.Text = "On";
            this.BtnOn.UseVisualStyleBackColor = false;
            // 
            // BtnOff
            // 
            this.BtnOff.BackColor = System.Drawing.Color.Red;
            this.BtnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOff.ForeColor = System.Drawing.Color.White;
            this.BtnOff.Location = new System.Drawing.Point(387, 108);
            this.BtnOff.Name = "BtnOff";
            this.BtnOff.Size = new System.Drawing.Size(115, 77);
            this.BtnOff.TabIndex = 1;
            this.BtnOff.Text = "Off";
            this.BtnOff.UseVisualStyleBackColor = false;
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gray;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(496, 271);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(101, 43);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblDetectDevice
            // 
            this.LblDetectDevice.AutoSize = true;
            this.LblDetectDevice.Location = new System.Drawing.Point(13, 301);
            this.LblDetectDevice.Name = "LblDetectDevice";
            this.LblDetectDevice.Size = new System.Drawing.Size(37, 13);
            this.LblDetectDevice.TabIndex = 3;
            this.LblDetectDevice.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 326);
            this.Controls.Add(this.LblDetectDevice);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnOff);
            this.Controls.Add(this.BtnOn);
            this.Name = "Form1";
            this.Text = "Main Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOn;
        private System.Windows.Forms.Button BtnOff;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblDetectDevice;
    }
}

