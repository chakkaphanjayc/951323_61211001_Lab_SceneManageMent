using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameplayMenuScript : MonoBehaviour {
    [SerializeField] Button _backButton;
    [SerializeField] Button NextButton;
    [SerializeField] Button NButton;
    [SerializeField] Text SText;
    // Start is called before the first frame update
    void Start () {
        _backButton.onClick.AddListener (delegate { BackToMainMenuButtonClick (_backButton); });
        SText.text = GameApplicationManager.Instance.NameEnter;
    }

    // Update is called once per frame
    void Update () {

    }
    public void BackToMainMenuButtonClick (Button button) {
        SceneManager.LoadScene ("SceneMainMenu");
        SceneManager.UnloadSceneAsync ("SceneGameplay");
        SceneManager.UnloadSceneAsync ("SampleScene");
        SceneManager.UnloadSceneAsync ("Collision Detection Experiments");
    }
        public void NextButtonClick (Button button) {
        SceneManager.UnloadSceneAsync ("SceneGameplay");
        SceneManager.LoadScene ("SampleScene");
    }
        public void NButtonClick (Button button) {
        SceneManager.UnloadSceneAsync ("SampleScene");
        SceneManager.LoadScene ("Collision Detection Experiments");
    }
}