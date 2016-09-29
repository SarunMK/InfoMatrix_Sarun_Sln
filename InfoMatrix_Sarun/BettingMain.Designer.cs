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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).BeginInit();
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
            // BettingMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 728);
            this.Controls.Add(this.lblSettledBet);
            this.Controls.Add(this.dgvSettledBet);
            this.Name = "BettingMain";
            this.Text = "Betting Information";
            this.Load += new System.EventHandler(this.BettingMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSettledBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSettledBet;
        private System.Windows.Forms.Label lblSettledBet;
    }
}

