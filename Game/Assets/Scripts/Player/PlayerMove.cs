using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;
    public float Size;
    public float StartDistance;

    // Use this for initialization
    void Start()
    {
        Vector3 position;
        Vector3[] positionArray = new[] {
            new Vector3(StartDistance, StartDistance, 0f),
            new Vector3(StartDistance, -StartDistance, 0f),
            new Vector3(-StartDistance, StartDistance, 0f),
            new Vector3(-StartDistance, -StartDistance, 0f)
        };
        position = positionArray[Random.Range(0, positionArray.Length)];
        transform.position = position;
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
			z += RotationSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
			z -= RotationSpeed * Time.deltaTime;
        }
        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;

        // Auto-forward
        Vector3 pos = transform.position;
		Vector3 velocity = new Vector3(0, Speed * Time.deltaTime, 0);
        pos += rot * velocity;

        transform.position = pos;
    }
}
