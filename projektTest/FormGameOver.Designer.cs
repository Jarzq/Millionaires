
namespace projektTest
{
    partial class FormGameOver
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
            this.buttonPlayAgain = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelPrizeWon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlayAgain
            // 
            this.buttonPlayAgain.Location = new System.Drawing.Point(181, 161);
            this.buttonPlayAgain.Name = "buttonPlayAgain";
            this.buttonPlayAgain.Size = new System.Drawing.Size(436, 93);
            this.buttonPlayAgain.TabIndex = 0;
            this.buttonPlayAgain.Text = "Zagraj jeszcze raz";
            this.buttonPlayAgain.UseVisualStyleBackColor = true;
            this.buttonPlayAgain.Click += new System.EventHandler(this.buttonPlayAgain_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(178, 279);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(439, 99);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Wyjdz z gry";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelPrizeWon
            // 
            this.labelPrizeWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPrizeWon.Location = new System.Drawing.Point(97, 49);
            this.labelPrizeWon.Name = "labelPrizeWon";
            this.labelPrizeWon.Size = new System.Drawing.Size(649, 104);
            this.labelPrizeWon.TabIndex = 2;
            this.labelPrizeWon.Text = "gratki";
            // 
            // FormGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelPrizeWon);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPlayAgain);
            this.Name = "FormGameOver";
            this.Text = "FormGameOver";
            this.Load += new System.EventHandler(this.FormGameOver_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlayAgain;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelPrizeWon;
    }
}