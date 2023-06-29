using System.Collections.Generic;
using Wisej.Web;

namespace Wisej.RealTimeMarket
{
	public partial class Page1 : Page  
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void buttonAdd_Click(object sender, System.EventArgs e)
		{
			AddTicker(this.textBoxSymbol.Text);

			this.textBoxSymbol.Clear();
		}

		private void AddTicker(string symbol)
		{
			this.flowLayoutPanelSymbols.Controls.Add(new Ticker(symbol));
		}

		private void Page1_Appear(object sender, System.EventArgs e)
		{
			AddTicker("AAPL");
		}
	}
}
