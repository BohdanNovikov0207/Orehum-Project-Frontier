using Content.Shared._Goobstation.Vehicles; // Frontier: migrate under _Goobstation

namespace Content.Server._Goobstation.Vehicles; // Frontier: migrate under _Goobstation

public sealed class VehicleSystem : SharedVehicleSystem
{
    protected override void HandleEmag(Entity<VehicleComponent> ent)
    {
        // Server-side emag handling for vehicles
    }

    protected override void HandleUnemag(Entity<VehicleComponent> ent)
    {
        // Server-side unemag handling for vehicles
    }
}
