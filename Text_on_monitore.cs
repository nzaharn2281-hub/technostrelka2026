using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_on_monitore : MonoBehaviour
{
    public TMP_Text task;
    public TMP_FontAsset we;
    public string lev1 = "Найди фишинговые сервисы среди ваших сообщений";
    public string lev2 = "Ты оставил свою почту на чужём пк. Тебе пришло уведомление. Что ты будешь делать?";
    public string lev3 = "Твой друн в игре предложил тебе выгодную сделку. Что ты сделаешь?";
    public string lev4 = "Ты оставил свою почту на чужём пк. Тебе пришло уведомление. Что ты будешь делать?";
    public string lev5 = "Найди фишинговые сервисы среди ваших сообщений";
    public bool level2;
    public bool level3;
    public bool level4;
    public bool level5;

    // Start is called before the first frame update
    void Start()
    {
        task.text = lev1;
        task.font = we;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(level2 == true)
        {
            task.text = lev2;
        }
        if (level3 == true)
        {
            task.text = lev3;
        }
        if (level4 == true)
        {
            task.text = lev4;
        }
        if (level5 == true)
        {
            task.text = lev5;
        }

    }
}
