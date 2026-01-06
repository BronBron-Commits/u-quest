using Unity.Netcode;
using UnityEngine;

namespace UQuest.Net
{
    public sealed class PlayerAvatarNet : NetworkBehaviour
    {
        public Transform head;
        public Transform leftHand;
        public Transform rightHand;

        void Update()
        {
            if (!IsOwner) return;

            transform.position = head.position;
            transform.rotation = head.rotation;
        }
    }
}
