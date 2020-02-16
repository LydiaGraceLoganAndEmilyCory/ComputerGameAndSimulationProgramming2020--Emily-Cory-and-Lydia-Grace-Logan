using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OnClick : MonoBehaviour
{
    public string help;
    public int count;
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public void Correct(string button)
    {
       if (count == 1)
        {
            if (button == "three")
            {
                rightClick();
                count++;
            }
            
        }
        else if (count == 2)
        {
            if (button == "two")
            {
                rightClick();
                count++;
            }
            
        }
        else if (count == 3)
        {
            if (button == "one")
            {
                rightClick();
                count++;
            }
            
        }
        else if (count == 4)
        {
            if (button == "four")
            {
                rightClick();
                count++;
            }
            
        }
    }
    public void rightClick()
    {
        text1.SetText("");
        text2.SetText("");
        text3.SetText("");
        text4.SetText("");
        Debug.Log(count);
        if (count == 1)
        {
            enemy1.SetActive(false);
        }
        else if(count == 2)
        {
            enemy2.SetActive(false);
        }
        else if (count == 3)
        {
            enemy3.SetActive(false);
        }
        else if (count == 4)
        {
            enemy4.SetActive(false);
        }
        button1.interactable = false;
        button2.interactable = false;
        button3.interactable = false;
        button4.interactable = false;
    }
}
