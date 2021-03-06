using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutPage : MonoBehaviour
{
    public GameObject page1, page2, page3;


    public void DisplayPage1()
    {
        ClearPages();
        page1.SetActive(true);
    }
    
    public void DisplayPage2()
    {
        ClearPages();
        page2.SetActive(true);
    }
    
    public void DisplayPage3()
    {
        ClearPages();
        page3.SetActive(true);
    }
    
    public void ClearPages()
    {
        page1.SetActive(false);
        page2.SetActive(false);
        page3.SetActive(false);
    }
}
