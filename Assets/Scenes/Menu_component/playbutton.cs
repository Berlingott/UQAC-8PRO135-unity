using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playbutton : MonoBehaviour {
    public Button yourButton;
    public LoadingScreenEnter loadingfunction;
    void Start () {
        Button playbutton = yourButton.GetComponent<Button>();
        playbutton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick(){
        Debug.Log ("You have clicked the button!");//call nextscreen script
        loadingfunction.LoadNextLevel();
        
    }
}