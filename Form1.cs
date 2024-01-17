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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar == 'x')
            {

                cell.ForeColor = Color.DarkBlue;
                cell.Value = e.KeyChar;
                cell.Text = e.KeyChar.ToString();

            }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            Choose_Move();
        }
        private bool Is_win(Char player, GameCell[,] current)
        {
           
            for (int i = 0; i < 3; i++)
            {
                if ((current[i, 0].Value == player && current[i, 1].Value == player && current[i, 2].Value == player) || (current[0, i].Value == player && current[1, i].Value == player && current[2, i].Value == player))
                    return true;
            }
            if ((current[0, 0].Value == player && current[1, 1].Value == player && cells[2, 2].Value == player) || (current[0, 2].Value == player && current[1, 1].Value == player && current[2, 0].Value == player))
                return true;
            return false;
        }
        private bool Is_full(GameCell[,] current)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (current[i, j].Value == ' ')
                        return false;
                }
            }
            return true;

        }
        private int? EvaluateBoard(GameCell[,] current)
        { if (Is_win('x',current))
                return -1;
            if (Is_win('o', current))
                return +1;
            if (Is_full(current))
                return 0;
            return null;
        }
        private int AlphaBeta(GameCell[,] current,int alpha, int beta,bool player)
        {   int? score =EvaluateBoard(current);
            if(score.HasValue)
                return score.Value;
            if(player)
            {
                int maxval = int.MinValue;
                for(int i=0; i < 3;i++)
                {   for(int j=0; j < 3; j++)
                    {
                        if (current[i,j].Value==' ')
                        {
                            current[i, j].Value = 'o';
                            int eval=AlphaBeta(current, alpha,beta,false);
                            current[i, j].Value = ' ';
                            if(eval > maxval)
                            maxval= eval;
                            if (eval > alpha)
                                alpha = eval;
                            if (beta <= alpha)
                                break;
                        }

                    }

                }
                return maxval;
            }
            else
            {
               int minval = int.MaxValue;
                for(int i=0; i < 3; i++)
                {   for(int j=0;j<3;j++)
                    {
                        if (current[i,j].Value==' ')
                        {
                            current[i,j].Value = 'x';
                            int eval=AlphaBeta(current, alpha,beta,true);
                            current[i, j].Value = ' ';
                            if (eval < minval)
                                minval = eval;
                            if (eval < alpha)
                                alpha = eval;
                            if (beta <= alpha)
                                break;


                        }

                    }

                }
                return minval;

            }
        }
        
        private void Choose_Move()
        {
            int bestval = int.MinValue;
            Tuple<int, int> bestmove = Tuple.Create(-1, -1);
            for(int i=0; i < 3;i++)
            {   for(int j = 0; j < 3; j++)
                {
                    if (cells[i,j].Value==' ')
                    {
                        cells[i, j].Value = 'o';
                        int moveval=AlphaBeta(cells,int.MinValue,int.MaxValue,false);
                        cells[i, j].Value = ' ';
                        if(moveval>bestval)
                        {
                            bestmove = Tuple.Create(i, j);
                            bestval = moveval;

                        }

                    }

                }
                
            }
            cells[bestmove.Item1, bestmove.Item2].Value = 'o';
            cells[bestmove.Item1, bestmove.Item2].Text = 'o'.ToString() ;
        }
    }

}
