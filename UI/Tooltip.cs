#nullable enable
using UnityEngine;

namespace aether.Aether.UI
{
    public abstract class Tooltip : MonoBehaviour
    {
        public abstract string ID { get; }
        public abstract bool IsUnique { get; }
        
        public abstract void Show();
        public abstract void Hide();
    }
}