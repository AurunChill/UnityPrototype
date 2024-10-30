using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {

    private GameObject coinObj = null;
    public Vector3 coinObjRot = new Vector3(0, 0, 0);
    // Use this for initialization
    void Start()
    {
        Debug.Log("I'm attached to " + gameObject.name);
        if (coinObj == null)
            coinObj = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        coinObj.transform.eulerAngles = coinObjRot;
        coinObjRot.z += 6;
        if (coinObjRot.z >= 360) {
            coinObjRot.z = 0;
        }
        
    }
}
