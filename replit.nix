{ pkgs }: {
	deps = [
		pkgs.systemdMinimal
  pkgs.dotnet-sdk
    pkgs.omnisharp-roslyn
	];
}