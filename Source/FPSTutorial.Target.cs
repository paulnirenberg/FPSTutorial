// Copywrite Paul Nirenberg

using UnrealBuildTool;
using System.Collections.Generic;

public class FPSTutorialTarget : TargetRules
{
	public FPSTutorialTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V4;

		ExtraModuleNames.AddRange( new string[] { "FPSTutorial" } );
	}
}
