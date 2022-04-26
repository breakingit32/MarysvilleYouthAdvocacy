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
    public Text results;
    
    // Start is called before the first frame update
    void Start()
    {
        Text Player = GetComponent<Text>();
        Text Col = GetComponent<Text>();
        Text Checking = GetComponent<Text>();
        Text Savings = GetComponent<Text>();
        Text Result = GetComponent<Text>();
        
    }

    void Update()
    {
        cal.Cal(manager.players[manager.playerTracker], Month2.rent, Month2.gas, Month2.internet, Month2.carInsurance, Month2.food, Month2.utilites);
        Savingsss = manager.players[manager.playerTracker].Savings.ToString();
        Player.text = "Player: " + (manager.playerTracker + 1).ToString();
        Debug.Log(cal.CalChecking(manager.players[manager.playerTracker]) + "((((");
        Checking.text = "Checking: $" + manager.players[manager.playerTracker].PayCheck.ToString(); 
        Debug.Log(manager.players[manager.playerTracker].PayCheck + "CCCC");
        Col.text = "Bills: $" + manager.players[manager.playerTracker].Bills;
        Savings.text = "Savings: $" + Savingsss;
        results.GetComponent<Text>().text = ""; //Clear the text
        foreach (string item in month2.Situation) //Add each item to the text
            results.GetComponent<Text>().text += item.ToString() + ", ";

    }


}
