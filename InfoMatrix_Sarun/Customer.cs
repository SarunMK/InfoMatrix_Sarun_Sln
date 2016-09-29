using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMatrix_Sarun
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int WinCount { get; set; }
        public int TotalBetCount { get; set; }
        public bool IsUnusualWin { get; set; }
    }
}
