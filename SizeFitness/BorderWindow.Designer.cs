
namespace SizeFitness
{
    partial class BorderWindow
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
            this.Label_Infomation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label_Infomation
            // 
            this.Label_Infomation.AutoSize = true;
            this.Label_Infomation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label_Infomation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label_Infomation.ForeColor = System.Drawing.Color.White;
            this.Label_Infomation.Location = new System.Drawing.Point(6, 6);
            this.Label_Infomation.Name = "Label_Infomation";
            this.Label_Infomation.Size = new System.Drawing.Size(2, 17);
            this.Label_Infomation.TabIndex = 0;
            // 
            // BorderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Label_Infomation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorderWindow";
            this.ShowInTaskbar = false;
            this.Text = "BorderWindow";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.BorderWindow_Paint);
            this.Resize += new System.EventHandler(this.BorderWindow_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Label_Infomation;
    }
}