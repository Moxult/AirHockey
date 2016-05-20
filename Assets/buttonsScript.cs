using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class buttonsScript : MonoBehaviour {
    public Button switchBtn;
    public string Scene = " ";
    public void changeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
