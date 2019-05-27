using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class WeaponEquipControl : MonoBehaviour
{
    public List<GameObject> WeaponList;

    private GameObject _equippedWeapon;

    void Start()
    {
        _equippedWeapon = Instantiate(WeaponList.First(), transform);
    }
}
