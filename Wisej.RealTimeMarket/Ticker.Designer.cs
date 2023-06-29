namespace Wisej.RealTimeMarket
{
	partial class Ticker
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelPriceTitle = new Wisej.Web.Label();
			this.labelLastPrice = new Wisej.Web.Label();
			this.labelVolumeTitle = new Wisej.Web.Label();
			this.labelUpdatedTitle = new Wisej.Web.Label();
			this.labelVolume = new Wisej.Web.Label();
			this.labelUpdated = new Wisej.Web.Label();
			this.labelSymbol = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// labelPriceTitle
			// 
			this.labelPriceTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelPriceTitle.Location = new System.Drawing.Point(15, 48);
			this.labelPriceTitle.Name = "labelPriceTitle";
			this.labelPriceTitle.Size = new System.Drawing.Size(118, 25);
			this.labelPriceTitle.TabIndex = 2;
			this.labelPriceTitle.Text = "Last Price:";
			// 
			// labelLastPrice
			// 
			this.labelLastPrice.Location = new System.Drawing.Point(139, 48);
			this.labelLastPrice.Name = "labelLastPrice";
			this.labelLastPrice.Size = new System.Drawing.Size(131, 15);
			this.labelLastPrice.TabIndex = 3;
			this.labelLastPrice.Text = "NA";
			// 
			// labelVolumeTitle
			// 
			this.labelVolumeTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelVolumeTitle.Location = new System.Drawing.Point(15, 78);
			this.labelVolumeTitle.Name = "labelVolumeTitle";
			this.labelVolumeTitle.Size = new System.Drawing.Size(118, 25);
			this.labelVolumeTitle.TabIndex = 4;
			this.labelVolumeTitle.Text = "Volume: ";
			// 
			// labelUpdatedTitle
			// 
			this.labelUpdatedTitle.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelUpdatedTitle.Location = new System.Drawing.Point(15, 108);
			this.labelUpdatedTitle.Name = "labelUpdatedTitle";
			this.labelUpdatedTitle.Size = new System.Drawing.Size(118, 25);
			this.labelUpdatedTitle.TabIndex = 5;
			this.labelUpdatedTitle.Text = "Last Updated:";
			// 
			// labelVolume
			// 
			this.labelVolume.Location = new System.Drawing.Point(139, 78);
			this.labelVolume.Name = "labelVolume";
			this.labelVolume.Size = new System.Drawing.Size(131, 15);
			this.labelVolume.TabIndex = 6;
			this.labelVolume.Text = "NA";
			// 
			// labelUpdated
			// 
			this.labelUpdated.Location = new System.Drawing.Point(139, 108);
			this.labelUpdated.Name = "labelUpdated";
			this.labelUpdated.Size = new System.Drawing.Size(131, 15);
			this.labelUpdated.TabIndex = 7;
			this.labelUpdated.Text = "NA";
			// 
			// labelSymbol
			// 
			this.labelSymbol.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.labelSymbol.AutoEllipsis = true;
			this.labelSymbol.Font = new System.Drawing.Font("@windowTitle", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelSymbol.Location = new System.Drawing.Point(15, 18);
			this.labelSymbol.Name = "labelSymbol";
			this.labelSymbol.Size = new System.Drawing.Size(270, 25);
			this.labelSymbol.TabIndex = 1;
			this.labelSymbol.Text = "NA";
			// 
			// Ticker
			// 
			this.BackColor = System.Drawing.Color.FromName("@toolbar");
			this.Controls.Add(this.labelUpdated);
			this.Controls.Add(this.labelVolume);
			this.Controls.Add(this.labelUpdatedTitle);
			this.Controls.Add(this.labelVolumeTitle);
			this.Controls.Add(this.labelLastPrice);
			this.Controls.Add(this.labelPriceTitle);
			this.Controls.Add(this.labelSymbol);
			this.Name = "Ticker";
			this.Size = new System.Drawing.Size(300, 150);
			this.ResumeLayout(false);

		}

		#endregion
		private Web.Label labelPriceTitle;
		private Web.Label labelLastPrice;
		private Web.Label labelVolumeTitle;
		private Web.Label labelUpdatedTitle;
		private Web.Label labelVolume;
		private Web.Label labelUpdated;
		private Web.Label labelSymbol;
	}
}
