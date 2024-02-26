
namespace wisielecBadowski4c
{
    partial class gra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gra));
            this.zle = new System.Windows.Forms.Label();
            this.wisi = new System.Windows.Forms.PictureBox();
            this.zdj = new System.Windows.Forms.ImageList(this.components);
            this.reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.wisi)).BeginInit();
            this.SuspendLayout();
            // 
            // zle
            // 
            this.zle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.zle.Location = new System.Drawing.Point(12, 9);
            this.zle.Name = "zle";
            this.zle.Size = new System.Drawing.Size(110, 586);
            this.zle.TabIndex = 1;
            // 
            // wisi
            // 
            this.wisi.Location = new System.Drawing.Point(455, 29);
            this.wisi.Name = "wisi";
            this.wisi.Size = new System.Drawing.Size(365, 550);
            this.wisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.wisi.TabIndex = 3;
            this.wisi.TabStop = false;
            // 
            // zdj
            // 
            this.zdj.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.zdj.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("zdj.ImageStream")));
            this.zdj.TransparentColor = System.Drawing.Color.Transparent;
            this.zdj.Images.SetKeyName(0, "sz1.png");
            this.zdj.Images.SetKeyName(1, "sz2.png");
            this.zdj.Images.SetKeyName(2, "sz3.png");
            this.zdj.Images.SetKeyName(3, "sz4.png");
            this.zdj.Images.SetKeyName(4, "sz5.png");
            this.zdj.Images.SetKeyName(5, "sz6.png");
            this.zdj.Images.SetKeyName(6, "sz7.png");
            this.zdj.Images.SetKeyName(7, "sz8.png");
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(228, 40);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(110, 48);
            this.reset.TabIndex = 4;
            this.reset.Text = "Restart";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click_1);
            // 
            // gra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 604);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.wisi);
            this.Controls.Add(this.zle);
            this.Name = "gra";
            this.Text = "Wisielec";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label zle;
        private System.Windows.Forms.PictureBox wisi;
        private System.Windows.Forms.ImageList zdj;
        private System.Windows.Forms.Button reset;
    }
}

