using UnityEngine;
using System.Collections;
using UnityEditor;
public class MyWindows : EditorWindow {
    [MenuItem("Window/myWindow")]
    static void ShowMyWindow() {
        EditorWindow myWin = EditorWindow.GetWindow<MyWindows>();
        myWin.Show();
    }

    private string name = "";
    void OnGUI() {
        GUILayout.Label("我的Labal");
        name= GUILayout.TextField(name);
        if (GUILayout.Button("创建")) {
            GameObject go = new GameObject(name);
            Undo.RegisterCreatedObjectUndo(go, "chuanjain");//把创建的物体写进Unity进程中
        }

    }

}
