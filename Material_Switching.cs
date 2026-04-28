using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Material_Switching : MonoBehaviour
{
    public int level = 1;
    public Material level2;
    public Material level3;
    public Material level4;
    public Material level5;
    public Renderer Render;
    public GameObject forText;
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
        if (level == 1)
        {
            
            Render.material = level2;
            forText.GetComponent<Text_on_monitore>().level2 = true;
            level = 2;

        }
        if (level == 2)
        {
            
        }
    }
}
