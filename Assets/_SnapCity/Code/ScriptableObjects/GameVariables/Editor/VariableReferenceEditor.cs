using UnityEditor;

namespace _SnapCity.GameVariables.Editor
{
    [CustomEditor(typeof(GameVariableReference<>))]
    public class VariableReferenceEditor : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            //target
            base.OnInspectorGUI();
        }
    }
}