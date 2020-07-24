
namespace Mentormate
{
    public class Cell
    {
        public Cell()
        {
            State = 0;
            tempState = 0;
            neighbours = 0;
        }
        public int State { get; set; }

        public int tempState { get; set; }

        public int neighbours { get; set; }

        public int count { get; set; }

    }
}
