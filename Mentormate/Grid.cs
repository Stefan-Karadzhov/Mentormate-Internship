
namespace Mentormate
{
    using System;
    public class Grid: GridGeneration
    {
        public Grid(int X , int Y)
        {
            this.row = X;
            this.col = Y;
        }
        public int row { get; set; }

        public int col { get; set; }

        public int  Generations(Cell[,] Array,int searchX,int searchY,int N) // make the return value-int and make comments
        {
           
            while (N!=0)
            {
                for (int x = 0; x < row; x++)
                {
                    for (int y = 0; y < col; y++)
                    {
                        if (x == 0 && y == 0)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }

                            if (Array[x, y].State == 1)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }//===
                        if (x == 0 && y > 0 && y < col - 1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3 || Array[x, y].neighbours == 6)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }//==

                        if (x == 0 && y == col-1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }

                            if (Array[x, y].State == 1)
                            {
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }

                        if (x > 0 && x < row - 1 && y == 0)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }

                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }

                        if (x > 0 && x < row - 1 && y == col - 1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }


                        }
                        if (x > 0 && x < row - 1 && y > 0 && y < col - 1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3 || Array[x, y].neighbours == 6)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x + 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3 || Array[x, y].neighbours == 6)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }
                        if (x == row - 1 && y == 0)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3 || Array[x, y].neighbours == 2)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }
                        if (x == row - 1 && y == col - 1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3 || Array[x, y].neighbours == 2)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }

                        if (x == row - 1 && y > 0 && y < col - 1)
                        {
                            if (Array[x, y].State == 0)
                            {
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 3)
                                {
                                    Array[x, y].tempState = 1;
                                }
                            }
                            if (Array[x, y].State == 1)
                            {
                                if (Array[x, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y - 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x - 1, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y + 1].State == 1)
                                {
                                    Array[x, y].neighbours++;
                                }
                                if (Array[x, y].neighbours == 2 || Array[x, y].neighbours == 3 || Array[x, y].neighbours == 6)
                                {
                                    Array[x, y].tempState = 1;
                                }
                                else
                                {
                                    Array[x, y].tempState = 0;
                                }
                            }
                        }
                    }
                }
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        if (i == searchX && j == searchY)
                        {
                            if (Array[i, j].tempState == 1)
                            {
                                Array[i, j].count++;
                            }
                        }
                        if (Array[i, j].tempState == 1)
                        {
                            Array[i, j].State = 1;
                        }
                        if (Array[i, j].tempState == 0)
                        {
                            Array[i, j].State = 0;
                        }
                        Array[i, j].neighbours = 0;
                    }
                }
                N--;
            }
            return Array[searchX,searchY].count;
        }

    }
}
