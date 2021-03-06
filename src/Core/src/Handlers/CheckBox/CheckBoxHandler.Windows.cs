﻿using System;
using Microsoft.UI.Xaml.Controls;

namespace Microsoft.Maui.Handlers
{
	public partial class CheckBoxHandler : AbstractViewHandler<ICheckBox, CheckBox>
	{
		protected override CheckBox CreateNativeView() => new CheckBox();
	}
}