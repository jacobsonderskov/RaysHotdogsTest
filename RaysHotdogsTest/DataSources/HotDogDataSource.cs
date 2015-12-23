using System;
using UIKit;
using RaysHotDogs.Core.Model;
using System.Collections.Generic;
using Foundation;

namespace RaysHotdogs.iOS.DataSources
{
	public class HotDogDataSource : UITableViewSource
	{
		private List<HotDog> _hotDogs; 
		NSString cellIdentifier = new NSString("HotDogCell");

		public HotDogDataSource (List<HotDog> hotDogs, UITableViewController callingController)
		{
			_hotDogs = hotDogs; 
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return _hotDogs.Count; 
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier) as UITableViewCell; 

			if(cell == null) {
				cell = new UITableViewCell(UITableViewCellStyle.Default, cellIdentifier);
			}

			var hotDog = _hotDogs[indexPath.Row]; 
			cell.TextLabel.Text = hotDog.Name; 
			cell.ImageView.Image = UIImage.FromFile("Images/hotdog" + hotDog.HotDogId + ".jpg");
			return cell; 
		}
	}
}

