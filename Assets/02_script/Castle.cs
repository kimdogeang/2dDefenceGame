using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Castle : MonoBehaviour
{
    private float MaxHP;
    private float Damage;
    public Image GuageBar;

    // Start is called before the first frame update
    void Start()
    {
        MaxHP = 10;
        Damage = 1;
        GuageBar = GameObject.Find("HpGuage").GetComponent<Image>();
        GuageBar.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (GuageBar.fillAmount <= 0) 
        {
            SceneManager.LoadScene("Gameover");
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("oo");

        GuageBar.fillAmount -= Damage / MaxHP;
        // 1 = 1 - 1/10
        Destroy(collision.gameObject);
    }


}
