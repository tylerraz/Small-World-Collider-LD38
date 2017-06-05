using UnityEngine;
using System.Collections;

public class StunPaddle : MonoBehaviour {






    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bumper")
        {
            collision.gameObject.GetComponent<Freeze>().FreezeIt();

        }

    }




}
