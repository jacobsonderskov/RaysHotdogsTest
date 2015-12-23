using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using RaysHotDogs.Core.Model;
using RaysHotDogs.Core.Service;

namespace RaysHotdogs.iOS
{
	partial class HotdogDetailViewController : UIViewController
	{

		public HotDog SelectedHotDog { get;	set; }

		public HotdogDetailViewController (IntPtr handle) : base (handle)
		{
			HotDogDataService service = new HotDogDataService(); 
			SelectedHotDog = service.GetHotDogById(1); 

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			DataBindUI(); 

			AddToCartButton.TouchUpInside += (object sender, EventArgs e) => {
				UIAlertView message = new UIAlertView("title", "message", null, "OK"); 
				message.Show();
				this.DismissModalViewController(true);
			};

			CancelButton.TouchUpInside += (object sender, EventArgs e) => {
				this.DismissModalViewController(true);
			};
		}

		 
		private void DataBindUI()
		{
			UIImage image = UIImage.FromFile("Images/" + SelectedHotDog.ImagePath + ".jpg");
			HotDogImageView.Image = image; 
			NameLabel.Text = SelectedHotDog.Name; 
			ShortDescriptionLabel.Text = SelectedHotDog.ShortDescription; 
			DescriptionText.Text = SelectedHotDog.Description; 
			PriceLabel.Text = "$" + SelectedHotDog.Price.ToString(); 
		}
	}
}
