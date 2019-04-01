 /*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

[System.Serializable]
public class Boundary
{
    //  public float xMin, xMax, yMin, yMax;
}

public class Player_backup : MonoBehaviour
{

    private Rigidbody rb;
    //public float speed = 1f;
    public float tilt;
    //public Boundary boundary;

    private Quaternion defaultRotaiton;

    void Start()
    {
        defaultRotaiton = this.transform.rotation;
        rb = GetComponent<Rigidbody>();
    }

    public Transform player;
    public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

    public Transform circle;
    public Transform outerCircle;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            circle.transform.position = pointA * -1;
            outerCircle.transform.position = pointA * -1;
            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }
        transform.rotation = defaultRotaiton;
        transform.Rotate(new Vector3(5.0f, 0.0f, 0.0f), rb.velocity.y * -tilt);
        transform.Rotate(new Vector3(0.0f, 5.0f, 0.0f), rb.velocity.x * tilt);

    }
    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction * -1);

            circle.transform.position = new Vector2(pointA.x + direction.x, pointA.y + direction.y) * -1;
        }
        else
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
        }

    }
    void moveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }

}




void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 9f),Mathf.Clamp(transform.position.y, -3f, 11),transform.position.z);
        rb.position = new Vector3

            (
            Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),

                Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),
                0.0f);

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {

            Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

            transform.Translate(touchDeltaPosition.x * speed * Time.deltaTime, touchDeltaPosition.y * speed * Time.deltaTime, 0.0f);
            //rb.velocity = touchDeltaPosition.normalized; 

        }
        transform.rotation = defaultRotaiton;
    transform.Rotate(new Vector3(5.0f, 0.0f, 0.0f), rb.velocity.y * -tilt);
    transform.Rotate(new Vector3(0.0f, 5.0f, 0.0f), rb.velocity.x * tilt);
    }
}

// ------------------------------------------------------------------------------------


void Update()
{
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");

    Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0.0f);
    rb.velocity = movement.normalized * speed;



    rb.position = new Vector3

        (
        Mathf.Clamp(rb.position.x, boundary.xMin, boundary.xMax),

            Mathf.Clamp(rb.position.y, boundary.yMin, boundary.yMax),
            0.0f
          );
    transform.rotation = defaultRotaiton;
    transform.Rotate(new Vector3(1.0f, 0.0f, 0.0f), rb.velocity.y * -tilt);
    transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f), rb.velocity.x * tilt);


}
}
*/






