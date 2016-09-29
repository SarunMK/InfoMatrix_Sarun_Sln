namespace InfoMatrix_Sarun
{
    partial class BettingMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSettledBet = new System.Windows.Forms.DataGridView();
            this.lblSettledBet = new System.Windows.Forms.Label();
            this.dgvUnsettledBetHighRisk = new System.Windows.Forms.DataGridView();
            this.dgvUnsettledBetUnusual = new System.Windows.Forms.DataGridView();
            this.dgvUnsettledBetHighlyUnusual = new System.Windows.Forms.DataGridView();
            this.dgvUnsettledBet1000Plus = new System.Windows.Forms.DataGridView();
            this.grpSettled = new System.Windows.Forms.GroupBox();
            this.grpUnsettled = new System.Windows.Forms.GroupBox();
            this.lblHighRisk = new System.Windows.Forms.Label();
            this.lblUnusual = new System.Windows.Forms.Label();
            this.lblHighlyUnusual = new System.Windows.Forms.Label();
            this.lblBet1000 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetHighRisk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetUnusual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetHighlyUnusual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBet1000Plus)).BeginInit();
            this.grpSettled.SuspendLayout();
            this.grpUnsettled.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSettledBet
            // 
            this.dgvSettledBet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettledBet.Location = new System.Drawing.Point(12, 71);
            this.dgvSettledBet.Name = "dgvSettledBet";
            this.dgvSettledBet.RowTemplate.Height = 24;
            this.dgvSettledBet.Size = new System.Drawing.Size(500, 150);
            this.dgvSettledBet.TabIndex = 0;
            this.dgvSettledBet.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSettledBet_DataBindingComplete);
            // 
            // lblSettledBet
            // 
            this.lblSettledBet.AutoSize = true;
            this.lblSettledBet.Location = new System.Drawing.Point(9, 37);
            this.lblSettledBet.Name = "lblSettledBet";
            this.lblSettledBet.Size = new System.Drawing.Size(448, 17);
            this.lblSettledBet.TabIndex = 1;
            this.lblSettledBet.Text = "Customers highlighted in yellow are winning the bet at an unusual rate";
            // 
            // dgvUnsettledBetHighRisk
            // 
            this.dgvUnsettledBetHighRisk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledBetHighRisk.Location = new System.Drawing.Point(12, 52);
            this.dgvUnsettledBetHighRisk.Name = "dgvUnsettledBetHighRisk";
            this.dgvUnsettledBetHighRisk.RowTemplate.Height = 24;
            this.dgvUnsettledBetHighRisk.Size = new System.Drawing.Size(875, 209);
            this.dgvUnsettledBetHighRisk.TabIndex = 2;
            // 
            // dgvUnsettledBetUnusual
            // 
            this.dgvUnsettledBetUnusual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledBetUnusual.Location = new System.Drawing.Point(12, 306);
            this.dgvUnsettledBetUnusual.Name = "dgvUnsettledBetUnusual";
            this.dgvUnsettledBetUnusual.RowTemplate.Height = 24;
            this.dgvUnsettledBetUnusual.Size = new System.Drawing.Size(875, 210);
            this.dgvUnsettledBetUnusual.TabIndex = 3;
            // 
            // dgvUnsettledBetHighlyUnusual
            // 
            this.dgvUnsettledBetHighlyUnusual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledBetHighlyUnusual.Location = new System.Drawing.Point(900, 51);
            this.dgvUnsettledBetHighlyUnusual.Name = "dgvUnsettledBetHighlyUnusual";
            this.dgvUnsettledBetHighlyUnusual.RowTemplate.Height = 24;
            this.dgvUnsettledBetHighlyUnusual.Size = new System.Drawing.Size(875, 210);
            this.dgvUnsettledBetHighlyUnusual.TabIndex = 4;
            // 
            // dgvUnsettledBet1000Plus
            // 
            this.dgvUnsettledBet1000Plus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledBet1000Plus.Location = new System.Drawing.Point(900, 306);
            this.dgvUnsettledBet1000Plus.Name = "dgvUnsettledBet1000Plus";
            this.dgvUnsettledBet1000Plus.RowTemplate.Height = 24;
            this.dgvUnsettledBet1000Plus.Size = new System.Drawing.Size(875, 210);
            this.dgvUnsettledBet1000Plus.TabIndex = 5;
            // 
            // grpSettled
            // 
            this.grpSettled.Controls.Add(this.dgvSettledBet);
            this.grpSettled.Controls.Add(this.lblSettledBet);
            this.grpSettled.Location = new System.Drawing.Point(24, 41);
            this.grpSettled.Name = "grpSettled";
            this.grpSettled.Size = new System.Drawing.Size(544, 236);
            this.grpSettled.TabIndex = 6;
            this.grpSettled.TabStop = false;
            this.grpSettled.Text = "Settled Bet";
            // 
            // grpUnsettled
            // 
            this.grpUnsettled.Controls.Add(this.lblBet1000);
            this.grpUnsettled.Controls.Add(this.lblHighlyUnusual);
            this.grpUnsettled.Controls.Add(this.lblUnusual);
            this.grpUnsettled.Controls.Add(this.dgvUnsettledBet1000Plus);
            this.grpUnsettled.Controls.Add(this.lblHighRisk);
            this.grpUnsettled.Controls.Add(this.dgvUnsettledBetHighlyUnusual);
            this.grpUnsettled.Controls.Add(this.dgvUnsettledBetHighRisk);
            this.grpUnsettled.Controls.Add(this.dgvUnsettledBetUnusual);
            this.grpUnsettled.Location = new System.Drawing.Point(24, 320);
            this.grpUnsettled.Name = "grpUnsettled";
            this.grpUnsettled.Size = new System.Drawing.Size(1790, 540);
            this.grpUnsettled.TabIndex = 7;
            this.grpUnsettled.TabStop = false;
            this.grpUnsettled.Text = "Unsettled Bet";
            // 
            // lblHighRisk
            // 
            this.lblHighRisk.AutoSize = true;
            this.lblHighRisk.Location = new System.Drawing.Point(9, 27);
            this.lblHighRisk.Name = "lblHighRisk";
            this.lblHighRisk.Size = new System.Drawing.Size(330, 17);
            this.lblHighRisk.TabIndex = 8;
            this.lblHighRisk.Text = "Customers who win at unusual rate are given below";
            // 
            // lblUnusual
            // 
            this.lblUnusual.AutoSize = true;
            this.lblUnusual.Location = new System.Drawing.Point(9, 276);
            this.lblUnusual.Name = "lblUnusual";
            this.lblUnusual.Size = new System.Drawing.Size(277, 17);
            this.lblUnusual.TabIndex = 9;
            this.lblUnusual.Text = "Stake with more than 10 times average bet";
            // 
            // lblHighlyUnusual
            // 
            this.lblHighlyUnusual.AutoSize = true;
            this.lblHighlyUnusual.Location = new System.Drawing.Point(897, 20);
            this.lblHighlyUnusual.Name = "lblHighlyUnusual";
            this.lblHighlyUnusual.Size = new System.Drawing.Size(308, 17);
            this.lblHighlyUnusual.TabIndex = 10;
            this.lblHighlyUnusual.Text = "Customers with more than 30 times average bet";
            // 
            // lblBet1000
            // 
            this.lblBet1000.AutoSize = true;
            this.lblBet1000.Location = new System.Drawing.Point(897, 275);
            this.lblBet1000.Name = "lblBet1000";
            this.lblBet1000.Size = new System.Drawing.Size(179, 17);
            this.lblBet1000.TabIndex = 11;
            this.lblBet1000.Text = "Bet more than 1000 dollars";
            // 
            // BettingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1412, 1045);
            this.Controls.Add(this.grpUnsettled);
            this.Controls.Add(this.grpSettled);
            this.Name = "BettingMain";
            this.Text = "Betting Information";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BettingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetHighRisk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetUnusual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBetHighlyUnusual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBet1000Plus)).EndInit();
            this.grpSettled.ResumeLayout(false);
            this.grpSettled.PerformLayout();
            this.grpUnsettled.ResumeLayout(false);
            this.grpUnsettled.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSettledBet;
        private System.Windows.Forms.Label lblSettledBet;
        private System.Windows.Forms.DataGridView dgvUnsettledBetHighRisk;
        private System.Windows.Forms.DataGridView dgvUnsettledBetUnusual;
        private System.Windows.Forms.DataGridView dgvUnsettledBetHighlyUnusual;
        private System.Windows.Forms.DataGridView dgvUnsettledBet1000Plus;
        private System.Windows.Forms.GroupBox grpSettled;
        private System.Windows.Forms.GroupBox grpUnsettled;
        private System.Windows.Forms.Label lblHighRisk;
        private System.Windows.Forms.Label lblBet1000;
        private System.Windows.Forms.Label lblHighlyUnusual;
        private System.Windows.Forms.Label lblUnusual;
    }
}

