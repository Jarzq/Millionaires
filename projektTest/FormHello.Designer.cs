
namespace projektTest
{
    partial class FormHello
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
            this.labelHello = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHello
            // 
            this.labelHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelHello.Location = new System.Drawing.Point(53, 45);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(699, 89);
            this.labelHello.TabIndex = 1;
            this.labelHello.Text = "Witaj w grze Millionerzy!";
            this.labelHello.UseWaitCursor = true;
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonStartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStartGame.Location = new System.Drawing.Point(230, 183);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(359, 87);
            this.buttonStartGame.TabIndex = 2;
            this.buttonStartGame.Text = "Rozpocznij gre";
            this.buttonStartGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStartGame.UseVisualStyleBackColor = false;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // FormHello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelHello);
            this.Name = "FormHello";
            this.Text = "FormHello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHello;
        private System.Windows.Forms.Button buttonStartGame;
    }
}