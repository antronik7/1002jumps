using UnityEngine;
using System.Collections;

public class PlayButtonController : MonoBehaviour {

    public GameObject Menu;
    public GameObject Score;
    public GameObject But1;
    public GameObject But2;
    public GameObject But3;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void click ()
    {
        GameManager.instance.cinematicStart = true;
        Destroy(But1);
        Destroy(But2);
        Destroy(But3);

        Score.GetComponent<Animator>().SetTrigger("Enter");

        Destroy(Menu);
    }
}
