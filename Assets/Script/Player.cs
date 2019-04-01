
using System.Collections;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float speed;
	public float tilt;  
	public TouchInput touchPad;

	private Rigidbody rb;
    private Quaternion calibrationQuaternion;

    void Start()
    {
		rb = GetComponent<Rigidbody>();
        CalibrateAccelerometer();
    }

      
    //Used to calibrate the Iput.acceleration input
    void CalibrateAccelerometer()
    {
        Vector3 accelerationSnapshot = Input.acceleration;
        Quaternion rotateQuaternion = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), accelerationSnapshot);
        calibrationQuaternion = Quaternion.Inverse(rotateQuaternion);
    }

    //Get the 'calibrated' value from the Input
    Vector3 FixAcceleration(Vector3 acceleration)
    {
        Vector3 fixedAcceleration = calibrationQuaternion * acceleration;
        return fixedAcceleration;
    }

    void FixedUpdate()
    {


        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -9f, 9f), Mathf.Clamp(transform.position.y, -3f, 11), transform.position.z);

        //      float moveHorizontal = Input.GetAxis ("Horizontal");
        //      float moveVertical = Input.GetAxis ("Vertical");

        //      Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
        
        //      Vector3 accelerationRaw = Input.acceleration;
        //      Vector3 acceleration = FixAcceleration (accelerationRaw);
        //      Vector3 movement = new Vector3 (acceleration.x, 0.0f, acceleration.y);

        Vector2 direction = touchPad.GetDirection();
        Vector3 movement = new Vector3(direction.x, direction.y, 0.0f);
        rb.velocity = movement * speed;
  

  
		rb.rotation = Quaternion.Euler(rb.velocity.y * -tilt, 0.0f, rb.velocity.x * -tilt);
    }
}
