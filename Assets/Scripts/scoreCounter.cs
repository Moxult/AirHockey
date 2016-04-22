using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreCounter : MonoBehaviour {
    public Text scoreText;
    public AudioClip goalsound;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "puck")
        {
            scoreText.text = (int.Parse(scoreText.text) + 1) + "";
            GetComponent<AudioSource>().PlayOneShot(goalsound);
        }
    }
}
