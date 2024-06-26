﻿namespace GMX_Controller
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnOn = new System.Windows.Forms.Button();
            this.BtnOff = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblDetectDevice = new System.Windows.Forms.Label();
            this.Big_Mama = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // BtnOn
            // 
            this.BtnOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOn.ForeColor = System.Drawing.Color.White;
            this.BtnOn.Location = new System.Drawing.Point(43, 85);
            this.BtnOn.Name = "BtnOn";
            this.BtnOn.Size = new System.Drawing.Size(115, 77);
            this.BtnOn.TabIndex = 0;
            this.BtnOn.Text = "On";
            this.BtnOn.UseVisualStyleBackColor = false;
            this.BtnOn.Click += new System.EventHandler(this.BtnOn_Click);
            // 
            // BtnOff
            // 
            this.BtnOff.BackColor = System.Drawing.Color.Red;
            this.BtnOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOff.ForeColor = System.Drawing.Color.White;
            this.BtnOff.Location = new System.Drawing.Point(238, 85);
            this.BtnOff.Name = "BtnOff";
            this.BtnOff.Size = new System.Drawing.Size(115, 77);
            this.BtnOff.TabIndex = 1;
            this.BtnOff.Text = "Off";
            this.BtnOff.UseVisualStyleBackColor = false;
            this.BtnOff.Click += new System.EventHandler(this.BtnOff_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Gray;
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.White;
            this.BtnExit.Location = new System.Drawing.Point(252, 271);
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
            // Big_Mama
            // 
            this.Big_Mama.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Big_Mama.BalloonTipText = "Big Mama";
            this.Big_Mama.BalloonTipTitle = "OpenDMX Controller";
            this.Big_Mama.Icon = ((System.Drawing.Icon)(resources.GetObject("Big_Mama.Icon")));
            this.Big_Mama.Text = "Big Mama";
            this.Big_Mama.Visible = true;
            this.Big_Mama.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Big_Mama_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 326);
            this.Controls.Add(this.LblDetectDevice);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnOff);
            this.Controls.Add(this.BtnOn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Big Mama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOn;
        private System.Windows.Forms.Button BtnOff;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblDetectDevice;
        private System.Windows.Forms.NotifyIcon Big_Mama;
    }
}

