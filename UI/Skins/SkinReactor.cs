#nullable enable

using UnityEngine;

namespace Aether.UI.Skins
{
    public abstract class SkinReactor : MonoBehaviour
    {
        public abstract void ActivateSkin(int skinID);
    }
}