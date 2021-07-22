using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public ParticleSystem projectile;

    void Update()
    {
        Vector2 dir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position;
        float angle = Mathf.Atan2(dir.y, dir.x)*Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
        this.transform.roation = rotation;

        if(Input.GetMouseButtonDown(0)){
            projectile.play;
        }
    }
}
