
namespace projektTest
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAnswerA = new System.Windows.Forms.Button();
            this.buttonAnswerB = new System.Windows.Forms.Button();
            this.buttonAnswerC = new System.Windows.Forms.Button();
            this.buttonAnswerD = new System.Windows.Forms.Button();
            this.panelRightSite = new System.Windows.Forms.Panel();
            this.panelQuestionAnswer = new System.Windows.Forms.Panel();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.panelQuestionAnswer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAnswerA
            // 
            this.ButtonAnswerA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAnswerA.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonAnswerA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAnswerA.ForeColor = System.Drawing.Color.AliceBlue;
            this.ButtonAnswerA.Location = new System.Drawing.Point(10, 76);
            this.ButtonAnswerA.Name = "ButtonAnswerA";
            this.ButtonAnswerA.Size = new System.Drawing.Size(337, 65);
            this.ButtonAnswerA.TabIndex = 0;
            this.ButtonAnswerA.Text = "button1";
            this.ButtonAnswerA.UseVisualStyleBackColor = false;
            // 
            // buttonAnswerB
            // 
            this.buttonAnswerB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnswerB.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerB.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonAnswerB.Location = new System.Drawing.Point(353, 76);
            this.buttonAnswerB.Name = "buttonAnswerB";
            this.buttonAnswerB.Size = new System.Drawing.Size(343, 65);
            this.buttonAnswerB.TabIndex = 1;
            this.buttonAnswerB.Text = "button2";
            this.buttonAnswerB.UseVisualStyleBackColor = false;
            // 
            // buttonAnswerC
            // 
            this.buttonAnswerC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnswerC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerC.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonAnswerC.Location = new System.Drawing.Point(10, 147);
            this.buttonAnswerC.Name = "buttonAnswerC";
            this.buttonAnswerC.Size = new System.Drawing.Size(337, 65);
            this.buttonAnswerC.TabIndex = 2;
            this.buttonAnswerC.Text = "button3";
            this.buttonAnswerC.UseVisualStyleBackColor = false;
            // 
            // buttonAnswerD
            // 
            this.buttonAnswerD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAnswerD.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAnswerD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnswerD.ForeColor = System.Drawing.Color.AliceBlue;
            this.buttonAnswerD.Location = new System.Drawing.Point(353, 147);
            this.buttonAnswerD.Name = "buttonAnswerD";
            this.buttonAnswerD.Size = new System.Drawing.Size(343, 65);
            this.buttonAnswerD.TabIndex = 3;
            this.buttonAnswerD.Text = "button4";
            this.buttonAnswerD.UseVisualStyleBackColor = false;
            // 
            // panelRightSite
            // 
            this.panelRightSite.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelRightSite.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightSite.Location = new System.Drawing.Point(718, 0);
            this.panelRightSite.Name = "panelRightSite";
            this.panelRightSite.Size = new System.Drawing.Size(321, 760);
            this.panelRightSite.TabIndex = 4;
            // 
            // panelQuestionAnswer
            // 
            this.panelQuestionAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestionAnswer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelQuestionAnswer.Controls.Add(this.labelQuestion);
            this.panelQuestionAnswer.Controls.Add(this.buttonAnswerD);
            this.panelQuestionAnswer.Controls.Add(this.buttonAnswerC);
            this.panelQuestionAnswer.Controls.Add(this.buttonAnswerB);
            this.panelQuestionAnswer.Controls.Add(this.ButtonAnswerA);
            this.panelQuestionAnswer.Location = new System.Drawing.Point(5, 529);
            this.panelQuestionAnswer.Name = "panelQuestionAnswer";
            this.panelQuestionAnswer.Size = new System.Drawing.Size(707, 219);
            this.panelQuestionAnswer.TabIndex = 5;
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelQuestion.BackColor = System.Drawing.SystemColors.Desktop;
            this.labelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelQuestion.Location = new System.Drawing.Point(12, 5);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(684, 68);
            this.labelQuestion.TabIndex = 4;
            this.labelQuestion.Text = "Question";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 760);
            this.Controls.Add(this.panelQuestionAnswer);
            this.Controls.Add(this.panelRightSite);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "question";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelQuestionAnswer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonAnswerA;
        private System.Windows.Forms.Button buttonAnswerB;
        private System.Windows.Forms.Button buttonAnswerC;
        private System.Windows.Forms.Button buttonAnswerD;
        private System.Windows.Forms.Panel panelRightSite;
        private System.Windows.Forms.Panel panelQuestionAnswer;
        private System.Windows.Forms.Label labelQuestion;
    }
}

