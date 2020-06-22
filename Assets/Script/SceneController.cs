using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	public void PushStartButton()
    {
        SceneManager.LoadScene("SelectScene");
    }
    public void PushOptionButton()
    {
        SceneManager.LoadScene("OptionScene");
    }
    public void PushExitButton()
    {
        Application.Quit();
       
    }
    public void PushStage1()
    {
        SceneManager.LoadScene("SearchScene1");
    }

    public void PushBackButton()
    {
        SceneManager.LoadScene("StartScene");
    }
   
}
