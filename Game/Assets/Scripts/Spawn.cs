using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    // Use this for initialization
    public GameObject[] asteroidList;
    public int          asteroids_number;
    public float minX;
    public float maxX;
    public float minY;
	public float maxY;
    public float minScale;
    public float maxScale;

    private void CreateAst()
    {
        int prefabs = Random.Range(0, 4);
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        prefabs = Random.Range(0, 4);
        float randomScale = Random.Range(minScale, maxScale);
        asteroidList[prefabs].transform.localScale = new Vector3(randomScale, randomScale, 0);
        GameObject tmp = Instantiate(asteroidList[prefabs], new Vector3(x, y, 0), Quaternion.identity);
        if (tmp != null)
          Debug.Log("Instantiated");
    }

    void Start()
    {
        int i;
        i = 0;

        while (i < asteroids_number)
        {
            CreateAst();
            ++i;
        }
    }
}
