using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character : MonoBehaviour {

	public GameObject charac;
	public GameObject head;

	Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		offset = charac.transform.position - head.transform.position + new Vector3(-0.03f,0.8f,0.1f);
		transform.Translate (offset);
	}
}
