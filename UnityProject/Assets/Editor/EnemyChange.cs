using UnityEngine;
using System.Collections;
using UnityEditor;
public class EnemyChange : ScriptableWizard {
    [MenuItem("Tools/CreateWizard")]
    static void Changheah() {
        ScriptableWizard.DisplayWizard<EnemyChange>("统一修改敌人","Chang Value And Close","Change");

    }

    public int changeHealthValue = 10;
    public int changeSinkSpeedValue =1;

    const string changehealthValue = "changeHealthValue";
    const string changesinkSpeedValue = "changeSinkSpeedValue";

    //当窗口被调用时
    void OnEnable() {
        changeHealthValue=EditorPrefs.GetInt(changehealthValue, changeHealthValue);
        changeSinkSpeedValue=EditorPrefs.GetInt(changesinkSpeedValue, changeSinkSpeedValue);

    }


    //当默认按钮被点击时
    void OnWizardCreate() {
        Debug.Log("click");
        GameObject[] enmy = Selection.gameObjects;
        EditorUtility.DisplayProgressBar("进度" , "0/" + enmy.Length + "完成修改值" , 0);
        int count = 0;
        foreach (GameObject go in enmy) {
            CompleteProject.EnemyHealth hp = go.GetComponent<CompleteProject.EnemyHealth>();
            Undo.RecordObject(hp, "che xiao");//要在对象前调用,写入Unity进程，能撤销
            hp.startingHealth += changeHealthValue;
            hp.sinkSpeed += changeSinkSpeedValue;
            count++;
            EditorUtility.DisplayProgressBar("进度", count + "/" + enmy.Length + "完成修改值", (float)count / enmy.Length);
        }
        EditorUtility.ClearProgressBar(); //清理进度条
        ShowNotification(new GUIContent(Selection.gameObjects.Length + "个敌人"));

        EditorPrefs.SetInt(changehealthValue, changeHealthValue);
        EditorPrefs.SetInt(changesinkSpeedValue, changeSinkSpeedValue);
    }
    //当调用其他按钮时调用
    void OnWizardOtherButton() {
        OnWizardCreate();


    }
    //当窗口调用是更新用
    void OnWizardUpdate() {

        errorString = null;
        helpString = null;
        if (Selection.gameObjects.Length > 0) {
            helpString = "选择了" + Selection.gameObjects.Length + "个人";
        }
        else{
            errorString="请至少选择一个敌人";
        }
     

    }

    void OnSelectionChange() {
        OnWizardUpdate();

    }




}
