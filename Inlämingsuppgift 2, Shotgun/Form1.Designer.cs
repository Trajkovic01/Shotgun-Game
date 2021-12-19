
namespace Inlämingsuppgift_2__Shotgun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonShoot = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonBlock = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAgain = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPlayer = new System.Windows.Forms.TextBox();
            this.textBoxCPU = new System.Windows.Forms.TextBox();
            this.labelShells = new System.Windows.Forms.Label();
            this.labelShellsCPU = new System.Windows.Forms.Label();
            this.buttonShotgun = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShoot
            // 
            this.buttonShoot.Location = new System.Drawing.Point(12, 78);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(102, 34);
            this.buttonShoot.TabIndex = 0;
            this.buttonShoot.Text = "Shoot";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(12, 140);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(102, 33);
            this.buttonReload.TabIndex = 1;
            this.buttonReload.Text = "Reload";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonBlock
            // 
            this.buttonBlock.Location = new System.Drawing.Point(12, 206);
            this.buttonBlock.Name = "buttonBlock";
            this.buttonBlock.Size = new System.Drawing.Size(102, 32);
            this.buttonBlock.TabIndex = 2;
            this.buttonBlock.Text = "Block";
            this.buttonBlock.UseVisualStyleBackColor = true;
            this.buttonBlock.Click += new System.EventHandler(this.buttonBlock_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(213, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(465, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inlämingsuppgift_2__Shotgun.Properties.Resources.cpu_processor_vector_icon_isolated_white_background_149262951;
            this.pictureBox2.Location = new System.Drawing.Point(560, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(228, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAgain
            // 
            this.buttonAgain.Location = new System.Drawing.Point(12, 385);
            this.buttonAgain.Name = "buttonAgain";
            this.buttonAgain.Size = new System.Drawing.Size(102, 33);
            this.buttonAgain.TabIndex = 6;
            this.buttonAgain.Text = "Play again";
            this.buttonAgain.UseVisualStyleBackColor = true;
            this.buttonAgain.Click += new System.EventHandler(this.buttonAgain_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Shells:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Shells:";
            // 
            // textBoxPlayer
            // 
            this.textBoxPlayer.Location = new System.Drawing.Point(213, 244);
            this.textBoxPlayer.Name = "textBoxPlayer";
            this.textBoxPlayer.Size = new System.Drawing.Size(207, 23);
            this.textBoxPlayer.TabIndex = 11;
            // 
            // textBoxCPU
            // 
            this.textBoxCPU.Location = new System.Drawing.Point(560, 244);
            this.textBoxCPU.Name = "textBoxCPU";
            this.textBoxCPU.Size = new System.Drawing.Size(228, 23);
            this.textBoxCPU.TabIndex = 12;
            // 
            // labelShells
            // 
            this.labelShells.AutoSize = true;
            this.labelShells.Location = new System.Drawing.Point(259, 49);
            this.labelShells.Name = "labelShells";
            this.labelShells.Size = new System.Drawing.Size(13, 15);
            this.labelShells.TabIndex = 13;
            this.labelShells.Text = "0";
            // 
            // labelShellsCPU
            // 
            this.labelShellsCPU.AutoSize = true;
            this.labelShellsCPU.Location = new System.Drawing.Point(607, 48);
            this.labelShellsCPU.Name = "labelShellsCPU";
            this.labelShellsCPU.Size = new System.Drawing.Size(13, 15);
            this.labelShellsCPU.TabIndex = 14;
            this.labelShellsCPU.Text = "0";
            // 
            // buttonShotgun
            // 
            this.buttonShotgun.Location = new System.Drawing.Point(12, 270);
            this.buttonShotgun.Name = "buttonShotgun";
            this.buttonShotgun.Size = new System.Drawing.Size(102, 32);
            this.buttonShotgun.TabIndex = 15;
            this.buttonShotgun.Text = "SHOTGUN";
            this.buttonShotgun.UseVisualStyleBackColor = true;
            this.buttonShotgun.Click += new System.EventHandler(this.buttonShotgun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShotgun);
            this.Controls.Add(this.labelShellsCPU);
            this.Controls.Add(this.labelShells);
            this.Controls.Add(this.textBoxCPU);
            this.Controls.Add(this.textBoxPlayer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAgain);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonBlock);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonShoot);
            this.Name = "Form1";
            this.Text = "Shotgun game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button buttonShoot;
        public System.Windows.Forms.Button buttonReload;
        public System.Windows.Forms.Button buttonBlock;
        public System.Windows.Forms.Button buttonAgain;
        public System.Windows.Forms.TextBox textBoxPlayer;
        public System.Windows.Forms.TextBox textBoxCPU;
        public System.Windows.Forms.Label labelShells;
        public System.Windows.Forms.Label labelShellsCPU;
        public System.Windows.Forms.Button buttonShotgun;
    }
}

