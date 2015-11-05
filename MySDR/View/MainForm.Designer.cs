namespace MySDR.View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblInput = new System.Windows.Forms.Label();
            this.btnCall = new System.Windows.Forms.Button();
            this.rtbInput = new System.Windows.Forms.RichTextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rtbDelay = new System.Windows.Forms.RichTextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblProcessStatus = new System.Windows.Forms.Label();
            this.tmRun = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInput.Location = new System.Drawing.Point(13, 15);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(50, 25);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "输入";
            // 
            // btnCall
            // 
            this.btnCall.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCall.Location = new System.Drawing.Point(1048, 625);
            this.btnCall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(148, 35);
            this.btnCall.TabIndex = 2;
            this.btnCall.Text = "送货运算";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // rtbInput
            // 
            this.rtbInput.Location = new System.Drawing.Point(16, 42);
            this.rtbInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbInput.Name = "rtbInput";
            this.rtbInput.Size = new System.Drawing.Size(563, 569);
            this.rtbInput.TabIndex = 3;
            this.rtbInput.Text = resources.GetString("rtbInput.Text");
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(593, 42);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(603, 346);
            this.rtbOutput.TabIndex = 4;
            this.rtbOutput.Text = "";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOutput.Location = new System.Drawing.Point(591, 15);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(88, 25);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "输出包裹";
            // 
            // rtbDelay
            // 
            this.rtbDelay.Location = new System.Drawing.Point(593, 425);
            this.rtbDelay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbDelay.Name = "rtbDelay";
            this.rtbDelay.Size = new System.Drawing.Size(603, 186);
            this.rtbDelay.TabIndex = 4;
            this.rtbDelay.Text = "";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDelay.Location = new System.Drawing.Point(591, 398);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(69, 25);
            this.lblDelay.TabIndex = 1;
            this.lblDelay.Text = "延时件";
            // 
            // lblProcessStatus
            // 
            this.lblProcessStatus.AutoSize = true;
            this.lblProcessStatus.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcessStatus.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblProcessStatus.Location = new System.Drawing.Point(13, 630);
            this.lblProcessStatus.Name = "lblProcessStatus";
            this.lblProcessStatus.Size = new System.Drawing.Size(0, 22);
            this.lblProcessStatus.TabIndex = 5;
            // 
            // tmRun
            // 
            this.tmRun.Interval = 50;
            this.tmRun.Tick += new System.EventHandler(this.tmRun_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 673);
            this.Controls.Add(this.lblProcessStatus);
            this.Controls.Add(this.rtbDelay);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.rtbInput);
            this.Controls.Add(this.btnCall);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label lblProcessStatus;
        private System.Windows.Forms.Timer tmRun;
    }
}

