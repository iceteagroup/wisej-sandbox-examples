namespace Wisej.RealTimeMarket
{
	partial class Page1
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
			this.flowLayoutPanelSymbols = new Wisej.Web.FlowLayoutPanel();
			this.textBoxSymbol = new Wisej.Web.TextBox();
			this.buttonAdd = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// flowLayoutPanelSymbols
			// 
			this.flowLayoutPanelSymbols.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flowLayoutPanelSymbols.AutoScroll = true;
			this.flowLayoutPanelSymbols.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flowLayoutPanelSymbols.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.flowLayoutPanelSymbols.Location = new System.Drawing.Point(59, 182);
			this.flowLayoutPanelSymbols.Name = "flowLayoutPanelSymbols";
			this.flowLayoutPanelSymbols.Padding = new Wisej.Web.Padding(8);
			this.flowLayoutPanelSymbols.Size = new System.Drawing.Size(1705, 487);
			this.flowLayoutPanelSymbols.TabIndex = 0;
			// 
			// textBoxSymbol
			// 
			this.textBoxSymbol.Location = new System.Drawing.Point(59, 135);
			this.textBoxSymbol.Name = "textBoxSymbol";
			this.textBoxSymbol.Size = new System.Drawing.Size(298, 30);
			this.textBoxSymbol.TabIndex = 1;
			this.textBoxSymbol.Watermark = "Enter Stock Ticker...";
			// 
			// buttonAdd
			// 
			this.buttonAdd.ImageSource = "table-row-new";
			this.buttonAdd.Location = new System.Drawing.Point(372, 135);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(31, 30);
			this.buttonAdd.TabIndex = 2;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxSymbol);
			this.Controls.Add(this.flowLayoutPanelSymbols);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1808, 804);
			this.Appear += new System.EventHandler(this.Page1_Appear);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Web.FlowLayoutPanel flowLayoutPanelSymbols;
		private Web.TextBox textBoxSymbol;
		private Web.Button buttonAdd;
	}
}

