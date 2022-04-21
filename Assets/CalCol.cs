using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalCol : MonoBehaviour
{
    public bool rentPaid = false;
    public bool foodPaid = false;
    public bool utilitesPaid = false;
    public bool carInsurancePaid = false;
    public bool gaspaid = false;
    public bool internetPaid = false;

    public float rent;
    public float food;
    public float utilites;
    public float carInsurance;
    public float gas;
    public float internet;

    public Month2 month2;
    

    public CalCol(bool rentPaid, bool foodPaid, bool utilitesPaid, bool carInsurancePaid, bool gaspaid, bool internetPaid, float rent, float food, float utilites, float carInsurance, float gas, float internet)
    {
        this.rentPaid = rentPaid;
        this.foodPaid = foodPaid;
        this.utilitesPaid = utilitesPaid;
        this.carInsurancePaid = carInsurancePaid;
        this.gaspaid = gaspaid;
        this.internetPaid = internetPaid;
        this.rent = rent;
        this.food = food;
        this.utilites = utilites;
        this.carInsurance = carInsurance;
        this.gas = gas;
        this.internet = internet;
    }

    public float Cal()
    {
        if (rentPaid == true) month2.rent = 0f;
        //else if( rentPaid == false) month2.rent = month2.rent;
        if (foodPaid == true) month2.food = 0f;
        //else if (foodPaid == false) month2.food = Month2.food;
        if (utilitesPaid == true) month2.utilites = 0f;
        //else if (utilitesPaid == false) month2.utilites = Month2.utilites;
        if (carInsurancePaid == true) carInsurance = 0f;
        //else if (carInsurancePaid == false) carInsurance = Month2.carInsurance;
        if (gaspaid == true) gas = 0f;
        //else if (gaspaid == false) gas = Month2.gas;
        if (internetPaid == true) internet = 0f;
        //else if (internetPaid == false) internet = Month2.internet;

        float total = month2.rent + month2.food + month2.utilites + month2.carInsurance + month2.gas + month2.internet;
        //Debug.Log(total);

        return total;
    }

    public float CheckBal(Player player, float item)
    {
        
        Debug.Log(player.PayCheck);
        if (player.PayCheck - item <= 0f) {
            
            return 1; //Not enough funds
        }
        else { return 0; } //Has funds

        

        
    }
    public float CalChecking(Player player)
    {
        

        float checking = player.PayCheck - rent - utilites - carInsurance - gas - internet - food;      
        return checking;
    }

    public void UpdateVar(float newRent, float newFood, float newUtilites, float newCarInsurance, float newGas,  float newInternet)
    {
        rent = newRent;
        food = newFood;
        utilites = newUtilites;
        carInsurance = newCarInsurance;
        gas = newGas;
        internet = newInternet;
    }

   







    // Start is called before the first frame update

}
