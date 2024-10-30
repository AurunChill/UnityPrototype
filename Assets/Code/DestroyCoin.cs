using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : MonoBehaviour {

    public int coins = 0;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.tag);
        if (collision.gameObject.tag == "GoldCoin")
        {
            Destroy(collision.gameObject);
            coins++;
            //Debug.Log(coins);
            
        }
    }

}
