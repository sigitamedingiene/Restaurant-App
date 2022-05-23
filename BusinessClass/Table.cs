using System;

namespace BusinessClass
{
    public class Table
    {
        public int Number { get;}
        public int SeatCount { get; set; }
        public Table(int number, int seatCount)
        {
            Number = number;
            SeatCount = seatCount;
        }

    }
}
