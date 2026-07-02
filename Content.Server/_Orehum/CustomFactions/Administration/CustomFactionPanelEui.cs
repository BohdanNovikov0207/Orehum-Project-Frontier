using Content.Server.Database;
using Content.Server.EUI;
using Content.Shared._Orehum.CustomFactions.Administration;
using Content.Shared.Eui;

namespace Content.Server._Orehum.CustomFactions.Administration;

public sealed class CustomFactionPanelEui : BaseEui
{
    [Dependency] private IServerDbManager _dbManager = null!;

    private CustomFactionPanelEuiState _state = new();

    public CustomFactionPanelEui()
    {
        IoCManager.InjectDependencies(this);
    }

    public override EuiStateBase GetNewState()
    {
        return _state;
    }

    public override void HandleMessage(EuiMessageBase msg)
    {
        base.HandleMessage(msg);
    }
}
