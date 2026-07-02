using Content.Client.Eui;
using Content.Shared.Eui;
using JetBrains.Annotations;

namespace Content.Client._Orehum.CustomFaction.Administration;

[UsedImplicitly]
public sealed class CustomFactionPanelEui : BaseEui
{
    private CustomFactionPanel _factionPanel;

    public CustomFactionPanelEui()
    {
        _factionPanel = new();
        _factionPanel.OnClose += () => SendMessage(new CloseEuiMessage());
    }

    public override void HandleState(EuiStateBase state)
    {
        base.HandleState(state);
    }

    public override void Opened()
    {
        _factionPanel.OpenCentered();
    }

    public override void Closed()
    {
        _factionPanel.Close();
        _factionPanel.Dispose();
    }
}
