﻿using System;
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
            string csvSettledFile = Directory.GetCurrentDirectory() + "\\Settled.csv";
            string[] lines = File.ReadAllLines(csvSettledFile);

            var allSettledData = from csvline in lines
                                      let data = csvline.Split(',')
                                      select new SettledBet()
                                      {
                                          Customer = Convert.ToInt32(data[0]),
                                          Event = Convert.ToInt32(data[1]),
                                          Participant = Convert.ToInt32(data[2]),
                                          Stake = Convert.ToInt32(data[3]),
                                          Win = Convert.ToInt32(data[4]),
                                      };

            List<SettledBet> listAllSettledData = allSettledData.ToList();

            var groupSettledBet = from bet in listAllSettledData
                                  group bet by bet.Customer into groupBet
                                  select new Customer
                                  {
                                      CustomerId = groupBet.Key,
                                      WinCount = groupBet.Count(t => t.Win > 0),
                                      TotalBetCount = groupBet.Count(t => t.Win >= 0),
                                      CustomerName = "Customer_" + groupBet.Key.ToString(),
                                  };

            List<Customer> listSettledCustomer = groupSettledBet.ToList();

            dgvSettledBet.DataSource = listSettledCustomer;
        }
    }

    public class SettledBet
    {
        public int Customer { get; set; }
        public int Event { get; set; }
        public int Participant { get; set; }
        public int Stake { get; set; }
        public int Win { get; set; }
    }

    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int WinCount { get; set; }
        public int TotalBetCount { get; set; }
    }
}
