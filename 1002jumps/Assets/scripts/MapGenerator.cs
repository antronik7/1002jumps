using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public GameObject[] section;
    // Use this for initialization
    void Start () {

        int index;
        for (float i = 0; i < 100; i++)
        {
            index = Random.Range(0, 5);

            Instantiate(section[index], new Vector3(0, 0 + (i * 10.5f), 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
