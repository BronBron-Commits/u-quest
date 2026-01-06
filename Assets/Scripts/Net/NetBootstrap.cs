using Unity.Netcode;
using UnityEngine;

namespace UQuest.Net
{
    public sealed class NetBootstrap : MonoBehaviour
    {
        void Start()
        {
            if (!NetworkManager.Singleton.IsClient &&
                !NetworkManager.Singleton.IsServer)
            {
                NetworkManager.Singleton.StartHost();
            }
        }
    }
}
