namespace mafinka
{
    partial class mafinka
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mafinka));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.car = new System.Windows.Forms.PictureBox();
            this.BG1 = new System.Windows.Forms.PictureBox();
            this.BG2 = new System.Windows.Forms.PictureBox();
            this.labelLose = new System.Windows.Forms.Label();
            this.Restart = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemy3.Image = global::mafinka.Properties.Resources.enemy3;
            this.enemy3.Location = new System.Drawing.Point(563, -400);
            this.enemy3.Name = "enemy3";
            this.enemy3.Size = new System.Drawing.Size(85, 117);
            this.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy3.TabIndex = 5;
            this.enemy3.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemy2.Image = global::mafinka.Properties.Resources.enemy2;
            this.enemy2.Location = new System.Drawing.Point(315, -200);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(85, 117);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.enemy1.Image = global::mafinka.Properties.Resources.enemy1;
            this.enemy1.Location = new System.Drawing.Point(188, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(85, 117);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.DimGray;
            this.car.Image = global::mafinka.Properties.Resources.car;
            this.car.Location = new System.Drawing.Point(438, 446);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(85, 117);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.car.TabIndex = 1;
            this.car.TabStop = false;
            // 
            // BG1
            // 
            this.BG1.Image = global::mafinka.Properties.Resources.bg;
            this.BG1.Location = new System.Drawing.Point(0, 0);
            this.BG1.Name = "BG1";
            this.BG1.Size = new System.Drawing.Size(840, 650);
            this.BG1.TabIndex = 0;
            this.BG1.TabStop = false;
            // 
            // BG2
            // 
            this.BG2.Image = global::mafinka.Properties.Resources.bg;
            this.BG2.Location = new System.Drawing.Point(0, -640);
            this.BG2.Name = "BG2";
            this.BG2.Size = new System.Drawing.Size(840, 650);
            this.BG2.TabIndex = 2;
            this.BG2.TabStop = false;
            // 
            // labelLose
            // 
            this.labelLose.AutoSize = true;
            this.labelLose.BackColor = System.Drawing.Color.Black;
            this.labelLose.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLose.ForeColor = System.Drawing.Color.Red;
            this.labelLose.Location = new System.Drawing.Point(301, 154);
            this.labelLose.Name = "labelLose";
            this.labelLose.Size = new System.Drawing.Size(237, 44);
            this.labelLose.TabIndex = 6;
            this.labelLose.Text = "ПОТРАЧЕНО";
            // 
            // Restart
            // 
            this.Restart.BackColor = System.Drawing.Color.Black;
            this.Restart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Restart.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Restart.ForeColor = System.Drawing.Color.White;
            this.Restart.Location = new System.Drawing.Point(354, 271);
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(131, 66);
            this.Restart.TabIndex = 7;
            this.Restart.Text = "Reset";
            this.Restart.UseVisualStyleBackColor = false;
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.Gray;
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(463, -700);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(32, 32);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 8;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.Black;
            this.labelCoins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.Color.White;
            this.labelCoins.Location = new System.Drawing.Point(717, 13);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(83, 25);
            this.labelCoins.TabIndex = 9;
            this.labelCoins.Text = "Coin: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.Restart);
            this.Controls.Add(this.labelLose);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.car);
            this.Controls.Add(this.BG1);
            this.Controls.Add(this.BG2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BG1;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox BG2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label labelLose;
        private System.Windows.Forms.Button Restart;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
    }
}

