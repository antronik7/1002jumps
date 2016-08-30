using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;
    public int Score = 0;
    public int HighScore = 0;
    public int Gold = 0;
    public float speed;
    public bool cinematicStart = false;
    public bool gameStart = false;
    public GameObject player;
    public GameObject explosion;
    public GameObject Menu;
    public GameObject Canvas;
    public GameObject ScoreUI;
    public GameObject MapGenerator;
    public GameObject TutoSpawner;
    public Sprite[] skinsShips;

    GameObject lePlayer;
    GameObject leMenu;
    private int indexShip = 0;

    // Use this for initialization
    void Awake () {
        Application.targetFrameRate = 60;

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
        Menu.SetActive(true);
        //leMenu = Instantiate(Menu) as GameObject;
        //leMenu.transform.position = new Vector3(0, 0, 0);
        //leMenu.transform.SetParent(Canvas.transform);
        
    }

    // Update is called once per frame
    void Update () {
        if(cinematicStart == true && gameStart == false)
        {
            float step = 10 * Time.deltaTime;
            Camera.main.transform.position = Vector3.MoveTowards(Camera.main.transform.position, new Vector3(0, lePlayer.transform.position.y, -10), step);
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

    public void StartGame()
    {
        Score = 0;

        ScoreUI.GetComponent<Animator>().SetTrigger("Enter");

        //Destroy(Menu);
        Menu.SetActive(false);


        MapGenerator.GetComponent<MapGenerator>().FirstGeneration();

        float positionPlayer = MapGenerator.GetComponent<MapGenerator>().LastSpawnPos;

        lePlayer = Instantiate(player, new Vector3(0, positionPlayer - 10, 0), Quaternion.identity) as GameObject;

        lePlayer.GetComponent<SpriteRenderer>().sprite = skinsShips[indexShip];

        Instantiate(TutoSpawner, new Vector3(0, positionPlayer - 10, 0), Quaternion.identity);

        cinematicStart = true;
    }

    public void RestartGame()
    {
        if (Score > HighScore)
        {
            HighScore = Score;
        }

        cinematicStart = false;
        gameStart = false;

        GetComponent<GameplayController>().enabled = false;

        Instantiate(explosion, lePlayer.transform.position, Quaternion.identity);
        Destroy(lePlayer);

        StartCoroutine(SpawnMenu());
        //Application.LoadLevel(Application.loadedLevel);
    }

    IEnumerator SpawnMenu()
    {
        yield return new WaitForSeconds(1);

        Menu.SetActive(true);
    }

    public void changeShip(int i)
    {
        indexShip = i;
    }

    public GameObject getPlayer()
    {
        return lePlayer;
    }
}
