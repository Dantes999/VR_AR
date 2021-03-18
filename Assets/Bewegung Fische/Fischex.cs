using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fischex : MonoBehaviour
{


    public GameObject Fische;
    bool buttonPressed;


    Vector3 pos2;
    Vector3 pos3;
    Vector3 pos4;
    Vector3 pos5;
    Vector3 rot2;

    int a;
    int b;
    int c;
    int d;


    // Start is called before the first frame update
    void Start()
    {

        pos2 = new Vector3(-14, 2, 10);
        pos3 = new Vector3(14, 2, -10);
        pos4 = new Vector3(-10, 2, -10);
        pos5 = new Vector3(-12, 2, 10);
        //rot2 = new Vector3(-90, 90, 0);
        buttonPressed = false;




    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            buttonPressed = true;
        }
        if (buttonPressed == true && a < 100)
        {

            Fische.transform.position = Vector3.Lerp(Fische.transform.position, pos2, 3 * Time.deltaTime);
            a++;

            //Fische.transform.rotation = Quaternion.Lerp(Fische.transform.position, Quaternion.Euler(rot2), 3 * Time.deltaTime);

        }
        else if (buttonPressed == true && b < 100)
        {
            Fische.transform.position = Vector3.Lerp(Fische.transform.position, pos3, 3 * Time.deltaTime);
            b++;
        }
        else if (buttonPressed == true && c < 100)
        {
            Fische.transform.position = Vector3.Lerp(Fische.transform.position, pos4, 3 * Time.deltaTime);
            c++;
        }
        else if (buttonPressed == true && d < 100)
        {
            Fische.transform.position = Vector3.Lerp(Fische.transform.position, pos5, 3 * Time.deltaTime);
            d++;

        }
        else
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
        }




    }

}



