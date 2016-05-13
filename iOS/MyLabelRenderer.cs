using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using UIKit;
using Foundation;
using CustomControls;
using CustomControls.iOS;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]

namespace CustomControls.iOS
{
	public class MyLabelRenderer : LabelRenderer
	{
		public MyLabelRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged (e);

			if (Control != null) {
				var attributes = new UIStringAttributes {
					StrikethroughStyle = NSUnderlineStyle.Single,
					StrikethroughColor = UIColor.Red
				};

				Control.AttributedText = new NSAttributedString (Control.Text, attributes);
			}
		}
	}
}

