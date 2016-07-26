using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {

    public GameObject[] section;
    public GameObject motherShip;

    public float LastSpawnPos;
    int index;

    // Use this for initialization
    void Start () {

        
        for (float i = 1; i < 20; i++)
        {
            index = Random.Range(0, 5);

            Instantiate(section[index], new Vector3(0, 20 + (i * 10), 0), Quaternion.identity);
        }
	}
	
	// Update is called once per frame
	void Update () {
	    if(GameManager.instance.gameStart)
        {
            if(LastSpawnPos - Camera.main.transform.position.y < 20)
            {
                index = Random.Range(0, 5);

                Instantiate(section[index], new Vector3(0, LastSpawnPos + 10, 0), Quaternion.identity);
            }
        }
	}
}
