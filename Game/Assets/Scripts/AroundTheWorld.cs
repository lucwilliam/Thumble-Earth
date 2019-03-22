using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundTheWorld : MonoBehaviour {
	public float Speed;
	public float OriginX;
	public float OriginY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (new Vector3 (OriginX, OriginY, 0f), new Vector3 (0f, 0f, 1f), Speed * Time.deltaTime);
	}
}
