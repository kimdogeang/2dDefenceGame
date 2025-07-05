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

            //��ġ�� ���� ������ǥ�� �޾ƿ´�
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(wp, Vector2.zero);

            //���� ���ؼ��� (������, ����) ->��ġ�Ѱ�, x,y�� ����ʵ� �������ʰ� ��ġ�� ���� ����
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            //�߻��� ���̿����� ��ȯ�� �޾ƿ�
            if (hit.collider != null)
            {
                if (hit.collider.tag == "enemy") //���� ���� ��ü�� �±װ� enemy���
                { Destroy(hit.collider.gameObject); }
            }
        }
    }
}
