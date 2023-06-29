using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Wisej.Web;

namespace Wisej.SAP3DViewer
{
	public class VdsViewer : Widget
	{

		#region Constructor

		/// <summary>
		/// Creates a new instance of <see cref="VdsViewer"/>.
		/// </summary>
		public VdsViewer() : base()
		{
			this.WebRequest += new WebRequestHandler(this.VdsViewer_WebRequest);
		}

		#endregion

		#region Properties

		/// <summary>
		/// Gets or sets the VDS file source.
		/// </summary>
		public string Source 
		{
			get
			{
				return this._source;
			}
			set
			{
				if (this._source != value) 
				{
					this._source = value;

					this.Call("loadFile");
				}
			}
		}
		private string _source;

		#endregion

		#region Wisej.NET Implementation

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override string InitScript
		{
			// disable inlining or we lose the calling assembly in GetResourceString().
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				return GetResourceString("Wisej.SAP3DViewer.JavaScript.Init.js");
			}
			set { }
		}

		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override List<Package> Packages
		{
			get
			{
				if (base.Packages.Count == 0)
				{
					base.Packages.Add(new Package() { 
						Name = "Polyfill",
						Source= "https://cdn.jsdelivr.net/npm/promise-polyfill@8/dist/polyfill.min.js"
					});
					base.Packages.Add(new Package()
					{
						Name = "Loco.js",
						Source = "JavaScript\\Loco.js"
					});
					base.Packages.Add(new Package()
					{
						Name = "DVL.js",
						Source = "JavaScript\\lib\\dvl_asm.js"
					});
				}
				return base.Packages;
			}
		}

		private void VdsViewer_WebRequest(object sender, WebRequestEventArgs e)
		{
			// Wisej.Web.Widget is able to act as a request handler and return any content.
			switch (e.Request["action"])
			{
				case "load":
					e.Response.TransmitFile(this.Source);
					break;
			}
		}

		#endregion

	}
}