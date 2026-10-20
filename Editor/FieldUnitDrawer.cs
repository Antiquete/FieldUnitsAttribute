using UnityEditor;
using UnityEngine;

namespace Antiquete.FieldUnits
{
    [CustomPropertyDrawer(typeof(FieldUnitAttribute))]
    public class FieldUnitDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect rect, SerializedProperty property, GUIContent label)
        {
            var content = new GUIContent(label);
            content.text += $" ({((FieldUnitAttribute)attribute).Symbol})";
            EditorGUI.PropertyField(rect, property, content, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) =>
            EditorGUI.GetPropertyHeight(property, label, true);
    }
}
