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
            button10 = new Button();
            button11 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button10
            // 
            button10.Location = new Point(785, 469);
            button10.Name = "button10";
            button10.Size = new Size(122, 73);
            button10.TabIndex = 9;
            button10.Text = "Play Again";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Location = new Point(785, 352);
            button11.Name = "button11";
            button11.Size = new Size(122, 73);
            button11.TabIndex = 10;
            button11.Text = "Done move";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(763, 32);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 11;
            label1.Text = "Your Symbol:X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(763, 122);
            label2.Name = "label2";
            label2.Size = new Size(109, 28);
            label2.TabIndex = 12;
            label2.Text = "Player Turn";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(763, 163);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 13;
            label3.Text = "Computer Turn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(763, 81);
            label4.Name = "label4";
            label4.Size = new Size(63, 28);
            label4.TabIndex = 14;
            label4.Text = "Turns:";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 722);
            panel1.TabIndex = 15;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 722);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button11);
            Controls.Add(button10);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic-Tac-Toe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button10;
        private Button button11;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
    }
}
