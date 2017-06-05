using UnityEngine;
using System.Collections;

public class MissileBoost : MonoBehaviour {

    // Use this for initialization

    private Rigidbody2D myRB;
    public float shotForce;


    void Start () {

        myRB = GetComponent<Rigidbody2D>();

        myRB.AddRelativeForce(Vector2.up * shotForce);


	}


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Bumper" || collision.gameObject.tag == "SideWall") { Destroy(gameObject); }

    }




}
