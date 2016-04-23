using UnityEngine;

public class Phisicspuck : MonoBehaviour
{
    public GameObject focusObj;
    public EdgeCollider2D walls;
    public AudioClip playerhitsound;
    public AudioClip wallhitsound;
    public static float SpawnX, SpawnY;

    // Use this for initialization
    void Start()
    {
        SpawnX = transform.position.x;
        SpawnY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "beat2")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition(Beat2.lastVelocity * 20000, collision.contacts[0].point);
            GetComponent<AudioSource>().PlayOneShot(playerhitsound);
        }
        if(collision.gameObject.name == "background")
        {
            GetComponent<AudioSource>().PlayOneShot(wallhitsound);
        }
    }
}
