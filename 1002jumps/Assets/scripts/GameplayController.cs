using UnityEngine;
using System.Collections;

public class GameplayController : MonoBehaviour {

    public GameObject controller;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            Vector3 objectPos = Camera.main.ScreenToWorldPoint(mousePos);
            objectPos.z = 0f;

            Instantiate(controller, objectPos, Quaternion.identity);
        }
    }
}
