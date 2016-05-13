using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using CustomControls;
using CustomControls.Droid;

[assembly: ExportRenderer(typeof(MyLabel), typeof(MyLabelRenderer))]

namespace CustomControls.Droid
{
	public class MyLabelRenderer : LabelRenderer
	{
		public MyLabelRenderer ()
		{
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);

			//Native Renderer in Android
			if (Control != null) {
				Control.Rotation = 180.0f;
			}
		}
	}
}

