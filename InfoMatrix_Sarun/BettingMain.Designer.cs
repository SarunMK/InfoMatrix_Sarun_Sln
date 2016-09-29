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
            this.dgvUnsettledBet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSettledBet
            // 
            this.dgvSettledBet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSettledBet.Location = new System.Drawing.Point(128, 109);
            this.dgvSettledBet.Name = "dgvSettledBet";
            this.dgvSettledBet.RowTemplate.Height = 24;
            this.dgvSettledBet.Size = new System.Drawing.Size(500, 150);
            this.dgvSettledBet.TabIndex = 0;
            this.dgvSettledBet.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSettledBet_DataBindingComplete);
            // 
            // lblSettledBet
            // 
            this.lblSettledBet.AutoSize = true;
            this.lblSettledBet.Location = new System.Drawing.Point(128, 60);
            this.lblSettledBet.Name = "lblSettledBet";
            this.lblSettledBet.Size = new System.Drawing.Size(448, 17);
            this.lblSettledBet.TabIndex = 1;
            this.lblSettledBet.Text = "Customers highlighted in yellow are winning the bet at an unusual rate";
            // 
            // dgvUnsettledBet
            // 
            this.dgvUnsettledBet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnsettledBet.Location = new System.Drawing.Point(128, 282);
            this.dgvUnsettledBet.Name = "dgvUnsettledBet";
            this.dgvUnsettledBet.RowTemplate.Height = 24;
            this.dgvUnsettledBet.Size = new System.Drawing.Size(1259, 414);
            this.dgvUnsettledBet.TabIndex = 2;
            // 
            // BettingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 728);
            this.Controls.Add(this.dgvUnsettledBet);
            this.Controls.Add(this.lblSettledBet);
            this.Controls.Add(this.dgvSettledBet);
            this.Name = "BettingMain";
            this.Text = "Betting Information";
            this.Load += new System.EventHandler(this.BettingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnsettledBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSettledBet;
        private System.Windows.Forms.Label lblSettledBet;
        private System.Windows.Forms.DataGridView dgvUnsettledBet;
    }
}

