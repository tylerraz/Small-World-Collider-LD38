using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlutosRevenge : MonoBehaviour {


    public RoundController myRndCntrlr;
    public PlutoText tauntText;
    public RectTransform myCanvas;



    private void Start()
    {
        myRndCntrlr = FindObjectOfType<RoundController>();
        
        //myCanvas = FindObjectOfType<Canvas>().GetComponent<RectTransform>();

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        string tag = collision.gameObject.tag;

        if(tag == "Planet")
        {

            myRndCntrlr.ScorePlanet(1); //Give the points to the player, why not!

            Destroy(collision.gameObject);

            StopAllCoroutines();
            StartCoroutine(Taunt());





        }

    }


    public IEnumerator Taunt() {

        myRndCntrlr.Taunt.gameObject.SetActive(true);

        yield return new WaitForSeconds(1.0f);

        myRndCntrlr.Taunt.gameObject.SetActive(false);

        yield return null;

    }




}
