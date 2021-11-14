using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    
    private GameObject player;

    int playerCoins = 0;

   public Text uiDistance;
   public Text uiCoins;
   public GameObject gameOverMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        int distance = Mathf.RoundToInt(player.transform.position.z);
        uiDistance.text = "dystans:" + distance.ToString() + "m";

        uiCoins.text = "monety:" + playerCoins.ToString();

    }

    public void CoinCollected(){

        playerCoins++;
    }

    public void GameOver()
        {
            gameOverMenu.SetActive(true);
            Time.timeScale = 0;
        }
    
    
}
