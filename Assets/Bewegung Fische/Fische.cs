using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fische : MonoBehaviour {

    public LevelManager levelManager;
    public Vector3 startPos;
    public Vector3 newPos;



    // Start is called before the first frame update
    void Start(){
        levelManager = FindObjectOfType<LevelManager>();
        startPos = transform.position;
        newPos = startPos;

    }

    // Update is called once per frame
    void Update()
    {
        newPos.z = newPos.z + Mathf.PingPong(Time.time, 6) - 3;
        transform.position = newPos;

    }
    
        }
