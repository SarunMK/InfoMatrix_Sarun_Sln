using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoMatrix_Sarun
{
    /// <summary>
    /// Class used for holding Unsettled Bet - data extracted from CSV file
    /// </summary>
    public class UnsettledBet
    {
        /// <summary>
        /// Holds Customer Id
        /// </summary>
        public int Customer { get; set; }
        /// <summary>
        /// Holds Event Id
        /// </summary>
        public int Event { get; set; }
        /// <summary>
        /// Holds Participant Id
        /// </summary>
        public int Participant { get; set; }
        /// <summary>
        /// Holds Stakes for the customer
        /// </summary>
        public int Stake { get; set; }
        /// <summary>
        /// Holds amount customer would win
        /// </summary>
        public int ToWin { get; set; }
    }
}
