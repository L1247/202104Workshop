using UnityEngine;
using UnityEngine.UI;

namespace Main
{
    public class Panel_ErrorMessage : MonoBehaviour
    {
        [SerializeField]
        private Button button_ClosePanel;

        public  Text text_ErrorMessage;

        private void Start()
        {
            button_ClosePanel.onClick.AddListener(Close);
        }

        public void SetText(string text)
        {
            text_ErrorMessage.text = text;
        }

        public void Open()
        {
            gameObject.SetActive(true);
        }

        public void Close()
        {
            gameObject.SetActive(false);
        }
    }
}