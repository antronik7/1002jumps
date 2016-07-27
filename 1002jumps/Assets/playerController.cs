using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

    public GameObject reactor;

    private Vector2 lastPos;
    private Vector2 curPos;


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    void FixedUpdate()
    {
        curPos = transform.position;

        if (curPos == lastPos)
        {
            reactor.SetActive(false);
        }
        else
        {
            reactor.SetActive(true);
        }

        lastPos = curPos;
    }
}
