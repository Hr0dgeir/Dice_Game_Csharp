namespace Dice_Roller
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Player_dice1 = new System.Windows.Forms.PictureBox();
            this.Player_dice2 = new System.Windows.Forms.PictureBox();
            this.Player_dice3 = new System.Windows.Forms.PictureBox();
            this.Player_dice4 = new System.Windows.Forms.PictureBox();
            this.Player_dice5 = new System.Windows.Forms.PictureBox();
            this.Player_dice6 = new System.Windows.Forms.PictureBox();
            this.Ai_dice6 = new System.Windows.Forms.PictureBox();
            this.Ai_dice5 = new System.Windows.Forms.PictureBox();
            this.Ai_dice4 = new System.Windows.Forms.PictureBox();
            this.Ai_dice3 = new System.Windows.Forms.PictureBox();
            this.Ai_dice2 = new System.Windows.Forms.PictureBox();
            this.Ai_dice1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.win = new System.Windows.Forms.Label();
            this.lap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to Dice game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(74, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Press \"Enter\" To start game";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(89, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Press \"Q\" To start game";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player_dice1
            // 
            this.Player_dice1.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice1.Image")));
            this.Player_dice1.Location = new System.Drawing.Point(12, 306);
            this.Player_dice1.Name = "Player_dice1";
            this.Player_dice1.Size = new System.Drawing.Size(62, 51);
            this.Player_dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice1.TabIndex = 4;
            this.Player_dice1.TabStop = false;
            // 
            // Player_dice2
            // 
            this.Player_dice2.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice2.Image")));
            this.Player_dice2.Location = new System.Drawing.Point(12, 306);
            this.Player_dice2.Name = "Player_dice2";
            this.Player_dice2.Size = new System.Drawing.Size(62, 51);
            this.Player_dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice2.TabIndex = 5;
            this.Player_dice2.TabStop = false;
            // 
            // Player_dice3
            // 
            this.Player_dice3.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice3.Image")));
            this.Player_dice3.Location = new System.Drawing.Point(12, 306);
            this.Player_dice3.Name = "Player_dice3";
            this.Player_dice3.Size = new System.Drawing.Size(62, 51);
            this.Player_dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice3.TabIndex = 6;
            this.Player_dice3.TabStop = false;
            // 
            // Player_dice4
            // 
            this.Player_dice4.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice4.Image")));
            this.Player_dice4.Location = new System.Drawing.Point(12, 306);
            this.Player_dice4.Name = "Player_dice4";
            this.Player_dice4.Size = new System.Drawing.Size(62, 51);
            this.Player_dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice4.TabIndex = 7;
            this.Player_dice4.TabStop = false;
            // 
            // Player_dice5
            // 
            this.Player_dice5.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice5.Image")));
            this.Player_dice5.Location = new System.Drawing.Point(12, 306);
            this.Player_dice5.Name = "Player_dice5";
            this.Player_dice5.Size = new System.Drawing.Size(62, 51);
            this.Player_dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice5.TabIndex = 8;
            this.Player_dice5.TabStop = false;
            // 
            // Player_dice6
            // 
            this.Player_dice6.Image = ((System.Drawing.Image)(resources.GetObject("Player_dice6.Image")));
            this.Player_dice6.Location = new System.Drawing.Point(12, 306);
            this.Player_dice6.Name = "Player_dice6";
            this.Player_dice6.Size = new System.Drawing.Size(62, 51);
            this.Player_dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player_dice6.TabIndex = 9;
            this.Player_dice6.TabStop = false;
            // 
            // Ai_dice6
            // 
            this.Ai_dice6.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice6.Image")));
            this.Ai_dice6.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice6.Name = "Ai_dice6";
            this.Ai_dice6.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice6.TabIndex = 15;
            this.Ai_dice6.TabStop = false;
            // 
            // Ai_dice5
            // 
            this.Ai_dice5.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice5.Image")));
            this.Ai_dice5.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice5.Name = "Ai_dice5";
            this.Ai_dice5.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice5.TabIndex = 14;
            this.Ai_dice5.TabStop = false;
            // 
            // Ai_dice4
            // 
            this.Ai_dice4.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice4.Image")));
            this.Ai_dice4.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice4.Name = "Ai_dice4";
            this.Ai_dice4.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice4.TabIndex = 13;
            this.Ai_dice4.TabStop = false;
            // 
            // Ai_dice3
            // 
            this.Ai_dice3.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice3.Image")));
            this.Ai_dice3.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice3.Name = "Ai_dice3";
            this.Ai_dice3.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice3.TabIndex = 12;
            this.Ai_dice3.TabStop = false;
            // 
            // Ai_dice2
            // 
            this.Ai_dice2.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice2.Image")));
            this.Ai_dice2.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice2.Name = "Ai_dice2";
            this.Ai_dice2.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice2.TabIndex = 11;
            this.Ai_dice2.TabStop = false;
            // 
            // Ai_dice1
            // 
            this.Ai_dice1.Image = ((System.Drawing.Image)(resources.GetObject("Ai_dice1.Image")));
            this.Ai_dice1.Location = new System.Drawing.Point(276, 306);
            this.Ai_dice1.Name = "Ai_dice1";
            this.Ai_dice1.Size = new System.Drawing.Size(62, 51);
            this.Ai_dice1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ai_dice1.TabIndex = 10;
            this.Ai_dice1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(277, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ai Dice";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(8, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Player Dice";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.win.ForeColor = System.Drawing.SystemColors.Control;
            this.win.Location = new System.Drawing.Point(12, 338);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(60, 19);
            this.win.TabIndex = 18;
            this.win.Text = "Win : 0";
            this.win.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lap
            // 
            this.lap.AutoSize = true;
            this.lap.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lap.ForeColor = System.Drawing.SystemColors.Control;
            this.lap.Location = new System.Drawing.Point(12, 306);
            this.lap.Name = "lap";
            this.lap.Size = new System.Drawing.Size(57, 19);
            this.lap.TabIndex = 19;
            this.lap.Text = "Lap : 0";
            this.lap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(350, 369);
            this.Controls.Add(this.lap);
            this.Controls.Add(this.win);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Ai_dice6);
            this.Controls.Add(this.Ai_dice5);
            this.Controls.Add(this.Ai_dice4);
            this.Controls.Add(this.Ai_dice3);
            this.Controls.Add(this.Ai_dice2);
            this.Controls.Add(this.Ai_dice1);
            this.Controls.Add(this.Player_dice6);
            this.Controls.Add(this.Player_dice5);
            this.Controls.Add(this.Player_dice4);
            this.Controls.Add(this.Player_dice3);
            this.Controls.Add(this.Player_dice2);
            this.Controls.Add(this.Player_dice1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(366, 408);
            this.MinimumSize = new System.Drawing.Size(366, 408);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dice Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ai_dice1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox Player_dice1;
        private System.Windows.Forms.PictureBox Player_dice2;
        private System.Windows.Forms.PictureBox Player_dice3;
        private System.Windows.Forms.PictureBox Player_dice4;
        private System.Windows.Forms.PictureBox Player_dice5;
        private System.Windows.Forms.PictureBox Player_dice6;
        private System.Windows.Forms.PictureBox Ai_dice6;
        private System.Windows.Forms.PictureBox Ai_dice5;
        private System.Windows.Forms.PictureBox Ai_dice4;
        private System.Windows.Forms.PictureBox Ai_dice3;
        private System.Windows.Forms.PictureBox Ai_dice2;
        private System.Windows.Forms.PictureBox Ai_dice1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label lap;
    }
}

