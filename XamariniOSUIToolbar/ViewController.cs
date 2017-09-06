using System;

using UIKit;

namespace XamariniOSUIToolbar
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		partial void UIBarButtonItem69_Activated(UIBarButtonItem sender)
		{
			UIAlertView alert = new UIAlertView("Nofication", "Camera Clicked", null, "OK");
			alert.Show();
		}

		partial void UIBarButtonItem45_Activated(UIBarButtonItem sender)
		{
			UIAlertView alert = new UIAlertView("Nofication", "Item Deleted", null, "OK");
			alert.Show();
		}

		partial void UIBarButtonItem70_Activated(UIBarButtonItem sender)
		{
			UIAlertView alert = new UIAlertView("Nofication", "Item Saved", null, "OK");
			alert.Show();
		}

		partial void UIBarButtonItem66_Activated(UIBarButtonItem sender)
		{
			UIAlertView alert = new UIAlertView("Nofication", "Added to bookmark", null, "OK");
			alert.Show();
		}

		partial void UIBarButtonItem65_Activated(UIBarButtonItem sender)
		{
			UIAlertView alert = new UIAlertView("Nofication", "Add a New items", null, "OK");
			alert.Show();
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
