namespace Wisej.RealTimeMarket
{
	public class Trade
	{
		public Trade(double lastPrice, string symbol, double timestamp, double volume)
		{
			LastPrice = lastPrice;
			Symbol = symbol;
			Timestamp = timestamp;
			Volume = volume;
		}

		public double LastPrice { get; set; }

		public string Symbol { get; set; }

		public double Timestamp { get; set; }

		public double Volume { get; set; }
	}
}
