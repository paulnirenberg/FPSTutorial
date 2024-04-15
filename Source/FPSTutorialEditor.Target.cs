// Copywrite Paul Nirenberg

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSTutorialEditorTarget : TargetRules
{
	public FPSTutorialEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "FPSTutorial" } );
	}
}
