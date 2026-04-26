using UniRx;
using UnityEngine;
using UnityEngine.UI;
using UniRx.Triggers;

namespace MornLib
{
    public sealed class MornWebOpenURLButton : MonoBehaviour
    {
        [SerializeField] private Selectable _button;
        [SerializeField] private string _url;

        private void Awake()
        {
            _button.OnSubmitAsObservable().Subscribe(_ => OnClick()).AddTo(this);
        }

        private void Reset()
        {
            _button = GetComponent<Selectable>();
        }

        private void OnClick()
        {
            MornWebUtil.Open(_url);
        }
    }
}