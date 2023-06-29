using System;
using System.Collections.Generic;
using System.IO;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Wisej.Core;
using Wisej.Web;

namespace Wisej.RealTimeMarket
{
	public class WebSocketClient
	{
		private static string API_KEY = File.ReadAllText(Application.MapPath("API.lic"));

		private static string BASE_URL = "wss://ws.finnhub.io?token=";

		public static event EventHandler<Trade[]> TradeUpdate;

		private static ClientWebSocket _webSocket;

		public static async Task ConnectAsync(string url, Action<string> messageReceivedCallback)
		{
			_webSocket = new ClientWebSocket();
			
			try
			{
				await _webSocket.ConnectAsync(new Uri(url), CancellationToken.None);
				Console.WriteLine("WebSocket connection established.");

				// Start a new task to listen for incoming messages
				_ = Task.Run(async () =>
				{
					byte[] buffer = new byte[1024];
					while (_webSocket.State == WebSocketState.Open)
					{
						var result = await _webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
						if (result.MessageType == WebSocketMessageType.Text)
						{
							var message = Encoding.UTF8.GetString(buffer, 0, result.Count);
							messageReceivedCallback.Invoke(message);
						}
					}
				});
			}
			catch (Exception ex)
			{
				Console.WriteLine($"WebSocket connection failed: {ex.Message}");
			}
		}

		public static async Task SubscribeAsync(string symbol)
		{
			if (_webSocket == null)
			{
				await ConnectAsync($"{BASE_URL}{API_KEY}", (m) => {

					var payload = WisejSerializer.Parse(m);
					switch (payload.type)
					{
						case "trade":
							var data = payload.data;
							var trades = new List<Trade>();
							foreach (var trade in data)
								trades.Add(new Trade(trade.p, trade.s, trade.t, trade.v));

							TradeUpdate?.Invoke(null, trades.ToArray());
							break;
					}
				});
			}

			var subscription = new { type = "subscribe", symbol }.ToJSON();

			await _webSocket.SendAsync(new ArraySegment<byte>(Encoding.UTF8.GetBytes(subscription)), WebSocketMessageType.Text, true, default);
		}
	}
}
