using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using Utage;

public class SceneTransition1 : MonoBehaviour
{
    //宴のエンジン
    AdvEngine Engine { get { return engine ?? (engine = FindObjectOfType<AdvEngine>()); } }
    public AdvEngine engine;

    //会話シーンが終わったら、ロードするゲームシーンの名前
    public static string sceneName = "GameSene1";

    //呼び出すシナリオラベル
    //他のシーンから書き換えられるように、staticにする
    public static string scenarioLabel = "";
    
    //最初のフレームで自動再生
    void Start()
    {
        //宴のシナリオ起動
        StartCoroutine(CoTalk());
    }

    IEnumerator CoTalk()
    {
        if (scenarioLabel != "")
        {
           //「宴」のシナリオを呼び出す
            Engine.JumpScenario(scenarioLabel);
        }

        //「宴」のシナリオ終了待ち
        while (!Engine.IsEndScenario)
        {
            yield return 0;
        }

        //シナリオ終了を読み込んだので、シーンを切り替える
        SceneManager.LoadScene("GameScene1");
    }
}