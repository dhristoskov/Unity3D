using Assets.Scripts;
using UnityEditor;
using UnityEngine;

namespace Assets.EditorScripts
{
    [CustomEditor(typeof(CameraProperties))]
    public class CameraProperiesEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            CameraProperties prop = (CameraProperties) target;

            if (GUILayout.Button("Set max position"))
            {
                prop.SetMaxCamPosition();
            }
            if (GUILayout.Button("Set min position"))
            {
                prop.SetMinCamPosition();
            }
        }	
    }
}
