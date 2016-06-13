using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int Score = 0;
    public int HighScore = 0;
    public int Gold = 0;
    public bool cinematicStart = false;
    public GameObject player;

    // Use this for initialization
    void Awake () {
        RestScore();
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
        Score = 0;
    }

    // Update is called once per frame
    void Update () {
        if(cinematicStart)
        {
            Debug.Log("Allo");
            float step = 10 * Time.deltaTime;
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(0, 20, -10), step);
        }
	}

    public void RestScore()
    {
        if(Score > HighScore)
        {
            HighScore = Score;
        }

        Score = 0;
    }
}
