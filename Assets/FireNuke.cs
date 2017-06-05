using UnityEngine;
using System.Collections;

public class FireNuke : MonoBehaviour {


    public GameObject MissilePrefab;
    public float frequency;


    private void Start()
    {
        StartCoroutine(MissileLaunch());
    }




    IEnumerator MissileLaunch() {

        while (true) {

            Instantiate(MissilePrefab, transform.position, Quaternion.Euler(0, 0, Random.Range(0, 359)));


            yield return new WaitForSeconds(frequency);

        }




    }




}
