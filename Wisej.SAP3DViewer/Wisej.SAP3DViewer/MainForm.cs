
using System;
using Wisej.Web;

namespace Wisej.SAP3DViewer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void vdsViewer_WebRequest(object sender, WebRequestEventArgs e)
		{
			// Wisej.Web.Widget is able to act as a request handler and return any content.
			switch (e.Request["action"])
			{
				case "load":
					e.Response.TransmitFile(Application.MapPath("Samples/k.vds"));
					break;
			}
		}

		private async void vdsViewer_WidgetEvent(object sender, WidgetEventArgs e)
		{
			switch (e.Type)
			{
				case "loaded":

					// load the procedures in the combobox once the file is loaded.
					dynamic[] list = await this.vdsViewer.CallAsync("readProcedures");
					this.comboBoxProcedures.Enabled = true;
					this.comboBoxProcedures.Items.Clear();
					this.comboBoxProcedures.Items.AddRange(list);
					if (list.Length > 0)
						this.comboBoxProcedures.SelectedIndex = 0;
					break;

				case "nodeSelected":
					AlertBox.Show($"Selected Node: {e.Data}");
					break;
			}
		}

		private async void comboBoxProcedures_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.comboBoxSteps.Items.Clear();

			if (this.comboBoxProcedures.SelectedIndex > -1)
			{
				// load the steps in the combobox when a procedure is selected.
				dynamic[] list = await this.vdsViewer.CallAsync("readSteps", ((dynamic)this.comboBoxProcedures.SelectedItem).id);
				this.buttonPlay.Enabled = true;
				this.comboBoxSteps.Enabled = true;
				this.comboBoxSteps.Items.AddRange(list);
			}
		}

		private void buttonPlay_Click(object sender, EventArgs e)
		{
			if (this.comboBoxSteps.SelectedIndex  > -1)
				this.vdsViewer.Call("playStep", ((dynamic)this.comboBoxSteps.SelectedItem).id);
		}

		private void MainForm_Appear(object sender, EventArgs e)
		{
			// when the widget appears on the client, load the vds file.
			this.vdsViewer.Call("loadFile", "*");
		}
	}
}
