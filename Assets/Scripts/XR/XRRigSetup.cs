using UnityEngine;
using UnityEngine.XR;

namespace UQuest.XR
{
    public sealed class XRRigSetup : MonoBehaviour
    {
        void Start()
        {
            XRSettings.eyeTextureResolutionScale = 1.0f;
        }
    }
}
