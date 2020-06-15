using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class EmptyEditorWindow : EditorWindow
{
	[MenuItem("Window/Empty")]
	public static void Open()
	{
		EmptyEditorWindow window = CreateInstance<EmptyEditorWindow>();
		window.titleContent = new GUIContent("Empty");
		window.Show();
	}
}
