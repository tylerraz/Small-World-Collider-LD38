using UnityEngine;
using System.Collections;

public class LateralBooster : MonoBehaviour {

    Rigidbody2D myRB;

    [SerializeField]
    private float boostVel;
    
    // Use this for initialization
	void Start () {

        myRB = GetComponent<Rigidbody2D>();

        StartCoroutine(Boost());

	}
	

    IEnumerator Boost()
    {

        

        while (true) {

            float VelSign = myRB.velocity.x;

            myRB.velocity = new Vector2(Mathf.Max(VelSign * 4,myRB.velocity.x), myRB.velocity.y);

            


            yield return new WaitForSeconds(3.0f);

        }

        

    }




}
