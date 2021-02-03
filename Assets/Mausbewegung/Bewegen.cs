using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bewegen : MonoBehaviour
{
    GameObject ob;
    GameObject privot;
    bool iss;
    float dis;


    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if (Input.GetButton("fire1"))
        {
            if (Physics.Raycast(Camera.mainScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject != null && hit.collider.isTrigger && !hit.collider.CompareTag("Terrain"))
                {
                    if (!iss)
                    {
                        iss = true;
                        ob = hit.collider.gameObject;
                        ob.transform.gameObject.layer = 2;
                        privot = new GameObject("pivot");
                        Vector3 s = Vector3.Scale(ob.transform.localScale, ob.GetComponent<MeshFilter>().mesh.bounds.size);
                        dis = s.y / 2;
                        privot.transform.position = new Vector3(ob.transform.position.x, ob.transform.position.y - dis, ob.transform.position.z);
                        ob.transform.parent = privot.transform;
                    }
                }
            }

        }
        else
        {
            if(ob = !null)
            {
                iss = false;
                ob.transform.gameObject.layer = 0;
                ob.transform.partent = null;
                Destroy(privot);
                ob = null;
                return;
            }
        }
        if(ob !=null)
        {
            RaycastHit h;

            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out h, Mathf.Infinity))
            {
                privot.transform.rotation = Quartirion.FromToRotation(Vector3.up, h.normal);
                privot.transform.position = h.point;

            }
        }
    }
}
