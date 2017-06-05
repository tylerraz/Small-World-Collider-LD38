using UnityEngine;
using System.Collections;


public class StartMovement : MonoBehaviour {

    [SerializeField]
    private Rigidbody2D myRB;

    public float moveSpeed;
    public float velThreshold = 1.0f;
    public float torqueAdd = 10.0f;

    public int damage;
    
    // Use this for initialization
	void Start () {

        myRB = GetComponent<Rigidbody2D>();

        InitMove();

	}
	
	
    
    
    
	void FixedUpdate () {

        if (Mathf.Abs(myRB.velocity.y) < velThreshold) { myRB.AddForce(Mathf.Sign(myRB.velocity.y)*Vector2.up * velThreshold); } //vertical boost

        if (myRB.velocity.magnitude < velThreshold) { InitMove(); } //resets movement if object gets stuck

        
	
	}



    void InitMove()
    {

        myRB.angularVelocity = 0;
        Vector2 dir = Random.insideUnitCircle.normalized;

        myRB.velocity=(dir * moveSpeed);

        myRB.AddTorque(torqueAdd);


    }




}




