namespace AutoTyper
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
            this.tbTypedText = new System.Windows.Forms.TextBox();
            this.bType = new System.Windows.Forms.Button();
            this.lbTypedText = new System.Windows.Forms.Label();
            this.lbInitialDelay = new System.Windows.Forms.Label();
            this.nudInitialDelay = new System.Windows.Forms.NumericUpDown();
            this.nudTypingDelay = new System.Windows.Forms.NumericUpDown();
            this.lbTypingDelay = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypingDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTypedText
            // 
            this.tbTypedText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTypedText.Location = new System.Drawing.Point(33, 61);
            this.tbTypedText.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbTypedText.Name = "tbTypedText";
            this.tbTypedText.Size = new System.Drawing.Size(404, 25);
            this.tbTypedText.TabIndex = 0;
            // 
            // bType
            // 
            this.bType.Location = new System.Drawing.Point(165, 226);
            this.bType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bType.Name = "bType";
            this.bType.Size = new System.Drawing.Size(158, 33);
            this.bType.TabIndex = 1;
            this.bType.Text = "Type";
            this.bType.UseVisualStyleBackColor = true;
            this.bType.Click += new System.EventHandler(this.bType_Click);
            // 
            // lbTypedText
            // 
            this.lbTypedText.AutoSize = true;
            this.lbTypedText.Location = new System.Drawing.Point(29, 24);
            this.lbTypedText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTypedText.Name = "lbTypedText";
            this.lbTypedText.Size = new System.Drawing.Size(79, 19);
            this.lbTypedText.TabIndex = 2;
            this.lbTypedText.Text = "Typed Text:";
            // 
            // lbInitialDelay
            // 
            this.lbInitialDelay.AutoSize = true;
            this.lbInitialDelay.Location = new System.Drawing.Point(32, 123);
            this.lbInitialDelay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbInitialDelay.Name = "lbInitialDelay";
            this.lbInitialDelay.Size = new System.Drawing.Size(107, 19);
            this.lbInitialDelay.TabIndex = 3;
            this.lbInitialDelay.Text = "Initial Delay (s):";
            // 
            // nudInitialDelay
            // 
            this.nudInitialDelay.Location = new System.Drawing.Point(37, 159);
            this.nudInitialDelay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudInitialDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudInitialDelay.Name = "nudInitialDelay";
            this.nudInitialDelay.Size = new System.Drawing.Size(160, 25);
            this.nudInitialDelay.TabIndex = 4;
            this.nudInitialDelay.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudTypingDelay
            // 
            this.nudTypingDelay.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTypingDelay.Location = new System.Drawing.Point(277, 159);
            this.nudTypingDelay.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudTypingDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTypingDelay.Name = "nudTypingDelay";
            this.nudTypingDelay.Size = new System.Drawing.Size(160, 25);
            this.nudTypingDelay.TabIndex = 6;
            this.nudTypingDelay.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbTypingDelay
            // 
            this.lbTypingDelay.AutoSize = true;
            this.lbTypingDelay.Location = new System.Drawing.Point(273, 123);
            this.lbTypingDelay.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbTypingDelay.Name = "lbTypingDelay";
            this.lbTypingDelay.Size = new System.Drawing.Size(125, 19);
            this.lbTypingDelay.TabIndex = 5;
            this.lbTypingDelay.Text = "Typing Delay (ms):";
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.ForeColor = System.Drawing.Color.Red;
            this.lbInfo.Location = new System.Drawing.Point(33, 90);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(52, 19);
            this.lbInfo.TabIndex = 7;
            this.lbInfo.Text = "[INFO]";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(473, 297);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.nudTypingDelay);
            this.Controls.Add(this.lbTypingDelay);
            this.Controls.Add(this.nudInitialDelay);
            this.Controls.Add(this.lbInitialDelay);
            this.Controls.Add(this.lbTypedText);
            this.Controls.Add(this.bType);
            this.Controls.Add(this.tbTypedText);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MinimumSize = new System.Drawing.Size(489, 336);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(13);
            this.Text = "Auto Typer";
            ((System.ComponentModel.ISupportInitialize)(this.nudInitialDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTypingDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTypedText;
        private System.Windows.Forms.Button bType;
        private System.Windows.Forms.Label lbTypedText;
        private System.Windows.Forms.Label lbInitialDelay;
        private System.Windows.Forms.NumericUpDown nudInitialDelay;
        private System.Windows.Forms.NumericUpDown nudTypingDelay;
        private System.Windows.Forms.Label lbTypingDelay;
        private System.Windows.Forms.Label lbInfo;
    }
}

