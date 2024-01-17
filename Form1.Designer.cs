namespace Tic_Tac_Toe
{
    partial class MainForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Gainsboro;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(220, 220);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.KeyPress += button1_KeyPress;
            // 
            // button2
            // 
            button2.BackColor = Color.Gainsboro;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button2.ForeColor = Color.Red;
            button2.Location = new Point(0, 226);
            button2.Name = "button2";
            button2.Size = new Size(220, 220);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.KeyPress += button2_KeyPress;
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(0, 452);
            button3.Name = "button3";
            button3.Size = new Size(220, 220);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.KeyPress += button3_KeyPress;
            // 
            // button4
            // 
            button4.BackColor = Color.Gainsboro;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.ForeColor = Color.Red;
            button4.Location = new Point(226, 0);
            button4.Name = "button4";
            button4.Size = new Size(220, 220);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.KeyPress += button4_KeyPress;
            // 
            // button5
            // 
            button5.BackColor = Color.Gainsboro;
            button5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button5.ForeColor = Color.Red;
            button5.Location = new Point(226, 226);
            button5.Name = "button5";
            button5.Size = new Size(220, 220);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.KeyPress += button5_KeyPress;
            // 
            // button6
            // 
            button6.BackColor = Color.Gainsboro;
            button6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button6.ForeColor = Color.Red;
            button6.Location = new Point(226, 452);
            button6.Name = "button6";
            button6.Size = new Size(220, 220);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.KeyPress += button6_KeyPress;
            // 
            // button7
            // 
            button7.BackColor = Color.Gainsboro;
            button7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button7.ForeColor = Color.Red;
            button7.Location = new Point(452, 0);
            button7.Name = "button7";
            button7.Size = new Size(220, 220);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.KeyPress += button7_KeyPress;
            // 
            // button8
            // 
            button8.BackColor = Color.Gainsboro;
            button8.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button8.ForeColor = Color.Red;
            button8.Location = new Point(452, 226);
            button8.Name = "button8";
            button8.Size = new Size(220, 220);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.KeyPress += button8_KeyPress;
            // 
            // button9
            // 
            button9.BackColor = Color.Gainsboro;
            button9.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button9.ForeColor = Color.Red;
            button9.Location = new Point(452, 452);
            button9.Name = "button9";
            button9.Size = new Size(220, 220);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.KeyPress += button9_KeyPress;
            // 
            // button10
            // 
            button10.Location = new Point(686, 588);
            button10.Name = "button10";
            button10.Size = new Size(122, 73);
            button10.TabIndex = 9;
            button10.Text = "Play Again";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(686, 493);
            button11.Name = "button11";
            button11.Size = new Size(122, 73);
            button11.TabIndex = 10;
            button11.Text = "Start Game";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(678, 22);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 11;
            label1.Text = "Your Symbol:X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(678, 114);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 12;
            label2.Text = "Player Turn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(678, 152);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 13;
            label3.Text = "Computer Turn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(678, 74);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 14;
            label4.Text = "Turns:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 673);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
