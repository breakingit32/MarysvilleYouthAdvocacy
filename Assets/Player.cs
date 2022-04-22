using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Player : MonoBehaviour
{
    public float Savings;
    public float PayCheck;
    public float Bills;
    public bool hasCar;
    public bool hasCarInsurance;
    public bool hasInternet;
    public bool hasFood;
    public bool hasHome;
    public bool hasGas;
    public CalCol cal;
    public MonthlyPills monthlyPills;

    public Player(float savings, float payCheck)
    {
        monthlyPills = new MonthlyPills();
        Bills = monthlyPills.total;
        Savings = savings;
        PayCheck = payCheck;
        this.hasCar = true;
        this.hasCarInsurance = true;
        this.hasInternet = true;
        this.hasFood = true;
        this.hasHome = true;
        this.hasGas = true;
    }

    public Player() { }

    
    
    public void UpdateBools()
    {
        hasCar = false;
        hasCarInsurance = false;
        hasInternet = false;
        hasFood = false;
        hasHome = false;
        hasGas = false;
    }
}

