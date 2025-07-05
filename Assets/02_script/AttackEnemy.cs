using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackEnemy : MonoBehaviour
{
 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))

        {

            //터치한 곳을 월드좌표로 받아온다
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(wp, Vector2.zero);

            //레이 기준설정 (기준점, 방향) ->터치한곳, x,y축 어느쪽도 향하지않고 터치한 곳을 향함
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            //발사한 레이에대한 반환값 받아옴
            if (hit.collider != null)
            {
                if (hit.collider.tag == "enemy") //레이 맞은 객체의 태그가 enemy라면
                { Destroy(hit.collider.gameObject); }
            }
        }
    }
}
