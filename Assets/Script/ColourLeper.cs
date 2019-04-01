using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourLeper : MonoBehaviour {

	public float speed = 1.0f;

	public Color startcolor;
	public Color endcolor;
     float startTime;
	public bool repeatable = false;

	void Start () 
	{
		startTime = Time.time;
  
	}
	

	void Update () 
	{
		if (!repeatable)
		{
			float t = (Time.time - startTime) * speed;
			GetComponent<Renderer>().material.color = Color.Lerp(startcolor, endcolor, t);
		}
		else
		{
			float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startcolor, endcolor, t);
		}
	}
}
