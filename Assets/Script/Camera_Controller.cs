﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {


	public GameObject player;

	private Vector3 Offset;

	// Use this for initialization
	void Start () {
		Offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		
		transform.position = player.transform.position + Offset;
		
	}
}
