using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCapsule : MonoBehaviour
{

    public Vector3 moveVector = new Vector3(0, 0, 1);

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     //if (Input.GetMouseButton(0))
            if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))

        this.transform.Translate(moveVector * Time.deltaTime);
        Debug.Log(Time.deltaTime);
    }

}
