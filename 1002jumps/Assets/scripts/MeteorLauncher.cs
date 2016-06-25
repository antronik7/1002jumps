using UnityEngine;
using System.Collections;

public class MeteorLauncher : MonoBehaviour {

    public GameObject[] meteors;

	// Use this for initialization
	void Start () {
        Invoke("SpawnMeteor", 0.5f);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void SpawnMeteor()
    {
        float randomTime = Random.Range(0.5f, 2);
        int randomIndex = Random.Range(0, meteors.Length);

        Instantiate(meteors[randomIndex]);

        Invoke("SpawnMeteor", randomTime);
    }
}
