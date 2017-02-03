using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviRotate1 : MonoBehaviour {

	// Use this for initialization
	//void Start () {

 //   }

    public void Rotate1()
    {
        //print("test");
        GameObject.FindGameObjectWithTag("a1").transform.rotation *= Quaternion.Euler(0, 0, -90);
        //if (Input.GetMouseButtonUp(0))
        //{

        //    transform.rotation *= Quaternion.Euler(0, 0, -90);
        //}
}

//takes care of rotate
//void Update()
//    {

//    }
}
