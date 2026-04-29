using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public bool but1lev1 = false;
    public bool but1lev2 = false;
    public bool but1lev3 = false;
    public TMP_Text on_but1;
    public TMP_Text on_but2;
    public TMP_Text on_but3;
    public TMP_Text on_but4;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but6;
    public GameObject but7;
    public GameObject but8;
    public GameObject but9;
    public GameObject sw;
    public int numBut;
    public GameObject text_points;
    public TMP_Text telling_text;
    public string wrong1_lev1 = "Нет, ты не угадал";
   // public string wrong2_lev1 = "Нет, это официальный аккаунт";
    public string right1_lev1 = "Да, ты угадал, он и в правду мошенник!";
    public bool live = true;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      live = sw.GetComponent<Material_Switching>().live;
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
            if (numBut == 1)
            {
                but1lev1 = true;
            }
            if (numBut == 2)
            {
                but1lev2 = true;
            }
            if (numBut == 3)
            {
                but1lev3 = true;
            }
            text_points.GetComponent<Points>().point += 10;
            
            Destroy(gameObject);
            telling_text.text = right1_lev1;
            if (but1lev1 == true && but1lev2 == true && but1lev3 == true)
            {
                telling_text.text = "Молодец, ты справился с заданием, но с ошибками. Старайся!";
                sw.GetComponent<Material_Switching>().level = 2;
                Destroy(but8);
                Destroy(but1);
                Destroy(but2);
                Destroy(but3);
                Destroy(but4);
                Destroy(but5);
                Destroy(but6);
                Destroy(but7);
                Destroy(but9);
            }
            if (text_points.GetComponent<Points>().point == 30)
            {
                telling_text.text = "Молодец, ты справился с заданием без ошибок!";
                sw.GetComponent<Material_Switching>().level = 2;
                Destroy(but8);
                Destroy(but1);
                Destroy(but2);
                Destroy(but3);
                Destroy(but4);
                Destroy(but5);
                Destroy(but6);
                Destroy(but7);
                Destroy(but9);


            }

        }
        


    }
    public void click_lev2()
    {
            if (sw.GetComponent<Material_Switching>().level == 2 && live == true)
            {      
                                    if (numBut == 3)
                {
                    print(213);
                    sw.GetComponent<Material_Switching>().leveling(2, true, true);
                    telling_text.text = "Ты позвал родителей и вы смогли сохранить аккаунт!";
                    sw.GetComponent<Material_Switching>().level = 3;
                    print(3);
                    text_points.GetComponent<Points>().point += 20;

                }
                                    if (numBut == 1)
                {
                    sw.GetComponent<Material_Switching>().leveling(2, true, true);
                    telling_text.text = "Ты сменил пароль и смог спасти аккаунт!";
                    sw.GetComponent<Material_Switching>().level = 3;

                    text_points.GetComponent<Points>().point += 10;

                }
                                    if (numBut == 4)
                {
                    sw.GetComponent<Material_Switching>().leveling(2, false, true);
                    telling_text.text = "Ты забил и твой аккаунт был украден!";
                    sw.GetComponent<Material_Switching>().level = 3;
                    text_points.GetComponent<Points>().point -= 20;
                }
                                    if (numBut == 2)
                {
                    sw.GetComponent<Material_Switching>().leveling(2, false, true);
                    telling_text.text = "Ты удалил аккаунт!";
                    sw.GetComponent<Material_Switching>().level = 3;
                    text_points.GetComponent<Points>().point -= 20;

                }
            live = false;
            
        }
            if(sw.GetComponent<Material_Switching>().level == 3 ) // уровень  3
        {
            on_but1.text = "Да, скину";
            on_but2.text = "Пошлю";
            on_but3.text = "Расскажу родителям";
            on_but4.text = "Позвоню и спрошу";
            if (live == true)
            {
                if (numBut == 2)
                {
                    sw.GetComponent<Material_Switching>().leveling(3, true, false);
                    telling_text.text = "Ты послал его и заблокировал";
                    sw.GetComponent<Material_Switching>().level = 4;
                    text_points.GetComponent<Points>().point += 10;

                }
                if (numBut == 1)
                {
                    sw.GetComponent<Material_Switching>().leveling(3, false, true);
                    telling_text.text = "Ты перевёл ему деньги. В школе он сказал, что его взломали";
                    sw.GetComponent<Material_Switching>().level = 4;
                    text_points.GetComponent<Points>().point -= 20;
                }
                if (numBut == 3)
                {
                    sw.GetComponent<Material_Switching>().leveling(3, true, true);
                    telling_text.text = "Ты позвал папу. Он позвонил родителям мальчика и он сказали, что всё в порядке.";
                    sw.GetComponent<Material_Switching>().level = 4;
                    text_points.GetComponent<Points>().point += 20;
                }
                if (numBut == 4)
                {
                    sw.GetComponent<Material_Switching>().leveling(3, false, true);
                    telling_text.text = "Ты перевёл ему деньги. В школе он сказал, что его взломали";
                    sw.GetComponent<Material_Switching>().level = 4;
                    text_points.GetComponent<Points>().point -= 20;
                    live = false;
                }
                live = false;
            }
        }
        if (sw.GetComponent<Material_Switching>().level == 4)
        { // уровень 4
            on_but4.text = "Выйду из игры";
            on_but2.text = "Откажусь";
            if (live == true)
            {
                if (numBut == 1)
                {
                    sw.GetComponent<Material_Switching>().leveling(4, false, true);
                    telling_text.text = "Ты скинул реквизиты. Мама в шоке удалила тебе роблокс и сильно наказала, так как с карты списали 100к рублей";
                    sw.GetComponent<Material_Switching>().level = 5;
                    text_points.GetComponent<Points>().point -= 50;
                }
                if (numBut == 2)
                {
                    sw.GetComponent<Material_Switching>().leveling(4, true, true);
                    telling_text.text = "Ты вежливо отказался и друг вышел. Больше он тебе не друг!";
                    sw.GetComponent<Material_Switching>().level = 5;
                    text_points.GetComponent<Points>().point += 20;

                }
                if (numBut == 3)
                {
                    sw.GetComponent<Material_Switching>().leveling(4, true, false);
                    telling_text.text = "Ты позвал отца и, по его советам, ты вышел из игры";
                    sw.GetComponent<Material_Switching>().level = 5;
                    text_points.GetComponent<Points>().point += 50;
                }
                if (numBut == 4)
                {
                    sw.GetComponent<Material_Switching>().leveling(4, true, false);
                    telling_text.text = "Ты вышел из игры и забыл";
                    sw.GetComponent<Material_Switching>().level = 5;
                    text_points.GetComponent<Points>().point += 10;
                }
                live = false;
            }
        }
            if (sw.GetComponent<Material_Switching>().level == 5)
            {
                on_but1.text = "Перейду";
                on_but2.text = "Позвоню банку";
                on_but3.text = "Отвечу";
                on_but4.text = "Перешлю другу";
                if (live == true)
                {
                    if (numBut == 1)
                    {
                        sw.GetComponent<Material_Switching>().leveling(5, true, true);
                        telling_text.text = "Ты перешёл по ссылке, заполнил данные и твоя карта ушла к мошенникам";
                        sw.GetComponent<Material_Switching>().level = 6;
                        text_points.GetComponent<Points>().point -= 50;

                    }
                    if (numBut == 2)
                    {
                        sw.GetComponent<Material_Switching>().leveling(5, true, false);
                        telling_text.text = "Ты позвонил в банк, где сказали, что с картой всё хорошо";
                        sw.GetComponent<Material_Switching>().level = 6;
                        text_points.GetComponent<Points>().point += 20;

                    }
                    if (numBut == 3)
                    {
                        sw.GetComponent<Material_Switching>().leveling(5, false, true);
                        telling_text.text = "Ты ответил на почту, имошенники поняли, что почта активна";
                        sw.GetComponent<Material_Switching>().level = 6;
                        text_points.GetComponent<Points>().point -= 10;

                    }
                    if (numBut == 4)
                    {
                        sw.GetComponent<Material_Switching>().leveling(5, false, false);
                        telling_text.text = "Ты отправл сообщениедругу, который шарит в компах. Он наткнулся на фишинг и его комп заразился. После он перестал общатся с тобой.";
                        sw.GetComponent<Material_Switching>().level = 6;
                        text_points.GetComponent<Points>().point -= 40;

                    }
                    live = false;

                }
            }
            if(sw.GetComponent<Material_Switching>().level == 6)
            {
            if (live == true)
            {
                telling_text.text = "Поздравляю! Вы набрали" + text_points.GetComponent<Points>().point.ToString() + "очков!";
                live = false;
            }
               
            }
        
    }
}
