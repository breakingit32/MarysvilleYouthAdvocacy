using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthlyPills : MonoBehaviour
{
    public float rent;
    public float utilites;
    public float internet;
    public float food;
    public float carInsurance;
    public float gas;
    public float total;
    public MonthlyPills() {
        this.rent = 1500;
        this.utilites = 70;
        this.internet = 50;
        this.food = 150;
        this.carInsurance = 130;
        this.gas = 200;
        this.total = this.rent + this.utilites + this.internet + this.food + this.carInsurance + this.gas;
    }

    public MonthlyPills(float rent, float utilites, float internet, float food, float carInsurance, float gas)
    {
        
    }

    public float totalCal()
    {
        float total = this.rent + this.utilites + this.internet + this.food + this.carInsurance + this.gas;

        return total;
    }
}
