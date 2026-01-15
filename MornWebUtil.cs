using System.Runtime.InteropServices;
using UnityEngine;

namespace MornLib
{
    public static class MornWebUtil
    {
#if UNITY_WEBGL
        [DllImport("__Internal")]
        private extern static void OpenWindow(string url);
#endif
        public static void Open(string url)
        {
            if (Application.platform == RuntimePlatform.WebGLPlayer)
            {
#if UNITY_WEBGL
                OpenWindow(url);
#endif
            }
            else
            {
#if UNITY_EDITOR
                System.Diagnostics.Process.Start(url);
#else
				Debug.Log ("WebGL以外では実行できません。");
				Debug.Log (url);
#endif
            }
        }
    }
}