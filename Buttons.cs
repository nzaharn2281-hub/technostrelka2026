using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but6;
    public GameObject but7;
    public GameObject but8;
    public int numBut;
    public GameObject text_points;
    public TMP_Text telling_text;
    public string wrong1_lev1 = "Нет, ты не угадал";
   // public string wrong2_lev1 = "Нет, это официальный аккаунт";
    public string right1_lev1 = "Да, ты угадал, он и в правду мошенник!";
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void click_lev1()


    {
        if (numBut == 0 || numBut == 2 || numBut == 4 || numBut == 6 || numBut == 7 || numBut == 8)
        {
            text_points.GetComponent<Points>().point -= 10;
            Destroy(gameObject);
            telling_text.text = wrong1_lev1;
        } else
        {
            text_points.GetComponent<Points>().point += 10;
            Destroy(gameObject);
            telling_text.text = right1_lev1;

        }
        //if (numBut == 0)
        //{
        //    text_points.GetComponent<Points>().point -= 10;
        //    Destroy(gameObject);
        //    telling_text.GetComponent<Text_on_monitore>().task.text = wrong1_lev1;
        //}
        //if (numBut == 1)
        //{
        //    text_points.GetComponent<Points>().point +=10;
        //    Destroy(gameObject);
        //}
        //if (numBut == 2)
        //{
        //    text_points.GetComponent<Points>().point -=10;
        //    Destroy(gameObject);
        //}
        //if (numBut == 3)
        //{
        //    text_points.GetComponent<Points>().point +=10;
        //    Destroy(gameObject);
        //}
        //if (numBut == 4)
        //{
        //    Destroy(gameObject);
        //    text_points.GetComponent<Points>().point -=10;
        //}
        //if (numBut == 5)
        //{
        //    Destroy(gameObject);
        //    text_points.GetComponent<Points>().point +=10;
        //}
        //if (numBut == 6)
        //{
        //    Destroy(gameObject);
        //    text_points.GetComponent<Points>().point -=10;
        //}
        //if (numBut == 7)
        //{
        //    Destroy(gameObject);
        //    text_points.GetComponent<Points>().point -=10;
        //}
        //if (numBut == 8)
        //{
        //    Destroy(gameObject);
        //    text_points.GetComponent<Points>().point -=10;
        //}


    }
    public void click_lev2()
    {

    }
}
