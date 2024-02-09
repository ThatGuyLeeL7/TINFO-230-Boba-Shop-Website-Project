﻿namespace Tic_Tac_Toe_Project
{
    partial class TicTacToeGame
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
            this.PlayerWinsText = new System.Windows.Forms.Label();
            this.CPUWinsText = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.CPUTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DrawScoreText = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerWinsText
            // 
            this.PlayerWinsText.AutoSize = true;
            this.PlayerWinsText.BackColor = System.Drawing.Color.Transparent;
            this.PlayerWinsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerWinsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerWinsText.ForeColor = System.Drawing.Color.Green;
            this.PlayerWinsText.Location = new System.Drawing.Point(3, 48);
            this.PlayerWinsText.Name = "PlayerWinsText";
            this.PlayerWinsText.Size = new System.Drawing.Size(257, 48);
            this.PlayerWinsText.TabIndex = 1;
            this.PlayerWinsText.Text = "Player Wins:";
            this.PlayerWinsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CPUWinsText
            // 
            this.CPUWinsText.AutoSize = true;
            this.CPUWinsText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CPUWinsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUWinsText.ForeColor = System.Drawing.Color.Red;
            this.CPUWinsText.Location = new System.Drawing.Point(529, 48);
            this.CPUWinsText.Name = "CPUWinsText";
            this.CPUWinsText.Size = new System.Drawing.Size(257, 48);
            this.CPUWinsText.TabIndex = 2;
            this.CPUWinsText.Text = "CPU Wins:";
            this.CPUWinsText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(3, 819);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(100, 38);
            this.button10.TabIndex = 3;
            this.button10.Text = "Start";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.RestartGame);
            // 
            // CPUTimer
            // 
            this.CPUTimer.Interval = 1;
            this.CPUTimer.Tick += new System.EventHandler(this.CPUmove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 234);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(266, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 234);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(529, 99);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 234);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(3, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 234);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(266, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(257, 234);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(529, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(257, 234);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(3, 579);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(257, 234);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(266, 579);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(257, 234);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(529, 579);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(257, 234);
            this.button9.TabIndex = 9;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.PlayerClickButton);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.CPUWinsText, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.DrawScoreText, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PlayerWinsText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(789, 864);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // DrawScoreText
            // 
            this.DrawScoreText.AutoSize = true;
            this.DrawScoreText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawScoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawScoreText.ForeColor = System.Drawing.Color.Purple;
            this.DrawScoreText.Location = new System.Drawing.Point(266, 48);
            this.DrawScoreText.Name = "DrawScoreText";
            this.DrawScoreText.Size = new System.Drawing.Size(257, 48);
            this.DrawScoreText.TabIndex = 4;
            this.DrawScoreText.Text = "Ties:";
            this.DrawScoreText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TicTacToeGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 864);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TicTacToeGame";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PlayerWinsText;
        private System.Windows.Forms.Label CPUWinsText;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Timer CPUTimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label DrawScoreText;
    }
}

