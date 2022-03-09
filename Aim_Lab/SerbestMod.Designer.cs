
namespace Aim_Lab
{
    partial class SerbestMod
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SerbestMod));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCikisYap = new System.Windows.Forms.PictureBox();
            this.btnMenuyeDon = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.lblZaman = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSkor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.target = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikisYap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCikisYap
            // 
            this.btnCikisYap.BackColor = System.Drawing.Color.Transparent;
            this.btnCikisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikisYap.Image = ((System.Drawing.Image)(resources.GetObject("btnCikisYap.Image")));
            this.btnCikisYap.Location = new System.Drawing.Point(1011, 1);
            this.btnCikisYap.Name = "btnCikisYap";
            this.btnCikisYap.Size = new System.Drawing.Size(35, 35);
            this.btnCikisYap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCikisYap.TabIndex = 23;
            this.btnCikisYap.TabStop = false;
            this.btnCikisYap.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // btnMenuyeDon
            // 
            this.btnMenuyeDon.BackColor = System.Drawing.Color.Tomato;
            this.btnMenuyeDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuyeDon.FlatAppearance.BorderSize = 0;
            this.btnMenuyeDon.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMenuyeDon.ForeColor = System.Drawing.Color.White;
            this.btnMenuyeDon.Location = new System.Drawing.Point(389, 297);
            this.btnMenuyeDon.Name = "btnMenuyeDon";
            this.btnMenuyeDon.Size = new System.Drawing.Size(255, 75);
            this.btnMenuyeDon.TabIndex = 22;
            this.btnMenuyeDon.Text = "MENÜYE DÖN";
            this.btnMenuyeDon.UseVisualStyleBackColor = false;
            this.btnMenuyeDon.Click += new System.EventHandler(this.btnMenuyeDon_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Lime;
            this.btnBasla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBasla.FlatAppearance.BorderSize = 0;
            this.btnBasla.Font = new System.Drawing.Font("Georgia", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.ForeColor = System.Drawing.Color.White;
            this.btnBasla.Location = new System.Drawing.Point(389, 186);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(255, 105);
            this.btnBasla.TabIndex = 21;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.BackColor = System.Drawing.SystemColors.Info;
            this.lblZaman.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblZaman.Location = new System.Drawing.Point(124, 9);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(31, 31);
            this.lblZaman.TabIndex = 20;
            this.lblZaman.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Zaman:";
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.BackColor = System.Drawing.SystemColors.Info;
            this.lblSkor.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(299, 9);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(31, 31);
            this.lblSkor.TabIndex = 18;
            this.lblSkor.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Skor:";
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.Color.Transparent;
            this.target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.target.Cursor = System.Windows.Forms.Cursors.Hand;
            this.target.Image = ((System.Drawing.Image)(resources.GetObject("target.Image")));
            this.target.Location = new System.Drawing.Point(257, 171);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(85, 85);
            this.target.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.target.TabIndex = 16;
            this.target.TabStop = false;
            this.target.Click += new System.EventHandler(this.target_Click);
            // 
            // SerbestMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1047, 588);
            this.Controls.Add(this.btnCikisYap);
            this.Controls.Add(this.btnMenuyeDon);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.target);
            this.Font = new System.Drawing.Font("Georgia", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "SerbestMod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SerbestMod";
            this.Load += new System.EventHandler(this.SerbestMod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCikisYap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.target)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox btnCikisYap;
        private System.Windows.Forms.Button btnMenuyeDon;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox target;
    }
}