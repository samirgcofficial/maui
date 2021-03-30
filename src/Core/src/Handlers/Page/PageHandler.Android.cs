﻿using System;

namespace Microsoft.Maui.Handlers
{
	public partial class PageHandler : AbstractViewHandler<IPage, PageViewGroup>
	{
		protected override PageViewGroup CreateNativeView()
		{
			if (VirtualView == null)
			{
				throw new InvalidOperationException($"{nameof(VirtualView)} must be set to create a PageViewGroup");
			}

			var viewGroup = new PageViewGroup(Context!)
			{
				CrossPlatformMeasure = VirtualView.Measure,
				CrossPlatformArrange = VirtualView.Arrange
			};

			return viewGroup;
		}

		public override void SetVirtualView(IView view)
		{
			base.SetVirtualView(view);

			_ = TypedNativeView ?? throw new InvalidOperationException($"{nameof(TypedNativeView)} should have been set by base class.");
			_ = VirtualView ?? throw new InvalidOperationException($"{nameof(VirtualView)} should have been set by base class.");
			_ = MauiContext ?? throw new InvalidOperationException($"{nameof(MauiContext)} should have been set by base class.");

			TypedNativeView.CrossPlatformMeasure = VirtualView.Measure;
			TypedNativeView.CrossPlatformArrange = VirtualView.Arrange;

			TypedNativeView.AddView(VirtualView.View.ToNative(MauiContext));
		}
	}
}