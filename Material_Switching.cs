using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Material_Switching : MonoBehaviour
{
    public int level = 1;
    public bool swit = false;
    public Material level2;
    public Material level3;
    public Material level4;
    public Material level5;
    public Renderer Render;
    public GameObject forText;
    public Material lev2_right;
    public Material lev2_lose;
    public Material lev3_right;
    public Material lev3_lose;
    public Material lev3_go;
    public Material lev4_lose;
    public Material lev4_right;
    public Material lev4_go;
    public Material lev5_1;
    public Material lev5_2;
    public Material lev5_3;
    public Material lev5_4;

    public bool live;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    public void switching()
    {
        swit = true;
        if (swit == true)
        {
            if (level == 2)
            {
                live = false;
                print(2);
                Render.material = level2;
                forText.GetComponent<Text_on_monitore>().level2 = true;
   
                swit = false;
                live = true;
            }
            if (level == 3)
            {
                live = false;
                print(3);
                Render.material = level3;
                forText.GetComponent<Text_on_monitore>().level3 = true;
                forText.GetComponent<Text_on_monitore>().level2 = false;
                live = true;
                swit = false;
            }
            if (level == 4)
            {
                live = false;
                Render.material = level4;
                forText.GetComponent<Text_on_monitore>().level4 = true;
                forText.GetComponent<Text_on_monitore>().level3 = false;
                swit = false;
                live = true;
            }
            if (level == 5)
            {
                live = false;
                Render.material = level5;
                forText.GetComponent<Text_on_monitore>().level5 = true;
                forText.GetComponent<Text_on_monitore>().level4 = false;
                swit = false;
                live = true;

            }
            if(level == 6)
            {
                forText.GetComponent<Text_on_monitore>().level6 = true;
                forText.GetComponent<Text_on_monitore>().level5 = false;

            }
        }
    }
    public void leveling(int level, bool st, bool leav)
    {
        if (level == 2)
        {
            if (st == true)
            {
                Render.material = lev2_right;
            }
            else
            {
                Render.material = lev2_lose;
            }

        }
        if (level == 3)
        {
            if (st == true)
            {
                if (leav == false)
                {
                    Render.material = lev3_go;
                }
                Render.material = lev3_right;
            }
            else
            {
                Render.material = lev3_lose;
            }
        }
        if (level == 4)
        {
            if (st == true)
            { 
                if (leav == false)
                {
                    Render.material = lev4_go;
                }
                else
                {
                    Render.material = lev4_right;
                }
                    
            }
            else
            {
                Render.material = lev4_lose;
            }
        }
        if (level == 5)
        {
            if (st == true)
            {
                if (leav == true)
                {
                    Render.material = lev5_1;
                } else
                {
                    Render.material = lev5_2;
                }
            } else
            {
                if (leav == true)
                {


                    Render.material = lev5_3;
                } else
                {
                    Render.material = lev5_4;
                }
            }
        }
    }
}
