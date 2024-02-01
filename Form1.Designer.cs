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
            panel1 = new Panel();
            button1 = new Button();
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
            button10.Click += button10_Click;
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
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 722);
            panel1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(798, 252);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 722);
            Controls.Add(button1);
            Controls.Add(panel1);
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
        private Panel panel1;
        private Button button1;
    }
}
