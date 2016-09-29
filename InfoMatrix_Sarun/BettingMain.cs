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

        /// <summary>
        /// Display Unsettled Bet Information on the UI
        /// </summary>
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

            //Update list with Unusual win information
            //Set the boolean property to true if the customer wins more than 60% of the total bets
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

            //Bind grids
            dgvUnsettledBetHighRisk.DataSource = new List<Combined>(listCombined.Where(x => x.UnsettledIsHighRisk));
            dgvUnsettledBetUnusual.DataSource = new List<Combined>(listCombined.Where(x => x.UnsettledIsHigher10Stake));
            dgvUnsettledBetHighlyUnusual.DataSource = new List<Combined>(listCombined.Where(x => x.UnsettledIsHigher30Stake));
            dgvUnsettledBet1000Plus.DataSource = new List<Combined>(listCombined.Where(x => x.UnsettledIsAmount1000Plus));

            //Format grids
            FormatUnsettledBetHighRiskGrid();
            FormatUnsettledBetUnusualGrid();
            FormatUnsettledBetHighlyUnusualGrid();
            FormatUnsettledBet1000PlusGrid();
        }

        /// <summary>
        /// Format grid of high risk customers
        /// </summary>
        private void FormatUnsettledBetHighRiskGrid()
        {
            dgvUnsettledBetHighRisk.ClearSelection();
            dgvUnsettledBetHighRisk.ReadOnly = true;
            dgvUnsettledBetHighRisk.Columns["WinCount"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["TotalBetCount"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["IsUnusualWin"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["AverageBet"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["AverageStake"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["UnsettledIsHighRisk"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["UnsettledIsHigher10Stake"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["UnsettledIsHigher30Stake"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["UnsettledIsAmount1000Plus"].Visible = false;
            dgvUnsettledBetHighRisk.Columns["CustomerName"].Width = 120;

        }
        
        /// <summary>
        /// Format grid with unusual bets
        /// </summary>
        private void FormatUnsettledBetUnusualGrid()
        {
            dgvUnsettledBetUnusual.ClearSelection();
            dgvUnsettledBetUnusual.ReadOnly = true;
            dgvUnsettledBetUnusual.Columns["WinCount"].Visible = false;
            dgvUnsettledBetUnusual.Columns["TotalBetCount"].Visible = false;
            dgvUnsettledBetUnusual.Columns["IsUnusualWin"].Visible = false;
            dgvUnsettledBetUnusual.Columns["AverageBet"].Visible = false;
            dgvUnsettledBetUnusual.Columns["AverageStake"].Visible = false;
            dgvUnsettledBetUnusual.Columns["UnsettledIsHighRisk"].Visible = false;
            dgvUnsettledBetUnusual.Columns["UnsettledIsHigher10Stake"].Visible = false;
            dgvUnsettledBetUnusual.Columns["UnsettledIsHigher30Stake"].Visible = false;
            dgvUnsettledBetUnusual.Columns["UnsettledIsAmount1000Plus"].Visible = false;
            dgvUnsettledBetUnusual.Columns["CustomerName"].Width = 120;
        }

        /// <summary>
        /// Format grid with high risk bets
        /// </summary>
        private void FormatUnsettledBetHighlyUnusualGrid()
        {
            dgvUnsettledBetHighlyUnusual.ClearSelection();
            dgvUnsettledBetHighlyUnusual.ReadOnly = true;
            dgvUnsettledBetHighlyUnusual.Columns["WinCount"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["TotalBetCount"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["IsUnusualWin"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["AverageBet"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["AverageStake"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["UnsettledIsHighRisk"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["UnsettledIsHigher10Stake"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["UnsettledIsHigher30Stake"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["UnsettledIsAmount1000Plus"].Visible = false;
            dgvUnsettledBetHighlyUnusual.Columns["CustomerName"].Width = 120;
        }

        /// <summary>
        /// Format grid with 1000 dollar plus bets
        /// </summary>
        private void FormatUnsettledBet1000PlusGrid()
        {
            dgvUnsettledBet1000Plus.ClearSelection();
            dgvUnsettledBet1000Plus.ReadOnly = true;
            dgvUnsettledBet1000Plus.Columns["WinCount"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["TotalBetCount"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["IsUnusualWin"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["AverageBet"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["AverageStake"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["UnsettledIsHighRisk"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["UnsettledIsHigher10Stake"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["UnsettledIsHigher30Stake"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["UnsettledIsAmount1000Plus"].Visible = false;
            dgvUnsettledBet1000Plus.Columns["CustomerName"].Width = 120;
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
            dgvSettledBet.Columns["AverageBet"].Visible = false;
            dgvSettledBet.Columns["AverageStake"].Visible = false;
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
