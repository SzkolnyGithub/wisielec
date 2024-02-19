
namespace wisielecBadowski4c
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.test = new System.Windows.Forms.Label();
            this.zle = new System.Windows.Forms.Label();
            this.template = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.zdj = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(162, 62);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(26, 15);
            this.test.TabIndex = 0;
            this.test.Text = "test";
            // 
            // zle
            // 
            this.zle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zle.Location = new System.Drawing.Point(12, 9);
            this.zle.Name = "zle";
            this.zle.Size = new System.Drawing.Size(110, 586);
            this.zle.TabIndex = 1;
            // 
            // template
            // 
            this.template.AutoSize = true;
            this.template.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.template.Location = new System.Drawing.Point(196, 266);
            this.template.Name = "template";
            this.template.Size = new System.Drawing.Size(0, 28);
            this.template.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 550);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // zdj
            // 
            this.zdj.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.zdj.ImageSize = new System.Drawing.Size(16, 16);
            this.zdj.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 604);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.template);
            this.Controls.Add(this.zle);
            this.Controls.Add(this.test);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test;
        private System.Windows.Forms.Label zle;
        private System.Windows.Forms.Label template;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList zdj;
    }
}

