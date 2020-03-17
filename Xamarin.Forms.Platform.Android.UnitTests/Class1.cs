using System;
using System.Threading.Tasks;
using Android.Views;
using NUnit.Framework;

namespace Xamarin.Forms.Platform.Android.UnitTests
{
    public class Class1
    {
    }

	[TestFixture]
	public class RendererTests : PlatformTestFixture
	{
		[Test, Category("Entry")]
		[Description("Validate renderer vertical alignment for Entry with VerticalTextAlignment Center")]
		public async Task EntryVerticalAlignmentCenterInRenderer()
		{
			var entry1 = new Entry { Text = "foo", VerticalTextAlignment = TextAlignment.Center };
			var gravity = await GetControlProperty(entry1, control => control.Gravity);
			var centeredVertical = (gravity & GravityFlags.VerticalGravityMask) == GravityFlags.CenterVertical;
			Assert.That(centeredVertical, Is.True);
		}
	}
}
