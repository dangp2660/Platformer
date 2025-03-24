using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Collision : MonoBehaviour
{
    // Start is called before the first frame update
    GameManager GM;
    [SerializeField] private TextMeshPro scoreText;
    private void Awake()
    {
        GM = FindAnyObjectByType<GameManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
            GM.addScore(1);
        }
    }

}
