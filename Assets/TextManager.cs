using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public Text Savings;
    public Text Checking;
    public Text Col;
    public float bills;
    public Month2 month2;
    public Manager manager;
    public CalCol cal;
    public Text Player;
    public string Savingsss;
    
    // Start is called before the first frame update
    void Start()
    {
        Text Player = GetComponent<Text>();
        Text Col = GetComponent<Text>();
        Text Checking = GetComponent<Text>();
        Text Savings = GetComponent<Text>();
        
        Debug.Log(Savingsss + " Savings");
    }

    void Update()
    {
        
        string checking = cal.CalChecking(manager.players[manager.playerTracker]).ToString();
        Player.text = "Player: " + (manager.playerTracker + 1).ToString();
<<<<<<< HEAD
        //Debug.Log(cal.CalChecking(manager.players[manager.playerTracker]) + "((((");
        Checking.text = "Checking: $" + checking; 
        //Debug.Log(checking + "CCCC");
        Col.text = "Bills: $" + manager.players[manager.playerTracker].Bills.ToString();
=======
        Debug.Log(cal.CalChecking(manager.players[manager.playerTracker]) + "((((");
        Checking.text = "Checking: $" + cal.CalChecking(manager.players[manager.playerTracker]).ToString(); 
        Debug.Log(manager.players[manager.playerTracker].PayCheck + "CCCC");
        Col.text = "Bills: $" + month2.billss.ToString();
>>>>>>> parent of b1379fd (finish)
        Savings.text = "Savings: $" + Savingsss;
        

    }
    private void LateUpdate()
    {
        Savingsss = manager.players[manager.playerTracker].Savings.ToString();
    }


}
