namespace Wisej.SAP3DViewer
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			Wisej.Core.FileSystemProvider fileSystemProvider1 = new Wisej.Core.FileSystemProvider();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.openFileDialog = new Wisej.Web.OpenFileDialog(this.components);
			this.comboBoxProcedures = new Wisej.Web.ComboBox();
			this.buttonPlay = new Wisej.Web.Button();
			this.comboBoxSteps = new Wisej.Web.ComboBox();
			this.panel1 = new Wisej.Web.Panel();
			this.vdsViewer = new Wisej.SAP3DViewer.VdsViewer();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "VDS (*.vds)|*.vds|All files (*.*)|*.*";
			this.openFileDialog.InitialDirectory = "Project Files";
			fileSystemProvider1.Name = "Project Files";
			fileSystemProvider1.Root = "~\\Samples\\";
			this.openFileDialog.Roots.Add(fileSystemProvider1);
			this.openFileDialog.Title = "Select a VDS file.";
			// 
			// comboBoxProcedures
			// 
			this.comboBoxProcedures.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxProcedures.DisplayMember = "name";
			this.comboBoxProcedures.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxProcedures.Location = new System.Drawing.Point(44, 37);
			this.comboBoxProcedures.Name = "comboBoxProcedures";
			this.comboBoxProcedures.Size = new System.Drawing.Size(510, 30);
			this.comboBoxProcedures.TabIndex = 2;
			this.comboBoxProcedures.ValueMember = "id";
			this.comboBoxProcedures.SelectedIndexChanged += new System.EventHandler(this.comboBoxProcedures_SelectedIndexChanged);
			// 
			// buttonPlay
			// 
			this.buttonPlay.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonPlay.Display = Wisej.Web.Display.Icon;
			this.buttonPlay.Enabled = false;
			this.buttonPlay.ImageSource = "node-closed";
			this.buttonPlay.Location = new System.Drawing.Point(507, 98);
			this.buttonPlay.Name = "buttonPlay";
			this.buttonPlay.Size = new System.Drawing.Size(47, 30);
			this.buttonPlay.TabIndex = 3;
			this.buttonPlay.Text = "Play";
			this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
			// 
			// comboBoxSteps
			// 
			this.comboBoxSteps.Anchor = Wisej.Web.AnchorStyles.None;
			this.comboBoxSteps.DisplayMember = "name";
			this.comboBoxSteps.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxSteps.Location = new System.Drawing.Point(44, 98);
			this.comboBoxSteps.Name = "comboBoxSteps";
			this.comboBoxSteps.Size = new System.Drawing.Size(445, 30);
			this.comboBoxSteps.TabIndex = 4;
			this.comboBoxSteps.ValueMember = "id";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBoxSteps);
			this.panel1.Controls.Add(this.buttonPlay);
			this.panel1.Controls.Add(this.comboBoxProcedures);
			this.panel1.Dock = Wisej.Web.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 359);
			this.panel1.Name = "panel1";
			this.panel1.ShowCloseButton = false;
			this.panel1.ShowHeader = true;
			this.panel1.Size = new System.Drawing.Size(598, 192);
			this.panel1.TabIndex = 6;
			this.panel1.Text = "Play Steps";
			// 
			// vdsViewer
			// 
			this.vdsViewer.AllowDrop = true;
			this.vdsViewer.Dock = Wisej.Web.DockStyle.Fill;
			this.vdsViewer.Name = "vdsViewer";
			this.vdsViewer.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("vdsViewer.ResponsiveProfiles"))));
			this.vdsViewer.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("vdsViewer.ResponsiveProfiles1"))));
			this.vdsViewer.Size = new System.Drawing.Size(598, 359);
			this.vdsViewer.TabIndex = 0;
			this.vdsViewer.Text = "widget1";
			this.vdsViewer.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.vdsViewer_WidgetEvent);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(598, 551);
			this.CloseBox = false;
			this.Controls.Add(this.vdsViewer);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles"))));
			this.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("$this.ResponsiveProfiles1"))));
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "SAP 3D Viewer - Pocket Knife";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private VdsViewer vdsViewer;
		private Web.OpenFileDialog openFileDialog;
		private Web.ComboBox comboBoxProcedures;
		private Web.Button buttonPlay;
		private Web.ComboBox comboBoxSteps;
		private Web.Panel panel1;
	}
}

