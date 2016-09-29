using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMatrix_Sarun
{
    public class Combined
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int WinCount { get; set; }
        public int TotalBetCount { get; set; }
        public bool IsUnusualWin { get; set; }
        public int UnsettledEvent { get; set; }
        public int UnsettledParticipant { get; set; }
        public int UnsettledStake { get; set; }
        public int UnsettledWin { get; set; }
        public bool UnsettledIsHighRisk { get; set; }
        public bool UnsettledIsHigher10Stake { get; set; }
        public bool UnsettledIsHigher30Stake { get; set; }
        public bool UnsettledIsAmount1000Plus { get; set; }
    }
}
