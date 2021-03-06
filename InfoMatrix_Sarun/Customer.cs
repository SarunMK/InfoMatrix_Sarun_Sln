﻿using System.ComponentModel;

namespace InfoMatrix_Sarun
{
    /// <summary>
    /// Class used for holding the data specific to a Customer
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Holds Customer Id
        /// </summary>
        [DisplayName("Customer Id")]
        public int CustomerId { get; set; }
        /// <summary>
        /// Holds Customer Name
        /// </summary>
        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        /// <summary>
        /// Holds no of Wins by the customer
        /// </summary>
        public int WinCount { get; set; }
        /// <summary>
        /// Holds the count of total no of bets participated by the customer
        /// </summary>
        public int TotalBetCount { get; set; }
        /// <summary>
        /// Boolean field for holding the Unusual Win
        /// Set to true if the customer is winning at an unusual pace (ie, if he/she wins more than 60% of total bets)
        /// Default is set to false
        /// </summary>
        public bool IsUnusualWin { get; set; }
        public double AverageBet { get; set; }
        public double AverageStake { get; set; }
    }
}
