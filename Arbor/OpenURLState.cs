#if USE_MORNSTATE || USE_ARBOR
#if USE_MORNSTATE
using MornLib;
using StateBehaviour = MornLib.MornStateBehaviour;
#elif USE_ARBOR
using Arbor;
#endif
using System;
using UnityEngine;

namespace MornLib
{
    [Serializable]
    public sealed class OpenURLState : StateBehaviour
    {
        [SerializeField] private string _url;

        public override void OnStateBegin()
        {
            MornWebUtil.Open(_url);
        }
    }
}
#endif // USE_MORNSTATE || USE_ARBOR
