using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject completeUI;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag.Equals("Player"))
        {
            completeUI.SetActive(true);
            Score.finalizeScore();
        }
    }
}
