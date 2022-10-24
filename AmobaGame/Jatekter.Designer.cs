
namespace AmobaGame
{
    partial class Jatekter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jatekter));
            this.XLabel = new System.Windows.Forms.Label();
            this.OLabel = new System.Windows.Forms.Label();
            this.pirosFeladas = new System.Windows.Forms.Button();
            this.kekFeladas = new System.Windows.Forms.Button();
            this.pirosAmong = new System.Windows.Forms.PictureBox();
            this.kekAmong = new System.Windows.Forms.PictureBox();
            this.pirosX = new System.Windows.Forms.PictureBox();
            this.kekKor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pirosAmong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kekAmong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kekKor)).BeginInit();
            this.SuspendLayout();
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.XLabel.Location = new System.Drawing.Point(-1, 398);
            this.XLabel.MinimumSize = new System.Drawing.Size(180, 30);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(180, 30);
            this.XLabel.TabIndex = 2;
            // 
            // OLabel
            // 
            this.OLabel.AutoSize = true;
            this.OLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OLabel.Location = new System.Drawing.Point(829, 381);
            this.OLabel.MinimumSize = new System.Drawing.Size(180, 30);
            this.OLabel.Name = "OLabel";
            this.OLabel.Size = new System.Drawing.Size(180, 30);
            this.OLabel.TabIndex = 3;
            // 
            // pirosFeladas
            // 
            this.pirosFeladas.Location = new System.Drawing.Point(31, 240);
            this.pirosFeladas.Name = "pirosFeladas";
            this.pirosFeladas.Size = new System.Drawing.Size(148, 45);
            this.pirosFeladas.TabIndex = 6;
            this.pirosFeladas.Text = "Feladás";
            this.pirosFeladas.UseVisualStyleBackColor = true;
            this.pirosFeladas.Click += new System.EventHandler(this.pirosFeladas_Click);
            // 
            // kekFeladas
            // 
            this.kekFeladas.Location = new System.Drawing.Point(834, 240);
            this.kekFeladas.Name = "kekFeladas";
            this.kekFeladas.Size = new System.Drawing.Size(148, 45);
            this.kekFeladas.TabIndex = 7;
            this.kekFeladas.Text = "Feladás";
            this.kekFeladas.UseVisualStyleBackColor = true;
            this.kekFeladas.Click += new System.EventHandler(this.kekFeladas_Click);
            // 
            // pirosAmong
            // 
            this.pirosAmong.Image = ((System.Drawing.Image)(resources.GetObject("pirosAmong.Image")));
            this.pirosAmong.Location = new System.Drawing.Point(4, 12);
            this.pirosAmong.Name = "pirosAmong";
            this.pirosAmong.Size = new System.Drawing.Size(180, 220);
            this.pirosAmong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pirosAmong.TabIndex = 8;
            this.pirosAmong.TabStop = false;
            // 
            // kekAmong
            // 
            this.kekAmong.Image = ((System.Drawing.Image)(resources.GetObject("kekAmong.Image")));
            this.kekAmong.Location = new System.Drawing.Point(829, 12);
            this.kekAmong.Name = "kekAmong";
            this.kekAmong.Size = new System.Drawing.Size(180, 220);
            this.kekAmong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kekAmong.TabIndex = 9;
            this.kekAmong.TabStop = false;
            // 
            // pirosX
            // 
            this.pirosX.Image = ((System.Drawing.Image)(resources.GetObject("pirosX.Image")));
            this.pirosX.Location = new System.Drawing.Point(4, 449);
            this.pirosX.Name = "pirosX";
            this.pirosX.Size = new System.Drawing.Size(175, 180);
            this.pirosX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pirosX.TabIndex = 10;
            this.pirosX.TabStop = false;
            // 
            // kekKor
            // 
            this.kekKor.Image = ((System.Drawing.Image)(resources.GetObject("kekKor.Image")));
            this.kekKor.Location = new System.Drawing.Point(829, 450);
            this.kekKor.Name = "kekKor";
            this.kekKor.Size = new System.Drawing.Size(180, 179);
            this.kekKor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kekKor.TabIndex = 11;
            this.kekKor.TabStop = false;
            // 
            // Jatekter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 641);
            this.Controls.Add(this.kekKor);
            this.Controls.Add(this.pirosX);
            this.Controls.Add(this.kekAmong);
            this.Controls.Add(this.pirosAmong);
            this.Controls.Add(this.kekFeladas);
            this.Controls.Add(this.pirosFeladas);
            this.Controls.Add(this.OLabel);
            this.Controls.Add(this.XLabel);
            this.MaximumSize = new System.Drawing.Size(1025, 680);
            this.MinimumSize = new System.Drawing.Size(1025, 680);
            this.Name = "Jatekter";
            this.Text = "Jatekter";
            ((System.ComponentModel.ISupportInitialize)(this.pirosAmong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kekAmong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pirosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kekKor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label OLabel;
        private System.Windows.Forms.Button pirosFeladas;
        private System.Windows.Forms.Button kekFeladas;
        private System.Windows.Forms.PictureBox pirosAmong;
        private System.Windows.Forms.PictureBox kekAmong;
        private System.Windows.Forms.PictureBox pirosX;
        private System.Windows.Forms.PictureBox kekKor;
    }
}