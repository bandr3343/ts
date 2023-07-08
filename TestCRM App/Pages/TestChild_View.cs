using Bunit;
using Microsoft.Extensions.DependencyInjection;
using CRM_App.Pages;

namespace TestCRM_App
{
	[Collection("CRM App")]
	public class TestChild_View
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			var componentUnderTest = ctx.RenderComponent<Child_View>();
			Assert.NotNull(componentUnderTest);
		}
	}
}