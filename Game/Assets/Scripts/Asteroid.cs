using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    // Use this for initialization
    public float unit;
    private float time = 12.0f;

    private void Awake()
    {
        unit = (float)(this.gameObject.transform.localScale.x * 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf == false)
        {
            time -= Time.deltaTime;
            this.gameObject.SetActive(true);
        }
    }
}   