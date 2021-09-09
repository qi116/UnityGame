using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    private int multiplier = 0;
    private int score = 0;
    public Text mUI;
    public Text sUI;
    public float flashTime = 2f;
    private float countFlash;
    private Animator anim;
    private bool on = false;
    void Start()
    {
        anim = mUI.GetComponent<Animator>();
        countFlash = flashTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (on)
        {
            countFlash -= Time.deltaTime;
        }
        if (countFlash <= 0)
        {

            countFlash = flashTime;
            mUI.gameObject.SetActive(false);
            on = false;
        }
        mUI.text = multiplier + "x";
        sUI.text = "Score : " + score;
        
    }
    public void Flash()
    {
        mUI.gameObject.SetActive(true);
        countFlash = flashTime;
        on = true;



        anim.Play("Multiplier", -1,0f);
        Debug.Log("here");
    }
    public void resetMult()
    {
        multiplier = 0;
    }
    public int getMult()
    {
        return multiplier;
    }
    public void addMult()
    {
        multiplier++;
    }
    public void addScore(int x)
    {
        if (multiplier == 0)
        {
            score += x;
        }
        else
        {
            score += x * multiplier;
        }
    }
}
