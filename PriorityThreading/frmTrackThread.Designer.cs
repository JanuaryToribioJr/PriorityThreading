namespace PriorityThreading
{
    partial class frmTrackThread
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrackThread));
            this.ThreadLabel = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ThreadLabel
            // 
            this.ThreadLabel.AutoSize = true;
            this.ThreadLabel.BackColor = System.Drawing.Color.SlateBlue;
            this.ThreadLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreadLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ThreadLabel.Location = new System.Drawing.Point(38, 51);
            this.ThreadLabel.Name = "ThreadLabel";
            this.ThreadLabel.Size = new System.Drawing.Size(250, 27);
            this.ThreadLabel.TabIndex = 0;
            this.ThreadLabel.Text = "- Thread Starts -";
            // 
            // runBtn
            // 
            this.runBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("runBtn.BackgroundImage")));
            this.runBtn.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.runBtn.Location = new System.Drawing.Point(117, 108);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(91, 28);
            this.runBtn.TabIndex = 1;
            this.runBtn.Text = "RUN";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // frmTrackThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 184);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.ThreadLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmTrackThread";
            this.Text = "frmTrackThread";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThreadLabel;
        private System.Windows.Forms.Button runBtn;
    }
}

