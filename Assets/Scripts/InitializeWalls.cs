using UnityEngine;
using System.Collections;

public class InitializeWalls : MonoBehaviour {


    public GameObject brick;
    public Transform[] anchors;

    Vector3 brickStart;
    Vector3 newBrickPos;

    public float height;
    public float width;

    
    // Use this for initialization
	void Start () {


    }

    public void Init() {

        //first clear out other Bricks
        BrickHit[] RemainingBrick = FindObjectsOfType<BrickHit>();

        foreach(BrickHit b in RemainingBrick) { Destroy(b.gameObject); }

        //Fresh Layers, 2 sets

        LayBricks(anchors[0], 12, 3, 1);
        LayBricks(anchors[1], 12, 3, -1);

    }



    void LayBricks(Transform startPoint, int columns, int rows, int dir)
    {

        brickStart = startPoint.position;

        newBrickPos = new Vector3(0, 0, 0);
        


        for (int i = 0; i < rows; i++) {

            newBrickPos.y = brickStart.y + dir*i * height; //dir flips the walls, so they are layered the same by color/health

            for (int j=0; j<columns; j++) {

                newBrickPos.x = brickStart.x + j * width;

                GameObject newBrick = Instantiate(brick, newBrickPos, Quaternion.identity) as GameObject;

                newBrick.transform.parent = this.transform;

                newBrick.GetComponent<BrickHit>().InitBrick(i);


                
            }

                
        }



    }
    

    






}
