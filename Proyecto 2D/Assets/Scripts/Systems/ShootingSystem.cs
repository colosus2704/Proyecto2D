using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ShootingSystem : MonoBehaviour
{
    public ShootingSystemData shootingdata;

    public Transform shotPoint;

    public abstract void Shoot();
}