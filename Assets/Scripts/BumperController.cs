using UnityEngine;
using System.Collections;

public class BumperController : MonoBehaviour {


    public float moveSpeed;

    public Vector2 myMove;

    public Rigidbody2D myRB;
    
    // Use this for initialization
	void Start () {

        myRB = GetComponent<Rigidbody2D>();

        myMove = new Vector2(0, 0);

	
	}
	





    private void FixedUpdate()
    {

        myMove.x = moveSpeed * Input.GetAxis("Horizontal");

        myRB.AddForce(myMove);


    }




}
