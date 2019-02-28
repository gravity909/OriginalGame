using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Utage;

public class SceneTransition1to2 : MonoBehaviour {

    //宴のエンジンがある、会話用のシーンの名前
    public string sceneName = "RudderlessShip";


    // Update is called once per frame
    void Update()
    {
        // 左クリックされた瞬間にif文の中を実行
        if (Input.GetMouseButtonDown(0))
        {
            ChangeScene("Chapter1");
            
        }
    }

    //宴のシーンに切り替えて、指定のシナリオを開始する
    public void ChangeScene(string scenarioLabel)
    {
        SceneTransition1.scenarioLabel = scenarioLabel;
        //宴のある会話シーンに切り替える
        SceneManager.LoadScene(sceneName);
    }
}

