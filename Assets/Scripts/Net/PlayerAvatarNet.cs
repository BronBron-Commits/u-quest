using Unity.Netcode;
using UnityEngine;

namespace UQuest.Net
{
    public sealed class PlayerAvatarNet : NetworkBehaviour
    {
        [Header("Tracked Transforms")]
        public Transform head;
        public Transform leftHand;
        public Transform rightHand;

        Transform xrHead;
        Transform xrLeft;
        Transform xrRight;

        public override void OnNetworkSpawn()
        {
            if (!IsOwner) return;

            // Head = Main Camera
            var cam = Camera.main;
            if (cam == null)
            {
                Debug.LogError("Main Camera not found");
                return;
            }

            xrHead = cam.transform;

            // Find controllers by common XR names
            xrLeft = GameObject.Find("LeftHand Controller")?.transform;
            xrRight = GameObject.Find("RightHand Controller")?.transform;

            if (xrLeft == null || xrRight == null)
            {
                Debug.LogError("XR controllers not found in scene");
            }
        }

        void LateUpdate()
        {
            if (!IsOwner || xrHead == null) return;

            head.SetPositionAndRotation(xrHead.position, xrHead.rotation);

            if (xrLeft != null)
                leftHand.SetPositionAndRotation(xrLeft.position, xrLeft.rotation);

            if (xrRight != null)
                rightHand.SetPositionAndRotation(xrRight.position, xrRight.rotation);
        }
    }
}
