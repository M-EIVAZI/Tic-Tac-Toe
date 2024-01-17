namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Fill_Empty();
        }
        private char[,] cells = new char[3, 3];
        private void Fill_Empty()
        { for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    cells[i, j] = ' ';

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 0] = 'X';

            }
        }

        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 0] = 'X';

            }
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 0] = 'X';

            }
        }

        private void button4_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 1] = 'X';

            }
        }

        private void button7_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[0, 2] = 'X';

            }
        }

        private void button5_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 1] = 'X';

            }
        }

        private void button8_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[1, 2] = 'X';

            }
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 1] = 'X';

            }
        }

        private void button9_KeyPress(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;


            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Text = e.KeyChar.ToString();
                cells[2, 2] = 'X';

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
                if ((cells[i, 0] == player && cells[i, 1] == player && cells[i, 2] == player) || (cells[0, i] == player && cells[1, i] == player && cells[2, i] == player))
                    return true;
            }
            if ((cells[0, 0] == player && cells[1, 1] == player && cells[2, 2] == player) || (cells[0, 2] == player && cells[1, 1] == player && cells[2, 0] == player))
                return true;
            return false;
        }
        private bool Is_full()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cells[i, j] == ' ')
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
