using UnityEngine;

namespace MX.TextureUnpacker
{
    //入口类，兼职处理App的协程
    public class Main : MonoBehaviour
    {
        void Start()
        {
            Application.targetFrameRate = 30;
            Screen.SetResolution(800, 600, false);
            new App(this);
        }


        public void OpenUrl(string url)
        {
            Application.OpenURL(url);
        }
    }

}