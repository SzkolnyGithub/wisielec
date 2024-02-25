
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gra));
            zle = new System.Windows.Forms.Label();
            wisi = new System.Windows.Forms.PictureBox();
            zdj = new System.Windows.Forms.ImageList(components);
            reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)wisi).BeginInit();
            SuspendLayout();
            // 
            // zle
            // 
            zle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            zle.Location = new System.Drawing.Point(12, 9);
            zle.Name = "zle";
            zle.Size = new System.Drawing.Size(110, 586);
            zle.TabIndex = 1;
            // 
            // wisi
            // 
            wisi.Location = new System.Drawing.Point(455, 29);
            wisi.Name = "wisi";
            wisi.Size = new System.Drawing.Size(365, 550);
            wisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            wisi.TabIndex = 3;
            wisi.TabStop = false;
            // 
            // zdj
            // 
            zdj.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            zdj.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("zdj.ImageStream");
            zdj.TransparentColor = System.Drawing.Color.Transparent;
            zdj.Images.SetKeyName(0, "sz1.png");
            zdj.Images.SetKeyName(1, "sz2.png");
            zdj.Images.SetKeyName(2, "sz3.png");
            zdj.Images.SetKeyName(3, "sz4.png");
            zdj.Images.SetKeyName(4, "sz5.png");
            zdj.Images.SetKeyName(5, "sz6.png");
            zdj.Images.SetKeyName(6, "sz7.png");
            zdj.Images.SetKeyName(7, "sz8.png");
            // 
            // reset
            // 
            reset.Location = new System.Drawing.Point(228, 40);
            reset.Name = "reset";
            reset.Size = new System.Drawing.Size(110, 48);
            reset.TabIndex = 4;
            reset.Text = "Restart";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // gra
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(844, 604);
            Controls.Add(reset);
            Controls.Add(wisi);
            Controls.Add(zle);
            Name = "gra";
            Text = "Wisielec";
            KeyDown += Form1_KeyDown;
            MouseMove += Form1_MouseMove;
            ((System.ComponentModel.ISupportInitialize)wisi).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label zle;
        private System.Windows.Forms.PictureBox wisi;
        private System.Windows.Forms.ImageList zdj;
        private System.Windows.Forms.Button reset;
    }
}

