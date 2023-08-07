using System;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    [CustomEditor(typeof(SpriteRenderer))]
    public class SpriteRendererEditor : UnityEditor.Editor
    {
        private void OnSceneGUI()
        {
            var t = target as SpriteRenderer;
            var transform = t.transform;
            var position = transform.position;
            var size = t.size;

            // Define the size and position of the buttons
            float buttonSize = HandleUtility.GetHandleSize(position) * 0.75f;
            Vector3 buttonPositionPlus = position + new Vector3(0, size.y / 2 + buttonSize, 0);
            Vector3 buttonPositionMinus = position - new Vector3(0, size.y / 2 + buttonSize, 0);

            // Draw the first button at the top with a plus sign
            if (Handles.Button(buttonPositionPlus, Quaternion.identity, buttonSize, buttonSize, Handles.CubeHandleCap))
            {
                // If the first button is pressed, execute the custom command for it
                Debug.Log("Plus button pressed");
            }

            Handles.Label(buttonPositionPlus, "+", new GUIStyle()
            {
                normal = new GUIStyleState()
                {
                    textColor = Color.black,
                },
                fontStyle = FontStyle.Bold,
                fontSize = 72,
                alignment = TextAnchor.MiddleCenter
            });

            // Draw the second button at the bottom with a minus sign
            Handles.color = Color.white;
            if (Handles.Button(buttonPositionMinus, Quaternion.identity, buttonSize, buttonSize, Handles.CubeHandleCap))
            {
                // If the second button is pressed, execute the custom command for it
                Debug.Log("Minus button pressed");
            }

            Handles.Label(buttonPositionMinus, "-", new GUIStyle()
            {
                normal = new GUIStyleState()
                {
                    textColor = Color.black,
                },
                fontStyle = FontStyle.Bold,
                fontSize = 72,
                alignment = TextAnchor.MiddleCenter
            });

            Repaint();
        }
    }
}