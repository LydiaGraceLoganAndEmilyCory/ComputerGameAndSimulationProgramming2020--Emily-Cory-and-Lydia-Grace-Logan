using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class selfDEl : MonoBehaviour
{
    public TextMeshProUGUI escape;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Menu"))
        {
            escape.enabled = false;
        }
    }
}
