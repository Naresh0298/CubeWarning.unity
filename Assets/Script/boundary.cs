using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boundary : MonoBehaviour
{

	// int triggerScore = 0;

	//public float sliderinc;
    


	Player player;
    


	//public Slider slider;

	//private void Start()
	//{
	//	//triggerScore = 30;
	//	//ms = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>();
	//}

	private void Update()
	{

		//sliderinc = scoresript.scoreValue;
	}//slider.value = sliderinc;
	
	private void OnTriggerEnter(Collider other)
	{
		scoresript.scoreValue += 10;


		//slider.value = scoresript.scoreValue;
        
	//	if (scoresript.scoreValue == triggerScore)
	//	{

	//		Debug.Log("powergot" + triggerScore);
	//		Pickup();
	//}
        

		Destroy(other.gameObject);
	}
    
	//public void PowerProgress()
	//{
        

		//slider.value ++;

		//if(OnTime==false)
		//{
		//	slider.value = 0;
		//}
	//}

 


}

