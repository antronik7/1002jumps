using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public GameObject[] section;
    // Use this for initialization
    void Start () {

        int index;
        for (float i = 1; i < 20; i++)
        {
            index = Random.Range(0, 5);

            Instantiate(section[index], new Vector3(0, 20 + (i * 10), 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
