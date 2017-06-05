using UnityEngine;
using System.Collections;

public class BrickHit : MonoBehaviour {

    [SerializeField]
    private int health;

    public int baseHealth =2;

    public int damageTaken = 1;

    public Color currentColor;

    public Color[] colors; //set on prefab. color 0 equates to 1 health

    public SpriteRenderer mySpRndr;





    public void InitBrick(int layer) {

        //Debug.Log("Brick Created at layer " + layer);
        health = (layer + 1) * baseHealth;

        

        currentColor = colors[health - 1];

        mySpRndr = GetComponent<SpriteRenderer>();
        mySpRndr.color = currentColor;




    }



    private void OnCollisionEnter2D(Collision2D collision)
    {

        //Debug.Log("Collision");

        if (collision.gameObject.tag == "Planet")
        {
            health -= collision.gameObject.GetComponent<StartMovement>().damage;
            HealthCheck();
            return;

        }

        if (collision.gameObject.tag == "Missile")
        {
            health -= damageTaken;
            Destroy(collision.gameObject);
            HealthCheck();
            return;

        }




    }


    private void HealthCheck()
    {

        if (health <=0) { Destroy(gameObject, .1f); }
        else {

            currentColor = colors[health - 1];

            mySpRndr.color = currentColor;

        }

        



    }






}


