﻿#nullable enable

using UnityEngine;
using UnityEngine.UI;

namespace Aether.UI
{
    public sealed class SimpleProgressBar : MonoBehaviour
    {
        [SerializeField]
        private Image _progress = null!;

        public void SetProgress(float progress)
            => _progress.fillAmount = Mathf.Clamp(progress, 0, 1);
    }
}