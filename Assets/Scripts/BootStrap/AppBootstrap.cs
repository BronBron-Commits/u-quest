using UnityEngine;

namespace UQuest.Bootstrap
{
    public sealed class AppBootstrap : MonoBehaviour
    {
        void Awake()
        {
            Application.targetFrameRate = 72;
            DontDestroyOnLoad(gameObject);
        }
    }
}
