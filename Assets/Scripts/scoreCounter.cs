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
            
            collider.gameObject.transform.position = new Vector3(Phisicspuck.SpawnX, Phisicspuck.SpawnY, transform.position.z);
            scoreText.text = (int.Parse(scoreText.text) + 1) + "";
            GetComponent<AudioSource>().PlayOneShot(goalsound);
            collider.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0,0);
            //collider.gameObject.GetComponent<Rigidbody2D>().AddForce(Beat2.lastVelocity * 0);
        }
    }
}
