using UnityEngine;
using System.Collections;

public class ScoreField : MonoBehaviour {

    public int teamNumber;
    
    public RoundController myRndCntrlr;
    
    
    // Use this for initialization
	void Start () {

        
	
	}
	



    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Score! for "+teamNumber);
        if (collision.gameObject.tag == "Planet") {

            myRndCntrlr.ScorePlanet(teamNumber);

            Destroy(collision.gameObject, 0.5f);

        }

    }


}
