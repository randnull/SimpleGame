using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Coin : MonoBehaviour
{
    public ScoreCount score;

    private void Start()
    {
        score = FindObjectOfType<ScoreCount>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Собрали монету!" + other.name);
        if (other.CompareTag("Player"))
        {
            ScoreCount.Score += 1;
            Destroy(gameObject);
        }
    }
}
