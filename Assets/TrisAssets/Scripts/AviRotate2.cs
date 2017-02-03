using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AviRotate2 : MonoBehaviour {

	// Use this for initialization
	//void Start () {

 //   }

    public void Rotate2()
    {
        GameObject.FindGameObjectWithTag("a2").transform.rotation *= Quaternion.Euler(0, 0, -90);
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
