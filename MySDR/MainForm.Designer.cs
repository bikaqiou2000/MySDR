namespace MySDR
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInput = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtbDelay = new System.Windows.Forms.RichTextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblParcelSum = new System.Windows.Forms.Label();
            this.lbDelaySum = new System.Windows.Forms.Label();
            this.lblProcessStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(10, 18);
            this.lblInput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(29, 12);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "输入";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(324, 3);
            this.btnCall.Margin = new System.Windows.Forms.Padding(2);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(111, 28);
            this.btnCall.TabIndex = 2;
            this.btnCall.Text = "送货计划";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(12, 33);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(2);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(423, 473);
            this.rtbInput.TabIndex = 3;
            this.rtbInput.Text = resources.GetString("rtbInput.Text");
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(445, 33);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(453, 203);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(443, 19);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(53, 12);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "输出包裹";
            // 
            // rtbDelay
            // 
            this.rtbDelay.Location = new System.Drawing.Point(445, 280);
            this.rtbDelay.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDelay.Name = "rtbDelay";
            this.rtbDelay.Size = new System.Drawing.Size(453, 212);
            this.rtbDelay.TabIndex = 4;
            this.rtbDelay.Text = "";
            // 
            // lblDelay
            // 
            this.lblDelay.Location = new System.Drawing.Point(443, 266);
            this.lblDelay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(364, 12);
            this.lblDelay.TabIndex = 1;
            this.lblDelay.Text = "延期包裹";
            // 
            // lblParcelSum
            // 
            this.lblParcelSum.Location = new System.Drawing.Point(443, 238);
            this.lblParcelSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParcelSum.Name = "lblParcelSum";
            this.lblParcelSum.Size = new System.Drawing.Size(368, 12);
            this.lblParcelSum.TabIndex = 1;
            this.lblParcelSum.Text = "合计";
            // 
            // lbDelaySum
            // 
            this.lbDelaySum.Location = new System.Drawing.Point(443, 494);
            this.lbDelaySum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDelaySum.Name = "lbDelaySum";
            this.lbDelaySum.Size = new System.Drawing.Size(368, 12);
            this.lbDelaySum.TabIndex = 1;
            this.lbDelaySum.Text = "合计";
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.Location = new System.Drawing.Point(12, 510);
            this.lblProcessStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Size = new System.Drawing.Size(886, 18);
            this.lblProcessStatus.TabIndex = 5;
            this.lblProcessStatus.Text = "状态";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 538);
            this.Controls.Add(this.lblProcessStatus);
            this.Controls.Add(this.rtbDelay);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lbDelaySum);
            this.Controls.Add(this.lblParcelSum);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "包裹安排计划";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Button btnCall;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RichTextBox rtbDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblParcelSum;
        private System.Windows.Forms.Label lbDelaySum;
        private System.Windows.Forms.Label lblProcessStatus;
    }
}

