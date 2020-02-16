using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Mechanics;

public class OnCollision : MonoBehaviour
{
    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;
    public string ans1;
    public string ans2;
    public string ans3;
    public string ans4;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public TextMeshProUGUI Question;
    public string q;
    public GameObject player;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.ToString());
        if (collision.gameObject.ToString() == "Player (UnityEngine.GameObject)")
        {
            button1.interactable = true;
            button2.interactable = true;
            button3.interactable = true;
            button4.interactable = true;

            Question.text = q;
            text1.SetText(ans1);
            text2.SetText(ans2);
            text3.SetText(ans3);
            text4.SetText(ans4);
        }
    }
}
