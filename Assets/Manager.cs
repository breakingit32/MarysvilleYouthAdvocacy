using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
    public static Manager M;
    public Month2 month2;
    public float checking;
    public Player[] players;
    public int playerTracker;
    public string[] scenes = { "Player 1", "Player 2", "Player 3", "Player 4", "Player 5" };
    // Start is called before the first frame update
    void Start()
    {
        //players[1] = new Player(500f, 2000f);
        //players[0] = new Player(400, 1900);

        for (int i = 0; i < 5; i++)
        {
            players[i] = new Player(1500, 10000);
        }
        //players[2].SetBools();
        //players[3].SetBools();
        //players[4].SetBools();

            ///month2.SetVar();
    }

    // Update is called once per frame
    void Update()
    {
        checking = players[playerTracker].PayCheck;
    }
}
