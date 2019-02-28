using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIChanger : MonoBehaviour {


    //問題文
    public GameObject QuestionStatement;

    //問題画像
    public GameObject QuestionImage;

    //解答画面
    public GameObject AnswerInputField;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void OnClickTextButton() {

        if (tag == "QuestionStatementButtonTag")
        {
            this.QuestionStatement.SetActive(true);
            this.QuestionImage.SetActive(false);
            this.AnswerInputField.SetActive(false);
        }
        else if (tag == "QuestionImageButtonTag")
        {
            this.QuestionStatement.SetActive(false);
            this.QuestionImage.SetActive(true);
            this.AnswerInputField.SetActive(false);
        }
        else if (tag == "AnswerInputFieldButtonTag")
        {
            if (this.QuestionStatement.activeSelf)
            {
                this.QuestionStatement.SetActive(true);
                this.QuestionImage.SetActive(false);
                this.AnswerInputField.SetActive(true);
            }
            else if (this.QuestionImage.activeSelf)
            {
                this.QuestionStatement.SetActive(false);
                this.QuestionImage.SetActive(true);
                this.AnswerInputField.SetActive(true);
            }
        }

    }


}
