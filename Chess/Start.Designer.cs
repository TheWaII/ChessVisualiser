
namespace Chess
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.pBoxKingWhite = new System.Windows.Forms.PictureBox();
            this.pBoxKingBlack = new System.Windows.Forms.PictureBox();
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.rbtnEasy = new System.Windows.Forms.RadioButton();
            this.rbtnHard = new System.Windows.Forms.RadioButton();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.grpbxDifficulty = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingBlack)).BeginInit();
            this.grpbxDifficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBoxKingWhite
            // 
            this.pBoxKingWhite.Image = global::Chess.Properties.Resources.WhiteKing;
            this.pBoxKingWhite.Location = new System.Drawing.Point(12, 12);
            this.pBoxKingWhite.Name = "pBoxKingWhite";
            this.pBoxKingWhite.Size = new System.Drawing.Size(80, 82);
            this.pBoxKingWhite.TabIndex = 0;
            this.pBoxKingWhite.TabStop = false;
            // 
            // pBoxKingBlack
            // 
            this.pBoxKingBlack.Image = global::Chess.Properties.Resources.BlackKing;
            this.pBoxKingBlack.Location = new System.Drawing.Point(344, 12);
            this.pBoxKingBlack.Name = "pBoxKingBlack";
            this.pBoxKingBlack.Size = new System.Drawing.Size(80, 82);
            this.pBoxKingBlack.TabIndex = 2;
            this.pBoxKingBlack.TabStop = false;
            // 
            // btnWhite
            // 
            this.btnWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhite.Location = new System.Drawing.Point(12, 110);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(80, 23);
            this.btnWhite.TabIndex = 3;
            this.btnWhite.Text = "White";
            this.btnWhite.UseVisualStyleBackColor = true;
            this.btnWhite.Click += new System.EventHandler(this.btnWhite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlack.Location = new System.Drawing.Point(344, 110);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(80, 23);
            this.btnBlack.TabIndex = 4;
            this.btnBlack.Text = "Black";
            this.btnBlack.UseVisualStyleBackColor = true;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 269);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(412, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // rbtnEasy
            // 
            this.rbtnEasy.AutoSize = true;
            this.rbtnEasy.Location = new System.Drawing.Point(16, 42);
            this.rbtnEasy.Name = "rbtnEasy";
            this.rbtnEasy.Size = new System.Drawing.Size(48, 17);
            this.rbtnEasy.TabIndex = 7;
            this.rbtnEasy.TabStop = true;
            this.rbtnEasy.Text = "Easy";
            this.rbtnEasy.UseVisualStyleBackColor = true;
            // 
            // rbtnHard
            // 
            this.rbtnHard.AutoSize = true;
            this.rbtnHard.Location = new System.Drawing.Point(323, 42);
            this.rbtnHard.Name = "rbtnHard";
            this.rbtnHard.Size = new System.Drawing.Size(48, 17);
            this.rbtnHard.TabIndex = 8;
            this.rbtnHard.TabStop = true;
            this.rbtnHard.Text = "Hard";
            this.rbtnHard.UseVisualStyleBackColor = true;
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.Location = new System.Drawing.Point(159, 42);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(58, 17);
            this.rbtnNormal.TabIndex = 9;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "Normal";
            this.rbtnNormal.UseVisualStyleBackColor = true;
            // 
            // grpbxDifficulty
            // 
            this.grpbxDifficulty.Controls.Add(this.rbtnNormal);
            this.grpbxDifficulty.Controls.Add(this.rbtnHard);
            this.grpbxDifficulty.Controls.Add(this.rbtnEasy);
            this.grpbxDifficulty.Location = new System.Drawing.Point(12, 181);
            this.grpbxDifficulty.Name = "grpbxDifficulty";
            this.grpbxDifficulty.Size = new System.Drawing.Size(412, 82);
            this.grpbxDifficulty.TabIndex = 10;
            this.grpbxDifficulty.TabStop = false;
            this.grpbxDifficulty.Text = "Difficulty";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 300);
            this.Controls.Add(this.grpbxDifficulty);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.pBoxKingBlack);
            this.Controls.Add(this.pBoxKingWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "Chess";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingBlack)).EndInit();
            this.grpbxDifficulty.ResumeLayout(false);
            this.grpbxDifficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxKingWhite;
        private System.Windows.Forms.PictureBox pBoxKingBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.RadioButton rbtnEasy;
        private System.Windows.Forms.RadioButton rbtnHard;
        private System.Windows.Forms.RadioButton rbtnNormal;
        private System.Windows.Forms.GroupBox grpbxDifficulty;
    }
}