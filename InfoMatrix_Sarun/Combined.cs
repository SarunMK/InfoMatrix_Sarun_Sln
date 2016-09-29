using System.ComponentModel;

namespace InfoMatrix_Sarun
{
    /// <summary>
    /// Class used for holding the data of settled and unsettled bets
    /// </summary>
    public class Combined
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
        /// Holds Win Count of settled bets
        /// </summary>
        public int WinCount { get; set; }
        /// <summary>
        /// Holds total count of settled bets
        /// </summary>
        public int TotalBetCount { get; set; }
        /// <summary>
        /// Holds if the customer wins unusually
        /// </summary>
        public bool IsUnusualWin { get; set; }
        /// <summary>
        /// Holds average of settled bets per customer
        /// </summary>
        public double AverageBet { get; set; }
        /// <summary>
        /// Holds average stake of bets per customer
        /// </summary>
        public double AverageStake { get; set; }
        /// <summary>
        /// Holds Event of unsettled bets
        /// </summary>
        [DisplayName("Event")]
        public int UnsettledEvent { get; set; }
        /// <summary>
        /// Holds Participant of unsettled bets
        /// </summary>
        [DisplayName("Participant")]
        public int UnsettledParticipant { get; set; }
        /// <summary>
        /// Holds stake of unsettled bets
        /// </summary>
        [DisplayName("Stake")]
        public int UnsettledStake { get; set; }
        /// <summary>
        /// Holds To Win amount of unsettled bets
        /// </summary>
        [DisplayName("To Win")]
        public int UnsettledWin { get; set; }
        /// <summary>
        /// Holds boolean value if customer is of high risk
        /// </summary>
        public bool UnsettledIsHighRisk { get; set; }
        /// <summary>
        /// Holds boolean value of stake with more than 10 times average bets
        /// </summary>
        public bool UnsettledIsHigher10Stake { get; set; }
        /// <summary>
        /// Holds boolean value of stake with more than 30 times average bets
        /// </summary>
        public bool UnsettledIsHigher30Stake { get; set; }
        /// <summary>
        /// Holds boolean value if stake is more than 1000 dollars
        /// </summary>
        public bool UnsettledIsAmount1000Plus { get; set; }
    }
}
