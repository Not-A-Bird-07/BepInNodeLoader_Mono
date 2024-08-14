using BepInNodeLoader.CustomAttributes;
using Photon.Pun;
using System.Linq;

namespace BepInNodeLoader.Nodes.Room;

public class IsModdedRoom : Node
{
    [IsArgOut]
    public bool IsModded { get; set; }

    public override void Execute()
    {
        IsModded = PhotonNetwork.InRoom && PhotonNetwork.CurrentRoom.CustomProperties.Values.Contains("MODDED");
    }
}
