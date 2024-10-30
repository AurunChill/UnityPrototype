using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallCheck : MonoBehaviour {

    private GameObject playerObj = null;
    public Vector3 PlayerPos = new Vector3(0, 1, 0);
    // Use this for initialization
    void Start () {
        if (playerObj == null)
            playerObj = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        PlayerPos = playerObj.GetComponent<Transform>().position;
        if (PlayerPos.y < 0)
        {
            playerObj.GetComponent<Transform>().position = new Vector3(0, 15, 0);
            playerObj.GetComponent<ThirdPersonController>().isGrounded = true;
        }
	}
}
