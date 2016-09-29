using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoMatrix_Sarun
{
    public partial class BettingMain : Form
    {
        //Variables
        List<SettledBet> listAllSettledData = null;
        List<UnsettledBet> listAllUnsettledData = null;
        List<Customer> listSettledCustomer = null;
        List<Combined> listCombined = null;
        string[] lines = null;

        public BettingMain()
        {
            InitializeComponent();
        }

        private void BettingMain_Load(object sender, EventArgs e)
        {
            //Display Settled Bet information 
            SettledBet();
            UnsettledBet();
        }

        /// <summary>
        /// Display Settled Bet Information on the UI
        /// </summary>
        private void SettledBet()
        {
            //Get string array from the file
            lines = GetStringArrayFromFile("Settled.csv");

            //Retrieve all information from the file
            listAllSettledData = (from csvline in lines
                                  let data = csvline.Split(',')
                                  select new SettledBet()
                                  {
                                      Customer = Convert.ToInt32(data[0]),
                                      Event = Convert.ToInt32(data[1]),
                                      Participant = Convert.ToInt32(data[2]),
                                      Stake = Convert.ToInt32(data[3]),
                                      Win = Convert.ToInt32(data[4]),
                                  }).ToList();

            
            //Group all information based on customer
            listSettledCustomer = (from bet in listAllSettledData
                                   group bet by bet.Customer into groupBet
                                   select new Customer
                                   {
                                       CustomerId = groupBet.Key,
                                       WinCount = groupBet.Count(t => t.Win > 0),
                                       TotalBetCount = groupBet.Count(t => t.Win >= 0),
                                       CustomerName = "Customer_" + groupBet.Key.ToString(),
                                       AverageBet = groupBet.Average(t => t.Stake)
                                   }).ToList();

            //Update list with Unusual win information
            //Set the boolean property to true if the customer wins more than 60% of the total bets
            foreach (var item in listSettledCustomer)
            {
                decimal decAvg = (Convert.ToDecimal(item.WinCount) / Convert.ToDecimal(item.TotalBetCount)) * 100;
                if (decAvg > 60)
                    item.IsUnusualWin = true;
            }

            //Bind grid
            dgvSettledBet.DataSource = listSettledCustomer;
        }

        private void UnsettledBet()
        {
            //Get string array from the file
            lines = GetStringArrayFromFile("Unsettled.csv");

            //Retrieve all information from the file
            listAllUnsettledData = (from csvline in lines
                                                   let data = csvline.Split(',')
                                                   select new UnsettledBet()
                                                   {
                                                       Customer = Convert.ToInt32(data[0]),
                                                       Event = Convert.ToInt32(data[1]),
                                                       Participant = Convert.ToInt32(data[2]),
                                                       Stake = Convert.ToInt32(data[3]),
                                                       ToWin = Convert.ToInt32(data[4]),
                                                   }).ToList();


            //Join All Unsettled Data with Settled Customer Data using CustomerId
            listCombined = (from bet in listAllUnsettledData
                                join listCustSet in listSettledCustomer
                                on bet.Customer equals listCustSet.CustomerId
                                select new Combined
                                {
                                    CustomerId = listCustSet.CustomerId,
                                    WinCount = listCustSet.WinCount,
                                    TotalBetCount = listCustSet.TotalBetCount,
                                    CustomerName = listCustSet.CustomerName,
                                    IsUnusualWin = listCustSet.IsUnusualWin,
                                    AverageBet = listCustSet.AverageBet,
                                    AverageStake = listCustSet.AverageStake,
                                    UnsettledEvent = bet.Event,
                                    UnsettledParticipant = bet.Participant,
                                    UnsettledStake = bet.Stake,
                                    UnsettledWin = bet.ToWin,
                                }).ToList();

            foreach (var item in listCombined)
            {
                if (item.IsUnusualWin)
                    item.UnsettledIsHighRisk = true;
                if (item.UnsettledStake > (item.AverageBet * 10))
                    item.UnsettledIsHigher10Stake = true;
                if (item.UnsettledStake > (item.AverageBet * 30))
                    item.UnsettledIsHigher30Stake = true;
                if (item.UnsettledWin > 1000)
                    item.UnsettledIsAmount1000Plus = true;
            }
            dgvUnsettledBet.DataSource = listCombined;
        }

        /// <summary>
        /// Read data from CSV file
        /// </summary>
        /// <param name="fileName">Provide SVC file name</param>
        /// <returns>Returns string array</returns>
        private string[] GetStringArrayFromFile(string fileName)
        {
            //Get and read data from the CSV file
            string csvSettledFile = Directory.GetCurrentDirectory() + "\\" + fileName;
            return File.ReadAllLines(csvSettledFile);
        }

        /// <summary>
        /// DataBindingComplete event of SettledBet grid
        /// Used for formatting the grid rows and cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSettledBet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSettledBet.ClearSelection();
            dgvSettledBet.ReadOnly = true;
            dgvSettledBet.Columns["IsUnusualWin"].Visible = false;
            dgvSettledBet.Columns["WinCount"].Visible = false;
            dgvSettledBet.Columns["TotalBetCount"].Visible = false;
            dgvSettledBet.Columns["CustomerId"].Width = 100;
            dgvSettledBet.Columns["CustomerName"].Width = 200;
            foreach (DataGridViewRow row in dgvSettledBet.Rows)
            {
                //If IsUnusualWin is true, set background color
                if (Convert.ToBoolean(row.Cells["IsUnusualWin"].Value))
                    row.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }

}
