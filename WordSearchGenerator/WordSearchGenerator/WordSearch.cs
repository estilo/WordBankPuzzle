using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WordSearchGenerator
{
    public partial class WordSearch : UserControl
    {
        public WordSearch()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
        }
        private Graphics graphics;
        private char[,] currentgrid;
        private bool answers = false;
        
        public void DrawBank(char[,] grid)
        {
            if (graphics != null && this.Width > 0 && this.Height > 0)
            {
                this.currentgrid = (char[,])grid.Clone();
                graphics.Clear(Color.White);
                float boxwidth = this.Width / grid.GetLength(0);
                float boxheight = this.Height / grid.GetLength(1);
                if (boxheight == 0)
                    return;
                Pen basic = new Pen(Brushes.Black, 2);
                Font font = new System.Drawing.Font("Consolas", boxheight);
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    for (int y = 0; y < grid.GetLength(1); y++)
                    {
                        graphics.DrawRectangle(basic, x * boxwidth, y * boxheight, boxwidth, boxheight);
                        char current = grid[x, y];
                        SizeF size = graphics.MeasureString(current.ToString(), font);
                        float centerx = (x * boxwidth) + (boxwidth / 2);
                        float centery = (y * boxheight) + (boxheight / 2);
                        float truex = centerx - (size.Width / 2);
                        float truey = centery - (size.Height / 2);
                        graphics.DrawString(current.ToString(), font, Brushes.Black, truex, truey);

                    }
                }
            }
        }
        public void DrawAnswers(WordBank bank)
        {
            char[,] grid = bank.AnswerKey();
            if (grid == null)
            {
                MessageBox.Show("No generated word search yet!", "Generate first!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                graphics.Clear(Color.White);
                float boxwidth = this.Width / grid.GetLength(0);
                float boxheight = this.Height / grid.GetLength(1);
                Pen basic = new Pen(Brushes.Black, 2);
                Font font = new System.Drawing.Font("Consolas", boxheight);
                for (int x = 0; x < grid.GetLength(0); x++)
                {
                    for (int y = 0; y < grid.GetLength(1); y++)
                    {
                        graphics.DrawRectangle(basic, x * boxwidth, y * boxheight, boxwidth, boxheight);
                        char current = grid[x, y];
                        SizeF size = graphics.MeasureString(current.ToString(), font);
                        float centerx = (x * boxwidth) + (boxwidth / 2);
                        float centery = (y * boxheight) + (boxheight / 2);
                        float truex = centerx - (size.Width / 2);
                        float truey = centery - (size.Height / 2);
                        graphics.DrawString(current.ToString(), font, Brushes.Black, truex, truey);

                    }
                }
            }
        }

        public void ResizeUpdate()
        {
            graphics = this.CreateGraphics();
            
            this.MouseDown += WordSearch_MouseDown;
            this.MouseUp += WordSearch_MouseUp;
            this.MouseMove += WordSearch_MouseMove;
            if (this.currentgrid != null)
                DrawBank(this.currentgrid);
        }
        private bool dragbegin = false;
        private void WordSearch_MouseUp(object sender, MouseEventArgs e)
        {
            dragbegin = false;
        }
        
        private void WordSearch_MouseDown(object sender, MouseEventArgs e)
        {
            dragbegin = true;
        }
        

        private Rectangle prevRectangle;
        private void WordSearch_MouseMove(object sender, MouseEventArgs e)
        {
            if (graphics != null && dragbegin ==true)
            {
                //find x,y belongs toi which coordinate for $currentgrid
                //make a hover ractangle and clearnign previous rectangle created by over
                if (!prevRectangle.IsEmpty)
                    graphics.FillRectangle(Brushes.Transparent, prevRectangle);

                //Pen basic = new Pen(Brushes.Black, 2);
                SolidBrush semiTransBrush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
                prevRectangle = new Rectangle(e.X, e.Y, 50, 50);
                graphics.FillRectangle(semiTransBrush, prevRectangle);

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ResizeUpdate();
        }
        
    }


    //sandeepan:: https://social.msdn.microsoft.com/Forums/vstudio/en-US/194e6db0-c43c-4ba7-8d45-7d33e687c72d/how-to-create-a-grid-draw-straight-lines-on-it?forum=csharpgeneral

}
