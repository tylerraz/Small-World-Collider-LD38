using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RoundController : MonoBehaviour {


    public bool[] planetFlags;
    public GameObject[] PlanetPrefabs;
    public Transform[] PlanetSpawns;

    //Score Tracking
    [SerializeField]
    private int scoreMultiplier = 0;

    [SerializeField]
    private int planetCount = 0;


    //Panels
    public GameObject SelectionPanel;
    public GameObject CompletePanel;

    //Sub systems

    public InitializeWalls myWalls;


    //Score TextFields

    public Text BlueTeamScore;
    public Text RedTeamScore;
    public Text Taunt;


    public int scoreValue; //set in inspector
    public int[] Scores;

    
    // Use this for initialization
	void Start () {

        for(int i = 0; i < (planetFlags.Length); i++) { planetFlags[i] = false; } //toggles should be set to off in the inspector

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}



    public void selectMercury() { planetFlags[0] = !planetFlags[0]; }
    public void selectVenus() { planetFlags[1] = !planetFlags[1]; }

    public void selectEarth() { planetFlags[2] = !planetFlags[2]; }
    public void selectMars() { planetFlags[3] = !planetFlags[3]; }

    public void selectJupiter() { planetFlags[4] = !planetFlags[4]; }
    public void selectSaturn() { planetFlags[5] = !planetFlags[5]; }

    public void selectUranus() { planetFlags[6] = !planetFlags[6]; }
    public void selectNeptune() { planetFlags[7] = !planetFlags[7]; }

    public void selectPluto() { planetFlags[8] = !planetFlags[8]; }


    public void submitSelections() {

        Debug.Log("Selections Submitted");
        scoreMultiplier = 0;

        for (int i = 0; i < (planetFlags.Length); i++) {

            if (planetFlags[i]) { scoreMultiplier++; }
        }

        Debug.Log("Score Multiplier is" + scoreMultiplier);

        planetCount = scoreMultiplier; //will be used to determine round is over;

        if (scoreMultiplier == 0) { Debug.Log("Must Select A Planet"); return; } // add error panel due to no planets selected

        StartGame();

    }

    private void StartGame() {

        SelectionPanel.SetActive(false);
        Debug.Log("Game Started");

        Scores[0] = 0;
        Scores[1] = 0;

        myWalls.Init();
        PositionPlanets();
        GameCountdown();
        ActivatePlanets();


    }

    private void PositionPlanets() {

        int spawnPos = 0;

        for (int i = 0; i < (planetFlags.Length); i++)
        {

            
            if (planetFlags[i]) {

                Instantiate(PlanetPrefabs[i], PlanetSpawns[spawnPos].position, Quaternion.identity);
                spawnPos++;

            }



        }



    }

    private void GameCountdown() { }

    private void ActivatePlanets() { }



    public void ScorePlanet(int teamNumber)
    {
        //Points go opposite team
        teamNumber = (teamNumber + 1) % 2;

        Scores[teamNumber] += scoreMultiplier * scoreValue;

        planetCount--;

        if (planetCount <= 0) { FinishGame(); }


    }

    private void FinishGame() {

        Debug.Log("BlueTeam " + Scores[0] + ";" + " RedTeam " + Scores[1]);

        BlueTeamScore.text = Scores[0].ToString();
        RedTeamScore.text = Scores[1].ToString();

        CompletePanel.SetActive(true);
        

    }

    public void ResetGame() {

        CompletePanel.SetActive(false);

        SelectionPanel.SetActive(true);


    }



}
