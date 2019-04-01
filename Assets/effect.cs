using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class effect : MonoBehaviour {


	public GameObject SDeffect;


    void effectD()
	{
		
		Instantiate(SDeffect, transform.position, transform.rotation);

        
	}
   
}
