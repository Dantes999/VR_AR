using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fischex : MonoBehaviour
{


    public GameObject Fische;
    bool buttonPressed;

    Vector3 pos2;
    Vector3 rot2;


    // Start is called before the first frame update
    void Start()
    {

        pos2 = new Vector3(11, 1, 11);
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
        if (buttonPressed == true)
        {
            if(Fische)
                Fische.transform.position = Vector3.Lerp(Fische.transform.position, pos2, 3 * Time.deltaTime);
            //Fische.transform.rotation = Quaternion.Lerp(Fische.transform.position, Quaternion.Euler(rot2), 3 * Time.deltaTime); 
        }

    }

}
