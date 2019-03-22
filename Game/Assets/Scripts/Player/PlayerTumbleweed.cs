using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTumbleweed : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Trigger for 2D collision
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Asteroid tmp;
            Camera cam;
            tmp = other.gameObject.GetComponent(typeof(Asteroid)) as Asteroid;
            cam = gameObject.GetComponentInChildren(typeof(Camera)) as Camera;
            if (tmp != null)
                if (gameObject.transform.localScale.x > tmp.unit)
                {
                    gameObject.transform.localScale += new Vector3(tmp.unit / 20, tmp.unit / 20, 0);
                    other.gameObject.SetActive(false);
                    cam.orthographicSize = cam.orthographicSize + (tmp.unit / 2);
                }
            else
                {
                    gameObject.SetActive(false);
                    SceneManager.LoadScene("Scenes/Menu");
                }
        }
    }
}
