using Content.Server._Orehum.CustomFactions.Administration;
using Content.Server.EUI;
using Content.Shared.Administration;
using Robust.Shared.Console;

namespace Content.Server.Administration.Commands;

[AdminCommand(AdminFlags.Debug)]
public sealed class CustomFactionPanelCommand : LocalizedCommands
{
    [Dependency] private readonly EuiManager _euis = default!;

    public override string Command => "customfactionpanel";

    public override void Execute(IConsoleShell shell, string argStr, string[] args)
    {
        if (shell.Player == null)
            return;

        var ui = new CustomFactionPanelEui();
        _euis.OpenEui(ui, shell.Player);
    }
}
