using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using RaysHotDogs.Core.Service;
using RaysHotdogs.iOS.DataSources;

namespace RaysHotdogs.iOS
{
	partial class HotDogTableViewController : UITableViewController
	{
		private HotDogDataService _service = new HotDogDataService(); 

		public HotDogTableViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			var hotDogs = _service.GetAllHotDogs(); 
			var dataSource = new HotDogDataSource(hotDogs, this);

			TableView.Source = dataSource; 

		}
	}
}
