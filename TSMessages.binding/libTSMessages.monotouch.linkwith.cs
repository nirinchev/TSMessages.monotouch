using ObjCRuntime;

[assembly: LinkWith ("libTSMessages.monotouch.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, ForceLoad = true)]
