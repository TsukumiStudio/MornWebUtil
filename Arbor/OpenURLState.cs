#if !USE_ARBOR
using MornLib;
using System;
#else
using Arbor;
using System;
#endif
using UnityEngine;

namespace MornLib
{
    [Serializable]
#if !USE_ARBOR
    public sealed class OpenURLState : MornStateBehaviour
#else
    public sealed class OpenURLState : StateBehaviour
#endif
    {
        [SerializeField] private string _url;

        public override void OnStateBegin()
        {
            MornWebUtil.Open(_url);
        }
    }
}
