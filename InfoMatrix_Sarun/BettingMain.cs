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
        public BettingMain()
        {
            InitializeComponent();
        }

        private void BettingMain_Load(object sender, EventArgs e)
        {
            //Display Settled Bet information 
            SettledBet();
        }

        /// <summary>
        /// Display Settled Bet Information on the UI
        /// </summary>
        private void SettledBet()
        {
            //Get and read data from the CSV file
            string csvSettledFile = Directory.GetCurrentDirectory() + "\\Settled.csv";
            string[] lines = File.ReadAllLines(csvSettledFile);

            //Retrieve all information from the file
            List<SettledBet> listAllSettledData = (from csvline in lines
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
            List<Customer> listSettledCustomer = (from bet in listAllSettledData
                                   group bet by bet.Customer into groupBet
                                   select new Customer
                                   {
                                       CustomerId = groupBet.Key,
                                       WinCount = groupBet.Count(t => t.Win > 0),
                                       TotalBetCount = groupBet.Count(t => t.Win >= 0),
                                       CustomerName = "Customer_" + groupBet.Key.ToString(),
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
        /// DataBindingComplete of SettledBet grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSettledBet_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvSettledBet.Rows)
            {
                //If IsUnusualWin is true, set background color
                if (Convert.ToBoolean(row.Cells["IsUnusualWin"].Value))
                    row.DefaultCellStyle.BackColor = Color.Yellow;
            }
        }
    }

}
