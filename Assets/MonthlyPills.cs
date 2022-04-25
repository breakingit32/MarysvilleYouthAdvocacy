using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonthlyPills : MonoBehaviour
{
    private float rent { get; set; }
    private float utilites { get; set; }
    private float internet { get; set; }
    private float food { get; set; }
    private float carInsurance { get; set; }
    private float gas { get; set; }
    public float total { get; set; }
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


}
