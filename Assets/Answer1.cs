using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answer1 : MonoBehaviour {

    public string correctText1 = (9).ToString();

    public string correctText2 = "９";

    //宴のエンジンがある、会話用のシーンの名前
    public string sceneName = "RudderlessShip";

    public void judgement(string inputText)
    {
        if (correctText1 == inputText || correctText2 == inputText)
        {
            //SceneManager.LoadScene("CorrectAnswer");
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
