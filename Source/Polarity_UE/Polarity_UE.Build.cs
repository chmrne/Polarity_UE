// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Polarity_UE : ModuleRules
{
	public Polarity_UE(ReadOnlyTargetRules Target) : base(Target)
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
			"Polarity_UE",
			"Polarity_UE/Variant_Horror",
			"Polarity_UE/Variant_Horror/UI",
			"Polarity_UE/Variant_Shooter",
			"Polarity_UE/Variant_Shooter/AI",
			"Polarity_UE/Variant_Shooter/UI",
			"Polarity_UE/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
