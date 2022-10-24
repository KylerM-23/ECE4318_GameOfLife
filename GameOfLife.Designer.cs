
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
            this.SizeBox = new System.Windows.Forms.TextBox();
            this.Alive_Color_Textbox = new System.Windows.Forms.TextBox();
            this.Dead_Color_Textbox = new System.Windows.Forms.TextBox();
            this.Apply_Config_button = new System.Windows.Forms.Button();
            this.colorlabel = new System.Windows.Forms.Label();
            this.AliveColor = new System.Windows.Forms.Label();
            this.deadlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NextGen
            // 
            this.NextGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextGen.Location = new System.Drawing.Point(627, 91);
            this.NextGen.Name = "NextGen";
            this.NextGen.Size = new System.Drawing.Size(160, 38);
            this.NextGen.TabIndex = 0;
            this.NextGen.Text = "Next Gen";
            this.NextGen.UseVisualStyleBackColor = true;
            this.NextGen.Click += new System.EventHandler(this.Next_Gen);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conway\'s Game Of Life";
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(22, 354);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(156, 39);
            this.Reset.TabIndex = 2;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.ResetCells);
            // 
            // GenLabel
            // 
            this.GenLabel.AutoSize = true;
            this.GenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenLabel.Location = new System.Drawing.Point(24, 82);
            this.GenLabel.Name = "GenLabel";
            this.GenLabel.Size = new System.Drawing.Size(44, 20);
            this.GenLabel.TabIndex = 3;
            this.GenLabel.Text = "Gen:";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeLabel.Location = new System.Drawing.Point(24, 132);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(44, 20);
            this.SizeLabel.TabIndex = 4;
            this.SizeLabel.Text = "Size:";
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveGameButton.Location = new System.Drawing.Point(626, 301);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(160, 36);
            this.SaveGameButton.TabIndex = 5;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            this.SaveGameButton.Click += new System.EventHandler(this.saveGame);
            // 
            // LoadGameButton
            // 
            this.LoadGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadGameButton.Location = new System.Drawing.Point(626, 354);
            this.LoadGameButton.Name = "LoadGameButton";
            this.LoadGameButton.Size = new System.Drawing.Size(160, 39);
            this.LoadGameButton.TabIndex = 6;
            this.LoadGameButton.Text = "Load Game";
            this.LoadGameButton.UseVisualStyleBackColor = true;
            this.LoadGameButton.Click += new System.EventHandler(this.loadGame);
            // 
            // Forward_Textbox
            // 
            this.Forward_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Textbox.Location = new System.Drawing.Point(628, 199);
            this.Forward_Textbox.Name = "Forward_Textbox";
            this.Forward_Textbox.Size = new System.Drawing.Size(160, 26);
            this.Forward_Textbox.TabIndex = 7;
            this.Forward_Textbox.Text = "0";
            // 
            // Forward_Button
            // 
            this.Forward_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forward_Button.Location = new System.Drawing.Point(627, 144);
            this.Forward_Button.Name = "Forward_Button";
            this.Forward_Button.Size = new System.Drawing.Size(161, 45);
            this.Forward_Button.TabIndex = 8;
            this.Forward_Button.Text = "Fast Forward";
            this.Forward_Button.UseVisualStyleBackColor = true;
            this.Forward_Button.Click += new System.EventHandler(this.FastForward);
            // 
            // Extinction_Score
            // 
            this.Extinction_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Score.Location = new System.Drawing.Point(439, 9);
            this.Extinction_Score.Name = "Extinction_Score";
            this.Extinction_Score.Size = new System.Drawing.Size(300, 20);
            this.Extinction_Score.TabIndex = 9;
            this.Extinction_Score.Text = "Extinction Score:0";
            // 
            // Extinction_Game
            // 
            this.Extinction_Game.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extinction_Game.Location = new System.Drawing.Point(626, 242);
            this.Extinction_Game.Name = "Extinction_Game";
            this.Extinction_Game.Size = new System.Drawing.Size(161, 37);
            this.Extinction_Game.TabIndex = 10;
            this.Extinction_Game.Text = "Play Extinction";
            this.Extinction_Game.UseVisualStyleBackColor = true;
            this.Extinction_Game.Click += new System.EventHandler(this.Extinction);
            // 
            // SizeBox
            // 
            this.SizeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeBox.Location = new System.Drawing.Point(82, 129);
            this.SizeBox.Name = "SizeBox";
            this.SizeBox.Size = new System.Drawing.Size(96, 26);
            this.SizeBox.TabIndex = 11;
            this.SizeBox.Text = "0";
            // 
            // Alive_Color_Textbox
            // 
            this.Alive_Color_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alive_Color_Textbox.Location = new System.Drawing.Point(82, 210);
            this.Alive_Color_Textbox.Name = "Alive_Color_Textbox";
            this.Alive_Color_Textbox.Size = new System.Drawing.Size(96, 26);
            this.Alive_Color_Textbox.TabIndex = 12;
            this.Alive_Color_Textbox.Text = "green";
            // 
            // Dead_Color_Textbox
            // 
            this.Dead_Color_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dead_Color_Textbox.Location = new System.Drawing.Point(82, 242);
            this.Dead_Color_Textbox.Name = "Dead_Color_Textbox";
            this.Dead_Color_Textbox.Size = new System.Drawing.Size(96, 26);
            this.Dead_Color_Textbox.TabIndex = 13;
            this.Dead_Color_Textbox.Text = "black";
            // 
            // Apply_Config_button
            // 
            this.Apply_Config_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apply_Config_button.Location = new System.Drawing.Point(22, 297);
            this.Apply_Config_button.Name = "Apply_Config_button";
            this.Apply_Config_button.Size = new System.Drawing.Size(156, 40);
            this.Apply_Config_button.TabIndex = 14;
            this.Apply_Config_button.Text = "Apply Changes";
            this.Apply_Config_button.UseVisualStyleBackColor = true;
            this.Apply_Config_button.Click += new System.EventHandler(this.Set_Dim_and_Cell_Colors);
            // 
            // colorlabel
            // 
            this.colorlabel.AutoSize = true;
            this.colorlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorlabel.Location = new System.Drawing.Point(18, 178);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(58, 20);
            this.colorlabel.TabIndex = 15;
            this.colorlabel.Text = "Colors:";
            // 
            // AliveColor
            // 
            this.AliveColor.AutoSize = true;
            this.AliveColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AliveColor.Location = new System.Drawing.Point(24, 213);
            this.AliveColor.Name = "AliveColor";
            this.AliveColor.Size = new System.Drawing.Size(46, 20);
            this.AliveColor.TabIndex = 16;
            this.AliveColor.Text = "Alive:";
            // 
            // deadlabel
            // 
            this.deadlabel.AutoSize = true;
            this.deadlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlabel.Location = new System.Drawing.Point(24, 245);
            this.deadlabel.Name = "deadlabel";
            this.deadlabel.Size = new System.Drawing.Size(52, 20);
            this.deadlabel.TabIndex = 17;
            this.deadlabel.Text = "Dead:";
            // 
            // GameOfLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 462);
            this.Controls.Add(this.deadlabel);
            this.Controls.Add(this.AliveColor);
            this.Controls.Add(this.colorlabel);
            this.Controls.Add(this.SizeBox);
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
            this.Controls.Add(this.Alive_Color_Textbox);
            this.Controls.Add(this.Dead_Color_Textbox);
            this.Controls.Add(this.Apply_Config_button);
            this.Name = "GameOfLife";
            this.Text = "Game Of Life";
            this.Load += new System.EventHandler(this.GameOfLife_Load);
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
        private System.Windows.Forms.TextBox SizeBox;
        private System.Windows.Forms.TextBox Alive_Color_Textbox;
        private System.Windows.Forms.TextBox Dead_Color_Textbox;
        private System.Windows.Forms.Button Apply_Config_button;
        private System.Windows.Forms.Label colorlabel;
        private System.Windows.Forms.Label AliveColor;
        private System.Windows.Forms.Label deadlabel;
    }
}
