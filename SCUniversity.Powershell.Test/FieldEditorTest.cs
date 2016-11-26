using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cognifide.PowerShell.VersionSpecific.Client.Applications;

namespace SCUniversity.Powershell.Test
{
	[TestClass]
	public class FieldEditorTest
	{
		[TestMethod]
		public void CanExecuteBadContext()
		{
			Sitecore.Shell.Framework.Commands.CommandContext context = new Sitecore.Shell.Framework.Commands.CommandContext();
			var fieldEditor = new FieldEditor();
			var canExecute = fieldEditor.CanExecute(context);

			Assert.IsFalse(canExecute);
		}
	}
}
