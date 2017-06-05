using UnityEngine;
using System.Collections;

public class Freeze : MonoBehaviour {


    private Rigidbody2D myRB;

    public float stunFrames;

    private void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }


    public void FreezeIt() {

        StartCoroutine(StunMe());
    }

    private IEnumerator StunMe()
    {
        for (int i = 1; i < stunFrames; i++) {

            myRB.velocity = Vector2.zero;

            yield return new WaitForFixedUpdate();
        }

        





    }



}
