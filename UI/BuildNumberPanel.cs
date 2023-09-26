#nullable enable

using TMPro;
using UnityEngine;

namespace Aether.UI
{
    public sealed class BuildNumberPanel : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text _number = null!;

        [SerializeField]
        private RectTransform _layoutTransform = null!;

        private void Awake()
        {
            _number.text = Application.version;
            UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(_layoutTransform);
        }
    }
}