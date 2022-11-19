using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponInitialize : MonoBehaviour
{
    public GameObject[] WeaponList;

    private void Start()
    {
        
    }

    public void WeaponChange(int index)
    {
        /*player.Weapon = WeaponList[index];
        //�÷��̾� ������
        player.Weapon.transform.position = player.transform.position;*/
    }



    //콜라이더를 이용한 enemy와의 충돌체크
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            //collision.gameObject.GetComponent<Enemy>().Damage(1);
        }
    }
}
