using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuControlScript : MonoBehaviour {
    [SerializeField] InputField Input;
    [SerializeField] Text SText;
    // Start is called before the first frame update
    void Start () {

    }

    // Update is called once per frame
    void Update () {
        SText.text = GameApplicationManager.Instance.NameEnter;
    }
    public void StartButtonClick (Button button) {
        SceneManager.LoadScene ("SceneGameplay");
    }
    public void OkButtonClick (Button button) {
        GameApplicationManager.Instance.NameEnter = Input.text.ToString();
        
    }
    public void OptionsButtonClick (Button button) {
        if (!GameApplicationManager.Instance.IsOptionMenuActive) {
            SceneManager.LoadScene ("SceneOptions", LoadSceneMode.Additive);
            GameApplicationManager.Instance.IsOptionMenuActive = true;
        }
    }
    public void ExitButtonClick (Button button) {
        Application.Quit ();
    }

}