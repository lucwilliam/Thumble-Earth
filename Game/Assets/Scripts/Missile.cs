using UnityEngine;
using System.Collections;

public class Missile : MonoBehaviour
{
	public GameObject target;
	public float speed;
	public float rotateSpeed;
	Rigidbody2D rb;

	// Use this for initialization
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 point2Target = (Vector2)transform.position - (Vector2)target.transform.position;
		point2Target.Normalize ();
		float value = Vector3.Cross (point2Target, transform.right).z;
//		if (value > 0) {
//			rb.angularVelocity = rotateSpeed * Time.deltaTime;
//		} else if (value < 0)
//			rb.angularVelocity = -rotateSpeed * Time.deltaTime;
//		else
//			rotateSpeed = 0;
		rb.velocity = transform.up * speed * Time.deltaTime;
		rb.angularVelocity = rotateSpeed * value;
	}
}

