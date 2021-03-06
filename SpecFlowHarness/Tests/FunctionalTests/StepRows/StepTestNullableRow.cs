﻿using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace CIAndT.SpecFlowHarness.FunctionalTests.StepRows
{
	// ReSharper disable BuiltInTypeReferenceStyle
	// ReSharper disable UnusedAutoPropertyAccessor.Local
	[Binding]
	public sealed class StepTestNullableRow : StepRow<StepTestNullableRow>
	{
		// values
		public Int32? NullableInt32Value { get; private set; }

		// lists
		public IReadOnlyCollection<Int32?> NullableInt32Values { get; private set; }
	}
	// ReSharper restore UnusedAutoPropertyAccessor.Local
	// ReSharper restore BuiltInTypeReferenceStyle
}
