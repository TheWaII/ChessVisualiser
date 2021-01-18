
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
            this.btnWhite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pBoxKingBlack = new System.Windows.Forms.PictureBox();
            this.pBoxKingWhite = new System.Windows.Forms.PictureBox();
            this.nudDifficulty = new System.Windows.Forms.NumericUpDown();
            this.lblDifficulty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).BeginInit();
            this.SuspendLayout();
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
            this.btnPlay.Location = new System.Drawing.Point(12, 139);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(412, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
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
            // pBoxKingWhite
            // 
            this.pBoxKingWhite.Image = global::Chess.Properties.Resources.WhiteKing;
            this.pBoxKingWhite.Location = new System.Drawing.Point(12, 12);
            this.pBoxKingWhite.Name = "pBoxKingWhite";
            this.pBoxKingWhite.Size = new System.Drawing.Size(80, 82);
            this.pBoxKingWhite.TabIndex = 0;
            this.pBoxKingWhite.TabStop = false;
            // 
            // nudDifficulty
            // 
            this.nudDifficulty.Location = new System.Drawing.Point(162, 113);
            this.nudDifficulty.Name = "nudDifficulty";
            this.nudDifficulty.Size = new System.Drawing.Size(120, 20);
            this.nudDifficulty.TabIndex = 6;
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.BackColor = System.Drawing.SystemColors.Control;
            this.lblDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDifficulty.Location = new System.Drawing.Point(182, 86);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(77, 24);
            this.lblDifficulty.TabIndex = 7;
            this.lblDifficulty.Text = "Difficulty";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 171);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.nudDifficulty);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnBlack);
            this.Controls.Add(this.btnWhite);
            this.Controls.Add(this.pBoxKingBlack);
            this.Controls.Add(this.pBoxKingWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Start";
            this.Text = "Chess";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxKingWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBoxKingWhite;
        private System.Windows.Forms.PictureBox pBoxKingBlack;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnBlack;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.NumericUpDown nudDifficulty;
        private System.Windows.Forms.Label lblDifficulty;
    }
}