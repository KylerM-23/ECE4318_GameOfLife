
namespace GameOfLife
{
    partial class GameOfLife
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.GenLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Forward_Textbox = new System.Windows.Forms.TextBox();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.Extinction_Score = new System.Windows.Forms.Label();
            this.Extinction_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(57, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "Next Gen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Next_Gen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conway\'s Game Of Life";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(57, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResetCells);
            // 
            // GenLabel
            // 
            this.GenLabel.AutoSize = true;
            this.GenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenLabel.Location = new System.Drawing.Point(53, 196);
            this.GenLabel.Name = "GenLabel";
            this.GenLabel.Size = new System.Drawing.Size(44, 20);
            this.GenLabel.TabIndex = 3;
            this.GenLabel.Text = "Gen:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(53, 251);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(44, 20);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(688, 89);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Save Game";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.saveGame);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(688, 300);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 6;
            this.button4.Text = "Load Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.loadGame);
            // 
            // Forward_Textbox
            // 
            this.Forward_Textbox.AutoSize = true;
            this.Forward_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Textbox.Location = new System.Drawing.Point(610, 530);
            this.Forward_Textbox.Name = "Forward_Textbox";
            this.Forward_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Forward_Textbox.TabIndex = 7;
            this.Forward_Textbox.Text = "0";
            // 
            // Forward_Button
            // 
            this.Forward_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Button.Location = new System.Drawing.Point(500, 500);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(105, 85);
            this.Forward_Button.TabIndex = 8;
            this.Forward_Button.Text = "Fast Forward:";
            this.Forward_Button.UseVisualStyleBackColor = true;
            this.Forward_Button.Click += new System.EventHandler(this.FastForward);
            // 
            // Extinction_Score
            // 
            this.Extinction_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Score.Location = new System.Drawing.Point(700, 600);
            this.Extinction_Score.Name = "Extinction_Score";
            this.Extinction_Score.Size = new System.Drawing.Size(300, 20);
            this.Extinction_Score.TabIndex = 9;
            this.Extinction_Score.Text = "Extinction Score:0";
            // 
            // Extinction_Game
            // 
            this.Forward_Textbox.AutoSize = true;
            this.Extinction_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Game.Location = new System.Drawing.Point(700, 620);
            this.Extinction_Game.Name = "Extinction_Game";
            this.Extinction_Game.Size = new System.Drawing.Size(105, 85);
            this.Extinction_Game.TabIndex = 10;
            this.Extinction_Game.Text = "Play Extinction (~1min)";
            this.Extinction_Game.UseVisualStyleBackColor = true;
            this.Extinction_Game.Click += new System.EventHandler(this.Extinction);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.GenLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Forward_Textbox);
            this.Controls.Add(this.Forward_Button);
            this.Controls.Add(this.Extinction_Score);
            this.Controls.Add(this.Extinction_Game);
            this.Name = "GameOfLife";
            this.Text = "Game Of Life";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label GenLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox Forward_Textbox;
        private System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.Label Extinction_Score;
        private System.Windows.Forms.Button Extinction_Game;
    }
}

