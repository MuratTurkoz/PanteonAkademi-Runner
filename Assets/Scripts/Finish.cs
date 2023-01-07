using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Finish : MonoBehaviour
{
    int _score;
    PlayerController playerController;
    private void Start()
    {
        playerController= GetComponent<PlayerController>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End"))
        {
            playerController.BackReturn();
            _score = GetComponent<CollectCoin>().GetScore();
            playerController.SetRunSpeed(0);
            playerController.SetLose(true);
            if (_score > 10)
            {
                GetComponent<Animate>().WinAnimation();
            }
            else
            {
                GetComponent<Animate>().LoseAnimation();
            }
        }
    }
}
