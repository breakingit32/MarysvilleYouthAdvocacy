using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthlyPills : MonoBehaviour
{
    public bool rentPaid = false;
    public bool foodPaid = false;
    public bool utilitesPaid = false;
    public bool carInsurancePaid = false;
    public bool gaspaid = false;
    public bool internetPaid = false;
    public float rent;
    public float utilites;
    public float internet;
    public float food;
    public float carInsurance;
    public float gas;
    public float total;
    public MonthlyPills(float playerFood, float Playerrent, float PlayercarInsurance, float Playerutilties, float Playerinternt, float Playergas) {
        this.rent = 1500 * Playerrent;
        this.utilites = 70 *Playerutilties;
        this.internet = 50 * Playerinternt;
        this.food = 150 * playerFood;
        this.carInsurance = 130 * PlayercarInsurance;
        this.gas = 200 * Playergas;
        this.total = this.rent + this.utilites + this.internet + this.food + this.carInsurance + this.gas;

        rentPaid = false;
        foodPaid = false;
        utilitesPaid = false;
        carInsurancePaid = false;
        gaspaid = false;
        internetPaid = false;
    }

    //public MonthlyPills(float rent, float utilites, float internet, float food, float carInsurance, float gas)
    //{
        
    //}
    public void keepVar(float rent, float utilites, float internet, float food, float carInsurance, float gas)
    {
        float oldRent = rent;
        float oldUtilites = utilites;
        float oldInternet = internet;
        float oldFood = food;
        float oldCarInsurance = carInsurance;
        float oldGas = gas;
    }
    public float totalCal(float playerFood, float Playerrent, float PlayercarInsurance, float Playerutilties, float Playerinternt, float Playergas)
    {
        if (rentPaid == true)  Playerrent= 0f;
        if (foodPaid == true) playerFood = 0f;
        if (utilitesPaid == true) Playerutilties = 0f;
        if (carInsurancePaid == true) PlayercarInsurance = 0f;
        if (gaspaid == true) Playergas = 0f;
        float total = this.rent + this.utilites + this.internet + this.food + this.carInsurance + this.gas;

        return total;
    }
}
