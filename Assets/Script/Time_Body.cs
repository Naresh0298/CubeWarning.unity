//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Time_Body : MonoBehaviour
//{
    
//	public bool isRewinding = false;
//	Gamecontroller gm;
//	boundary BD;
 
//	List<PointinTime> pointInTime;
//	bool flag = true;

//	Rigidbody rb;
//	MeshRenderer msh;

//	Transform flareone;
    
//	void Start()
//	{
//		pointInTime = new List<PointinTime>();
//		rb = GetComponent<Rigidbody>();
//		gm = FindObjectOfType<Gamecontroller>();
//		BD = FindObjectOfType<boundary>();
//		msh = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshRenderer>();
//		flareone = GameObject.FindGameObjectWithTag("backfire").transform;
//	}
//	private void FixedUpdate()
//	{
//		if (!flag)
//			Rewind();
//		else         
//			Record();	
//	}

//    void Rewind()
//	{
//		if (pointInTime.Count <= 0) return;

//		PointinTime  pointInTimei = pointInTime[0];
//		transform.position = pointInTimei.position;
//		pointInTime.RemoveAt(0);
//	}

//	void Record()
//	{
//		if (pointInTime.Count > Mathf.Round(1.5f / Time.fixedDeltaTime))
//			pointInTime.RemoveAt(pointInTime.Count - 1);
		
//		pointInTime.Insert(0,new PointinTime (transform.position));
//	} 

//	void Update()
//	{      
//		//if (Input.GetKeyUp(KeyCode.Return))
//		if (BD.OnTime == true)
//		{
//			if (flag)
//			{
//				StartRewind();            
//				flag = false;
//				StartCoroutine(RecordEnd());

//			}
//		}
//	}
//	public void StartRewind()
//	{
		
//		isRewinding= true;
//		//GameController.GetComponent<Gamecontroller>().startWait = false;
//    	gm.EndSpawn();
//		rb.velocity = -(rb.velocity);
//		FindObjectOfType<AudioManager>().Play("Rewind");
//    }
//public void EndRewind()
//	{
//		isRewinding= false;      
//		gm.StartSpawn();
//		rb.velocity = -(rb.velocity);
//		msh.enabled = true;
//		flareone.gameObject.SetActive(true);
//		// flaretwo.SetActive(true);
//		BD.sliderinc = 0f;
//		Debug.Log(BD.sliderinc);
//		BD.OnTime= false;

//		//if(flareone.activeSelf==false && flaretwo.activeSelf == false){}
//    }
//	IEnumerator RecordEnd()
//	{
//		yield return new WaitForSeconds(1.5f);
//		EndRewind();
//		flag = true;
//	}   
//}
