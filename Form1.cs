namespace Tic_Tac_Toe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Key_Pressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as Button;
            

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 'X')
            {
                
                cell.ForeColor = Color.DarkBlue;
                cell.Text =e.KeyChar.ToString();
                //cell.ForeColor = Color.Red;

            }
        
        }
      
    }

}
