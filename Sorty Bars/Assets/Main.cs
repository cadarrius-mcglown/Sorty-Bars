using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public static int range = 20;
    public static int numOfBars = 15;
    public static GameObject[] arrayOfBars;

    // Use this for initialization
    void Start () {
        //int range = 10;
        arrayOfBars = new GameObject[numOfBars];


        int barHeight;
        int spaces = (numOfBars-1)*(-1);

        for (int i = 0; i < numOfBars; i++)
        {


            barHeight = Random.Range(2, range);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(1, barHeight, 1);
            cube.transform.position = new Vector3(spaces, barHeight/2, 0);

            arrayOfBars[i] = cube;

            spaces = spaces + 2;
        }

        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public  
        bubblesort()
    {
        GameObject[] x = arrayOfBars;
        GameObject temp;
        GameObject leftBar;
        GameObject rightBar;

        int leftBarPosition;
        int rightBarPosition;
        
        for (int i = 0; i < x.Length - 1; i++)
        {

            for (int j = 1; j < x.Length - i; j++)
            {
                if (x[j - 1].transform.localScale.y > x[j].transform.localScale.y)
                {
                    leftBar = x[j - 1];
                    rightBar = x[j];

                    leftBarPosition = (int)leftBar.transform.position.x;
                    rightBarPosition = (int)rightBar.transform.position.x;

                    leftBar.transform.position = Vector3.Lerp(leftBar.transform.position, rightBar.transform.position, .1f);
                    rightBar.transform.position = Vector3.Lerp(rightBar.transform.position, leftBar.transform.position, .1f);




                    temp = x[j - 1];
                    x[j - 1] = x[j];
                    x[j] = temp;

                    
                }
            }
        }
    }
}
