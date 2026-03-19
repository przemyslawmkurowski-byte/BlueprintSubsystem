// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BlueprintSubsystem : ModuleRules
{
	public BlueprintSubsystem(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"BlueprintSubsystem",
			"BlueprintSubsystem/Variant_Platforming",
			"BlueprintSubsystem/Variant_Platforming/Animation",
			"BlueprintSubsystem/Variant_Combat",
			"BlueprintSubsystem/Variant_Combat/AI",
			"BlueprintSubsystem/Variant_Combat/Animation",
			"BlueprintSubsystem/Variant_Combat/Gameplay",
			"BlueprintSubsystem/Variant_Combat/Interfaces",
			"BlueprintSubsystem/Variant_Combat/UI",
			"BlueprintSubsystem/Variant_SideScrolling",
			"BlueprintSubsystem/Variant_SideScrolling/AI",
			"BlueprintSubsystem/Variant_SideScrolling/Gameplay",
			"BlueprintSubsystem/Variant_SideScrolling/Interfaces",
			"BlueprintSubsystem/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
