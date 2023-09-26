#nullable enable

using UnityEditor.SceneManagement;
using UnityEngine;

namespace aether.Editor.Aether.Editor
{
    public class MultiSceneSetup : ScriptableObject
    {
        public SceneSetup[]? Setups;
    }
}