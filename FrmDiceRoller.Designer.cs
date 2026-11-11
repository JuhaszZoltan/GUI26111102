namespace GUI26111102
{
    partial class FrmDiceRoller
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblQuestion = new Label();
            txtNumberOfDice = new TextBox();
            lblDiceRolls = new Label();
            btnRoll = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(48, 40);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(222, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "Hány kockadobást kérsz?";
            // 
            // txtNumberOfDice
            // 
            txtNumberOfDice.Location = new Point(329, 37);
            txtNumberOfDice.Name = "txtNumberOfDice";
            txtNumberOfDice.Size = new Size(100, 32);
            txtNumberOfDice.TabIndex = 1;
            txtNumberOfDice.TextAlign = HorizontalAlignment.Right;
            // 
            // lblDiceRolls
            // 
            lblDiceRolls.BackColor = Color.White;
            lblDiceRolls.BorderStyle = BorderStyle.Fixed3D;
            lblDiceRolls.Location = new Point(48, 103);
            lblDiceRolls.Name = "lblDiceRolls";
            lblDiceRolls.Size = new Size(381, 208);
            lblDiceRolls.TabIndex = 2;
            // 
            // btnRoll
            // 
            btnRoll.AutoSize = true;
            btnRoll.Location = new Point(193, 349);
            btnRoll.Name = "btnRoll";
            btnRoll.Size = new Size(75, 35);
            btnRoll.TabIndex = 3;
            btnRoll.Text = "Dobás";
            btnRoll.UseVisualStyleBackColor = true;
            // 
            // FrmDiceRoller
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 408);
            Controls.Add(btnRoll);
            Controls.Add(lblDiceRolls);
            Controls.Add(txtNumberOfDice);
            Controls.Add(lblQuestion);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5, 5, 5, 5);
            Name = "FrmDiceRoller";
            Text = "Kockadobások";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblQuestion;
        private TextBox txtNumberOfDice;
        private Label lblDiceRolls;
        private Button btnRoll;
    }
}
