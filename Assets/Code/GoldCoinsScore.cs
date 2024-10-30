using UnityEngine;
using UnityEngine.UI;

public class GoldCoinsScore : MonoBehaviour
{
    public GameObject player;
    public int playerCoins = 0;
    public Text goldCoinsScore;

    void Update()
    {
        playerCoins = player.GetComponent<DestroyCoin>().coins;
        //Debug.Log(playerCoins.ToString());
        goldCoinsScore.text = "Coins: " + playerCoins.ToString();

    }

}