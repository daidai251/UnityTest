using UnityEngine;
using System.Collections;
using UnityEditor;

public class Tools {
    [MenuItem("Tools/test1",false ,1)]
    static void Test() {
        Debug.Log("Test");
    }
    [MenuItem("Tools/MyDelet",false,20)]
    static void Test2()
    {
        //Debug.Log(Selection.transforms);
        Debug.Log(Selection.activeGameObject.name);//选择第一个
        Debug.Log(Selection.objects.Length);
        Debug.Log("Test");

        foreach (Object ob in Selection.objects) {
            //GameObject.Destroy(ob); //编辑模式下用
            //GameObject.DestroyImmediate(ob);

            //Undo 把操作记录写入Unity中，然后能撤回
            Undo.DestroyObjectImmediate(ob);
        }


    }


    [MenuItem("GameObject/MyDelet2", false, 20)]
    static void Test3()
    {
        //Debug.Log(Selection.transforms);
        Debug.Log(Selection.activeGameObject.name);//选择第一个
        Debug.Log(Selection.objects.Length);
        Debug.Log("Test");

        foreach (Object ob in Selection.objects)
        {
            //GameObject.Destroy(ob); //编辑模式下用
            GameObject.DestroyImmediate(ob);
        }


    }


    //%=ctrl  #=shift &=Alt
    [MenuItem("Tools/test2 %a", false, 2)]
    static void Test4()
    {
        Debug.Log("Test");
    }



    }
