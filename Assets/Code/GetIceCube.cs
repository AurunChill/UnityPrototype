using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetIceCube : MonoBehaviour {

    public int iceCubes = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "IceCube")
        {
            Destroy(collision.gameObject);
            iceCubes++;
            //Debug.Log(iceCubes);

        }
    }
}
