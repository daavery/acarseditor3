namespace ACARS_Editor_3
{
    partial class ucDistance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Distance = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.lstDistance = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(27, 19);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(49, 13);
            this.Distance.TabIndex = 0;
            this.Distance.Text = "Distance";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(82, 16);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(85, 20);
            this.txtDistance.TabIndex = 1;
            // 
            // lstDistance
            // 
            this.lstDistance.FormattingEnabled = true;
            this.lstDistance.Items.AddRange(new object[] {
            "NM",
            "KM"});
            this.lstDistance.Location = new System.Drawing.Point(173, 6);
            this.lstDistance.Name = "lstDistance";
            this.lstDistance.Size = new System.Drawing.Size(32, 30);
            this.lstDistance.TabIndex = 2;
            // 
            // ucDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstDistance);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.Distance);
            this.Name = "ucDistance";
            this.Size = new System.Drawing.Size(250, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.ListBox lstDistance;
    }
}
