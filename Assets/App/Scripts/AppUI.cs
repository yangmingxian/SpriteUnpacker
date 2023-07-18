using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace NRatel.TextureUnpacker
{
    public class AppUI : MonoBehaviour
    {
        public GameObject m_Go_BigImageBg;
        public Image m_Image_BigImage;
        public TMP_Text m_Text_Tip_New;
        public Button m_Btn_Excute;
        public Dropdown m_Dropdown_SelectMode;
        public Button m_Btn_ContactMe;

        public AppUI Init()
        {
            this.m_Go_BigImageBg.gameObject.SetActive(false);
            this.m_Text_Tip_New.gameObject.SetActive(false);

            this.RegisterEvents();
            return this;
        }

        private void RegisterEvents()
        {

        }

        public void SetTip(string str, bool isError = true)
        {
            this.m_Text_Tip_New.gameObject.SetActive(true);

            string prefix = "<color=#FFB1B1>";
            string postfix = "</color>";
            if (isError == false)
            {
                prefix = "<color=#ADFEFF>";
            }
            this.m_Text_Tip_New.text = prefix + str + postfix;

        }

        public void SetImage(Texture2D texture)
        {
            this.m_Go_BigImageBg.gameObject.SetActive(true);

            Sprite sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.zero);
            this.m_Image_BigImage.sprite = sprite;
            RectTransform rt = this.m_Image_BigImage.GetComponent<RectTransform>();
            rt.sizeDelta = new Vector2(texture.width, texture.height);

            //缩放至屏幕可直接显示的大小
            float minRate = Mathf.Min(642.0f / texture.width, 354.0f / texture.height);
            if (minRate < 1)
            {
                rt.localScale = new Vector2(minRate, minRate);
            }
            else
            {
                rt.localScale = Vector2.one;
            }
        }
    }
}

