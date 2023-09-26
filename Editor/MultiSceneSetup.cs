#nullable enable

using UnityEditor.SceneManagement;
using UnityEngine;

namespace Aether.Editor
{
    public class MultiSceneSetup : ScriptableObject
    {
        public SceneSetup[]? Setups;
    }
}