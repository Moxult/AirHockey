using UnityEngine;
using System.Collections;

public class Beat1 : MonoBehaviour
{
    public GameObject focusObj;
    public Vector3 lastPos;

    public Vector3 lastVelocity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (!hit)
                return;

            if (hit.transform.gameObject.name == "beat1")
                focusObj = hit.transform.gameObject;
        }
        else if (focusObj && (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)))
        {
            focusObj.GetComponent<Rigidbody2D>().AddForce(lastVelocity * 1000);
            focusObj = null;
        }


        else if (focusObj && ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            Vector3 mPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

            focusObj.transform.position = new Vector3(mPos.x, mPos.y, 0);

            lastVelocity = focusObj.transform.position - lastPos;
            lastPos = focusObj.transform.position;


            
        }


    }
}
