﻿#nullable enable
using UnityEngine;

namespace Aether.UI.Transitions
{
    public sealed class CanvasAlphaShowHandler : SimpleShowObjectHandler
    {
        [SerializeField]
        private CanvasGroup _canvasGroup = null!;

        protected override void ShowInternal()
            => _canvasGroup.alpha = 1;
    }
}