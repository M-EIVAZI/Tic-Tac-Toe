namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Create_Cell();
            //Fill_Empty();
        }
        private GameCell[,] cells = new GameCell[3, 3];
        private void Fill_Empty()
        { for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    cells[i, j].Value = ' ';

        }
        private void Create_Cell()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cells[i, j] = new GameCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(240, 240);
                    cells[i, j].ForeColor = Color.DarkBlue;
                    cells[i, j].Location = new Point(i * 240, j * 240);
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    // Assign key press event for each cells
                    cells[i, j].KeyPress += cell_keyPressed;

                    panel1.Controls.Add(cells[i, j]);
                }
            }
            Fill_Empty();
        }
        private void cell_keyPressed(object sender, KeyPressEventArgs e) 
        {
            var cell = sender as GameCell;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Value = e.KeyChar;
                cell.Text = e.KeyChar.ToString();

            }
        }
        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 0].Value = 'X';

            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 0].Value = 'X';

            }
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 0].Value = 'X';

            }
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 1].Value = 'X';

            }
        }

        private void button7_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 2].Value = 'X';

            }
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 1].Value = 'X';

            }
        }

        private void button8_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 2].Value = 'X';

            }
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 1].Value = 'X';

            }
        }

        private void button9_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 2].Value = 'X';

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
        private bool Is_win(Char player)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if ((cells[i, 0].Value == player && cells[i, 1].Value == player && cells[i, 2].Value == player) || (cells[0, i].Value == player && cells[1, i].Value == player && cells[2, i].Value == player))
                    return true;
            }
            if ((cells[0, 0].Value == player && cells[1, 1].Value == player && cells[2, 2].Value == player) || (cells[0, 2].Value == player && cells[1, 1].Value == player && cells[2, 0].Value == player))
                return true;
            return false;
        }
        private bool Is_full()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cells[i, j].Value == ' ')
                        return true;
                }
            }
            return false;

        }
        private int? EvaluateBoard()
        { if (Is_win('X'))
                return -1;
            if (Is_win('O'))
                return +1;
            if (Is_full())
                return 0;
            return null;
        }


    }

}
