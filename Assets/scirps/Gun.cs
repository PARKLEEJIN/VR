using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public int bulletCount = 10;
    public Rigidbody bullet;
    public Transform firepos;
    public TMP_Text txbulletCount;




    public void shoot()
    {
        if (bulletCount <= 0)
            return;
;        //Instantiate(bullet);

        //Instantiate(bullet, firepos);

        Rigidbody bulletobj = Instantiate(bullet, firepos.position, firepos.rotation);
        bulletobj.AddForce(firepos.forward * 100, ForceMode.Impulse);

        bulletCount--;

        RefreshBulletCountUI();
    }
    void RefreshBulletCountUI()
    {
        txbulletCount.text= bulletCount.ToString();
    }
}
