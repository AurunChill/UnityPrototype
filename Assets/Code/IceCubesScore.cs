using UnityEngine;
using UnityEngine.UI;

public class IceCubesScore : MonoBehaviour
{
    public GameObject player;
    public int playerIceCubes = 0;
    public Text iceCubesScore;

    void Update()
    {
        playerIceCubes = player.GetComponent<GetIceCube>().iceCubes;
        //Debug.Log(playerIceCubes.ToString());
        iceCubesScore.text = $"Ice cubes: {playerIceCubes}";

    }

}