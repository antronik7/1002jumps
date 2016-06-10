using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int Score = 0;
    public int HighScore = 0;

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
