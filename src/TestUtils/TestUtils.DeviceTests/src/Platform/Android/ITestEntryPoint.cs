﻿using System.Collections.Generic;
using Microsoft.DotNet.XHarness.TestRunners.Common;

namespace Microsoft.Maui.TestUtils
{
	public interface ITestEntryPoint
	{
		string TestResultsFilename { get; }

		void TerminateWithSuccess();

		TestRunner GetTestRunner(TestRunner testRunner, LogWriter logWriter);

		IEnumerable<TestAssemblyInfo> GetTestAssemblies();
	}
}