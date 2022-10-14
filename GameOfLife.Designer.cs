
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
            this.NextGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.GenLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.LoadGameButton = new System.Windows.Forms.Button();
            this.Forward_Textbox = new System.Windows.Forms.TextBox();
            this.Forward_Button = new System.Windows.Forms.Button();
            this.Extinction_Score = new System.Windows.Forms.Label();
            this.Extinction_Game = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NextGen
            // 
            this.NextGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextGen.Location = new System.Drawing.Point(50, 184);
            this.NextGen.Name = "NextGen";
            this.NextGen.Size = new System.Drawing.Size(130, 70);
            this.NextGen.TabIndex = 0;
            this.NextGen.Text = "Next Gen";
            this.NextGen.UseVisualStyleBackColor = true;
            this.NextGen.Click += new System.EventHandler(this.Next_Gen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conway\'s Game Of Life";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(661, 332);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(160, 70);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.ResetCells);
            // 
            // GenLabel
            // 
            this.GenLabel.AutoSize = true;
            this.GenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenLabel.Location = new System.Drawing.Point(46, 82);
            this.GenLabel.Name = "GenLabel";
            this.GenLabel.Size = new System.Drawing.Size(44, 20);
            this.GenLabel.TabIndex = 3;
            this.GenLabel.Text = "Gen:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(46, 132);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(44, 20);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:";
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGameButton.Location = new System.Drawing.Point(661, 169);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(160, 70);
            this.SaveGameButton.TabIndex = 5;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.saveGame);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGameButton.Location = new System.Drawing.Point(661, 251);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(160, 70);
            this.LoadGameButton.TabIndex = 6;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.loadGame);
            // 
            // Forward_Textbox
            // 
            this.Forward_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Textbox.Location = new System.Drawing.Point(67, 376);
            this.Forward_Textbox.Name = "Forward_Textbox";
            this.Forward_Textbox.Size = new System.Drawing.Size(100, 26);
            this.Forward_Textbox.TabIndex = 7;
            this.Forward_Textbox.Text = "0";
            // 
            // Forward_Button
            // 
            this.Forward_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Button.Location = new System.Drawing.Point(50, 280);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(130, 72);
            this.Forward_Button.TabIndex = 8;
            this.Forward_Button.Text = "Fast Forward:";
            this.Forward_Button.UseVisualStyleBackColor = true;
            this.Forward_Button.Click += new System.EventHandler(this.FastForward);
            // 
            // Extinction_Score
            // 
            this.Extinction_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Score.Location = new System.Drawing.Point(512, 9);
            this.Extinction_Score.Name = "Extinction_Score";
            this.Extinction_Score.Size = new System.Drawing.Size(300, 20);
            this.Extinction_Score.TabIndex = 9;
            this.Extinction_Score.Text = "Extinction Score:0";
            // 
            // Extinction_Game
            // 
            this.Extinction_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Game.Location = new System.Drawing.Point(661, 89);
            this.Extinction_Game.Name = "Extinction_Game";
            this.Extinction_Game.Size = new System.Drawing.Size(160, 70);
            this.Extinction_Game.TabIndex = 10;
            this.Extinction_Game.Text = "Play Extinction";
            this.Extinction_Game.UseVisualStyleBackColor = true;
            this.Extinction_Game.Click += new System.EventHandler(this.Extinction);
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 454);
            this.Controls.Add(this.LoadGameButton);
            this.Controls.Add(this.SaveGameButton);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.GenLabel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NextGen);
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

        private System.Windows.Forms.Button NextGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label GenLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button LoadGameButton;
        private System.Windows.Forms.TextBox Forward_Textbox;
        private System.Windows.Forms.Button Forward_Button;
        private System.Windows.Forms.Label Extinction_Score;
        private System.Windows.Forms.Button Extinction_Game;
    }
}

