namespace ACARS_Editor_3
{
    partial class ucDegrees
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDegrees = new System.Windows.Forms.TextBox();
            this.lstDegrees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // txtDegrees
            // 
            this.txtDegrees.Location = new System.Drawing.Point(97, 18);
            this.txtDegrees.Name = "txtDegrees";
            this.txtDegrees.Size = new System.Drawing.Size(59, 20);
            this.txtDegrees.TabIndex = 1;
            // 
            // lstDegrees
            // 
            this.lstDegrees.FormattingEnabled = true;
            this.lstDegrees.Items.AddRange(new object[] {
            "Mag.",
            "True"});
            this.lstDegrees.Location = new System.Drawing.Point(162, 8);
            this.lstDegrees.Name = "lstDegrees";
            this.lstDegrees.Size = new System.Drawing.Size(32, 30);
            this.lstDegrees.TabIndex = 2;
            // 
            // ucDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstDegrees);
            this.Controls.Add(this.txtDegrees);
            this.Controls.Add(this.label1);
            this.Name = "ucDegrees";
            this.Size = new System.Drawing.Size(250, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDegrees;
        private System.Windows.Forms.ListBox lstDegrees;
    }
}
