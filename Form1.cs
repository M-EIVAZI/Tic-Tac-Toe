namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private char[,] cells = new char[3, 3];


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
        //private Is_full
    }

}
