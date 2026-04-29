using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_on_monitore : MonoBehaviour
{
    public TMP_Text task;
    public GameObject point;
    public Color col_text;
    public TMP_FontAsset we;
    public string lev1 = "Найди фишинговые сервисы среди ваших сообщений";
    public string lev2 = "Ты оставил свою почту на чужём пк. Тебе пришло уведомление. Что ты будешь делать?";
    public string lev3 = "Твой друн в игре попросил очень срочно скинуть ему денег. Твои действия?";
    public string lev4 = "Ты оставил свою почту на чужём пк. Тебе пришло уведомление. Что ты будешь делать?";
    public string lev5 = "Найди фишинговые сервисы среди ваших сообщений";
    public string lev6 = "Поздравляю, ты набрал";
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;
    public bool level6;

    // Start is called before the first frame update
    void Start()
    {
        task.text = lev1;
        task.font = we;
        task.color = col_text;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(level2 == true)
        {
            task.text = lev2;
            level2 = false;
        }
        if (level3 == true)
        {
            task.text = lev3;
            level3 = false;
        }
        if (level4 == true)
        {
            task.text = lev4;
            level4 = false;
        }
        if (level5 == true)
        {
            task.text = lev5;
            level5 = false;
        }
        if (level6 == true)
        {
            task.text = lev6 + point.GetComponent<Points>().point.ToString() + "очков!";
            level6 = false;
        }

    }
}
