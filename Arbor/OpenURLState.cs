#if USE_ARBOR || USE_MORNSTATE
#if USE_MORNSTATE
using MornLib;
using System;
#else
using Arbor;
#endif
using UnityEngine;

namespace MornLib
{
    [Serializable]
#if USE_MORNSTATE
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
#endif
