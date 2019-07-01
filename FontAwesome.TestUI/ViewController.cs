using Foundation;
using System;
using UIKit;
using static FontAwesomeXamarin.FontAwesome;

namespace FontAwesome.TestUI {
  public partial class ViewController : UIViewController {

    UILabel lblCar;
    UILabel lblAddressCard;
    UILabel lblGlobe;


    public ViewController(IntPtr handle) : base(handle) {
    }

    public override void ViewDidLoad() {
      base.ViewDidLoad();
      // Perform any additional setup after loading the view, typically from a nib.

      lblCar = new UILabel(new CoreGraphics.CGRect(100, 50, 120, 120));
      lblAddressCard = new UILabel(new CoreGraphics.CGRect(100, 300, 120, 120));
      lblGlobe = new UILabel(new CoreGraphics.CGRect(100, 520, 80, 120));

      lblCar.TextColor = UIColor.FromRGB(111, 223, 171);
      lblAddressCard.TextColor = UIColor.FromRGB(166, 133, 247);
      lblGlobe.TextColor = UIColor.FromRGB(229, 64, 113);

      lblCar.Font = FontAwesomeXamarin.FontAwesome.Font(72, FontStyle.Brands);
      lblAddressCard.Font = FontAwesomeXamarin.FontAwesome.Font(72, FontStyle.Solid);
      lblGlobe.Font = FontAwesomeXamarin.FontAwesome.Font(72, FontStyle.Solid);

      lblCar.Text = FontAwesomeXamarin.FontAwesome.Brands.Apple_Pay;
      lblAddressCard.Text = FontAwesomeXamarin.FontAwesome.Solid.Address_Card;
      lblGlobe.Text = FontAwesomeXamarin.FontAwesome.Solid.Pray;

      this.View.AddSubview(lblCar);
      this.View.AddSubview(lblAddressCard);
      this.View.AddSubview(lblGlobe);


    }

    public override void DidReceiveMemoryWarning() {
      base.DidReceiveMemoryWarning();
      // Release any cached data, images, etc that aren't in use.
    }
  }
}