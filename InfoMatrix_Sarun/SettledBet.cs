namespace InfoMatrix_Sarun
{
    /// <summary>
    /// Class used for holding Settled Bet - data extracted from CSV file
    /// </summary>
    public class SettledBet
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
        /// Holds Wins for the customer
        /// If value of this field is more than zero, then bet is won
        /// </summary>
        public int Win { get; set; }
    }
}
