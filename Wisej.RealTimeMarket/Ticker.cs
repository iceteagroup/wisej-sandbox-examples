using System;
using Wisej.Web;

namespace Wisej.RealTimeMarket
{
	public partial class Ticker : Wisej.Web.UserControl
	{
		public string Symbol { get; private set; }

		public Ticker()
		{
			InitializeComponent();
		}

		public Ticker(string ticker)
		{
			InitializeComponent();

			Initialize(ticker);
		}

		private async void Initialize(string ticker)
		{
			this.Symbol = ticker;
			this.labelSymbol.Text = ticker;

			WebSocketClient.TradeUpdate += WebSocketClient_TradeUpdate;

			await WebSocketClient.SubscribeAsync(ticker);
		}

		private void WebSocketClient_TradeUpdate(object sender, Trade[] e)
		{
			foreach (var trade in e)
			{
				if (trade.Symbol == this.Symbol)
				{
					this.labelLastPrice.Text = trade.LastPrice.ToString();
					this.labelVolume.Text = trade.Volume.ToString();
					this.labelUpdated.Text = new DateTime((long)trade.Timestamp).ToString();
				}
			}

			Application.Update(this);
		}
	}
}
