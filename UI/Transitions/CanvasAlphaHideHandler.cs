#nullable enable

using UnityEngine;

namespace aether.Aether.UI.Transitions
{
    public sealed class CanvasAlphaHideHandler : SimpleHideObjectHandler
    {
        [SerializeField]
        private CanvasGroup _canvasGroup = null!;

        protected override void HideInternal()
            => _canvasGroup.alpha = 0;
    }
}