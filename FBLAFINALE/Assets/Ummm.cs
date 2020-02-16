using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Platformer.Core.Simulation;
using TMPro;
namespace Platformer.Mechanics
{

    public class Ummm : MonoBehaviour
    {
        public TextMeshProUGUI help;
        void OnTriggerEnter2D(Collider2D collider)
        {
            var p = collider.gameObject.GetComponent<PlayerController>();
            if (p != null)
            {
                help.text = "You have completed your BAA's!";
            }
        }
    }
}
