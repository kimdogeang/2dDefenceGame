using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text scoreText;
    private float time;
    private int Int_time;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        Int_time = (int)time;
        scoreText.text = "Score : " + Int_time.ToString();
    }
}
