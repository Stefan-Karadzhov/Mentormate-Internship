using System;
namespace Mentormate
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter grid width and height : ");
                var firstLine = Console.ReadLine();
                string[] elements = firstLine.Split(',');

                int X = Int32.Parse(elements[0]);

                int Y = Int32.Parse(elements[1]);
                if (X <= Y && Y < 1000)
                {
                    Cell[,] cells = new Cell[X, Y];
                    Grid grid = new Grid(X, Y);

                    for (int x = 0; x < X; x++)
                    {

                        for (int y = 0; y < Y; y++)
                        {
                            cells[x, y] = new Cell();
                        }
                    }
                    try
                    {
                        for (int i = 0; i < X; i++)
                        {
                            Console.Write("Enter string with 0 or 1 : ");
                            char[] input = Console.ReadLine().ToCharArray();
                            for (int j = 0; j < Y; j++)
                            {
                                if (Convert.ToInt32(input[j].ToString()) > 1 || Convert.ToInt32(input[j].ToString()) < 0)
                                {
                                    Console.WriteLine("Invalid string input !");
                                    return;
                                }
                                else
                                {
                                    cells[i, j].State = Convert.ToInt32(input[j].ToString());
                                }
                                
                            }
                            Console.WriteLine();
                        }
                    }
                    catch (Exception e)
                    {

                     
                        Console.WriteLine("Invalid string !!");
                        return;
                    }
                    Console.Write("Enter number to search : ");
                    var searchInput = Console.ReadLine();
                    string[] searchElements = searchInput.Split(',');
                    var output = grid.Generations(cells,
                         Int32.Parse(searchElements[0]),
                         Int32.Parse(searchElements[1]),
                         Int32.Parse(searchElements[2]));
                    Console.Write("Result: ");
                    Console.WriteLine(output);
                }
                else
                {

                    Console.WriteLine("Invalid grid width and hight !");
                    return;
                }
            }
            catch (System.IndexOutOfRangeException ix)
            {
                
                Console.WriteLine("Invalid input!!");
                return;
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
    }
}
