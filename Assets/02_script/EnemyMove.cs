using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Transform tr;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.tr.Translate(Vector2.left * speed * Time.deltaTime);
            //tr.position = new Vector3(x, y, z);
            /////////int a = 1
    }
}
