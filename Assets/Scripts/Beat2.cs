using UnityEngine;

public class Beat2 : MonoBehaviour
{
    public GameObject focusObj;
    public Vector3 lastPos;
    public static Vector2 lastVelocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);

        lastVelocity = focusObj.transform.position - lastPos;
        lastPos = focusObj.transform.position;
        Vector2 mPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        float xPosLimited = Mathf.Clamp(mPos.x, -6.0f, 14.4f);
        float yPosLimited = Mathf.Clamp(mPos.y, -1.22f, 18.1f);
        focusObj.transform.position = Vector2.MoveTowards(focusObj.transform.position, new Vector2(xPosLimited, yPosLimited), 100 * Time.deltaTime);
    }
}


