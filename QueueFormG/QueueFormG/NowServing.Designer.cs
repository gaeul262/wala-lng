namespace QueueFormG
{
    partial class NowServing
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
            this.label1 = new System.Windows.Forms.Label();
            this.NowServingText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Now Serving";
            // 
            // NowServingText
            // 
            this.NowServingText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NowServingText.AutoSize = true;
            this.NowServingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowServingText.Location = new System.Drawing.Point(25, 59);
            this.NowServingText.Name = "NowServingText";
            this.NowServingText.Size = new System.Drawing.Size(242, 55);
            this.NowServingText.TabIndex = 1;
            this.NowServingText.Text = "P - 10001";
            this.NowServingText.Click += new System.EventHandler(this.NowServingText_Click);
            // 
            // NowServing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 147);
            this.Controls.Add(this.NowServingText);
            this.Controls.Add(this.label1);
            this.Name = "NowServing";
            this.Text = "NowServing";
            this.Load += new System.EventHandler(this.NowServing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NowServingText;
    }
}