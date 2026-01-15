using UnityEngine;
using UnityEngine.UI;

namespace MornLib
{
    [RequireComponent(typeof(Button))]
    public sealed class MornWebOpenURLButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private string _url;

        private void Awake()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDestroy()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        private void Reset()
        {
            _button = GetComponent<Button>();
        }

        private void OnClick()
        {
            MornWebUtil.Open(_url);
        }
    }
}