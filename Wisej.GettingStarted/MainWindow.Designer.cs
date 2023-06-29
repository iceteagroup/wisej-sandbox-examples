namespace Wisej.GettingStarted
{
	partial class MainWindow
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
			this.flexLayoutPanel = new Wisej.Web.FlexLayoutPanel();
			this.SuspendLayout();
			// 
			// flexLayoutPanel
			// 
			this.flexLayoutPanel.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.flexLayoutPanel.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel.Location = new System.Drawing.Point(58, 38);
			this.flexLayoutPanel.Name = "flexLayoutPanel";
			this.flexLayoutPanel.Size = new System.Drawing.Size(431, 265);
			this.flexLayoutPanel.TabIndex = 0;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(548, 342);
			this.CloseBox = false;
			this.Controls.Add(this.flexLayoutPanel);
			this.KeepOnScreen = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Main Window";
			this.Load += new System.EventHandler(this.Window1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel;
	}
}
