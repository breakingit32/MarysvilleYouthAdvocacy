﻿using System;
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

    public Player(float savings, float payCheck, bool hasCar, bool hasCarInsurance, bool hasInternet, bool hasFood, bool hasHome, bool hasGas, float bills)
    {
        Savings = savings;
        PayCheck = payCheck;
        Bills = bills;
        this.hasCar = hasCar;
        this.hasCarInsurance = hasCarInsurance;
        this.hasInternet = hasInternet;
        this.hasFood = hasFood;
        this.hasHome = hasHome;
        this.hasGas = hasGas;
    }

    public Player() { }

    public void SetBools()
    {
        
        Savings = 500;
        PayCheck = 2000;
        Bills = cal.Cal();
        hasCar = true;
        hasCarInsurance = true;
        hasInternet = true;
        hasFood = true;
        hasHome = true;
        hasGas = true;

    }
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

