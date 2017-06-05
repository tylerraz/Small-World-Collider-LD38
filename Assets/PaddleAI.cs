using UnityEngine;
using System.Collections;

public class PaddleAI : MonoBehaviour {


    private Rigidbody2D myRB;

    public float boostForce;

    void Start () {
        myRB = GetComponent<Rigidbody2D>();
        StartCoroutine(RandomMove());

	}
	

    public IEnumerator RandomMove()
    {
        while (true) {

            myRB.velocity = Vector2.zero;
            myRB.AddRelativeForce(Vector2.left * boostForce);

            yield return new WaitForSeconds(Random.Range(1.5f,3.0f));

        }

        

    }



}
