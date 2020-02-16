using System.Collections;
using System.Collections.Generic;
using Platformer.Gameplay;
using UnityEngine;
using static Platformer.Core.Simulation;
using TMPro;
using UnityEngine.UI;

namespace Platformer.Mechanics
{
    /// <summary>
    /// A simple controller for enemies. Provides movement control over a patrol path.
    /// </summary>
    [RequireComponent(typeof(AnimationController), typeof(Collider2D))]
    public class EnemyController : MonoBehaviour
    {
        public PatrolPath path;
        public AudioClip ouch;

        internal PatrolPath.Mover mover;
        internal AnimationController control;
        internal Collider2D _collider;
        internal AudioSource _audio;
        SpriteRenderer spriteRenderer;
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
        public Bounds Bounds => _collider.bounds;

        void Awake()
        {
            control = GetComponent<AnimationController>();
            _collider = GetComponent<Collider2D>();
            _audio = GetComponent<AudioSource>();
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        void OnCollisionEnter2D(Collision2D collision)
        {
            var player = collision.gameObject.GetComponent<PlayerController>();
            if (player != null)
            {
                button1.enabled = true;
                button2.enabled = true;
                button3.enabled = true;
                button4.enabled = true;
                Question.enabled = true;

                text1.SetText(ans1);
                text2.SetText(ans2);
                text3.SetText(ans3);
                text4.SetText(ans4);
            }
        }

        void Update()
        {
            if (path != null)
            {
                if (mover == null) mover = path.CreateMover(control.maxSpeed * 0.5f);
                control.move.x = Mathf.Clamp(mover.Position.x - transform.position.x, -1, 1);
            }
            
        }

    }
}