using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChechk : MonoBehaviour {

	private Rigidbody rb;
	public Transform player;
   // public float speed = 5.0f;
    private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;

	public float speed = 1f;
	public float tilt;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
		
	}
	

    
		void Update()
        {
		

          
            if (Input.GetMouseButtonDown(0))
            {
                pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                                                                    Input.mousePosition.y,
			                                                        Camera.main.transform.position.z));
			
        
            }
		if (Input.GetMouseButton(0))
		{
			touchStart = true;
			pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
																Input.mousePosition.y,
																Camera.main.transform.position.z));
		}

		else
		{
			touchStart = false;
		}

        }
        private void FixedUpdate()
	{
		
	
            if (touchStart)
            {

        
                Vector2 offset = pointB - pointA;


                Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);

                moveCharacter(direction * -1);
            }

        }
        void moveCharacter(Vector2 direction)
        {
		
		

        rb.rotation = Quaternion.Euler(rb.rotation.y * -tilt, 0.0f, rb.rotation.x * -tilt);


		 player.Translate(direction * speed * Time.deltaTime);

  
        }


       


    }

