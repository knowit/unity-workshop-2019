using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ColorUpdater), typeof(BoxCollider))]
public class TargetHitDetector : MonoBehaviour
{
    public Color HitColor = Color.red;

    private ColorUpdater _colorUpdater;

    void Start()
    {
        _colorUpdater = GetComponent<ColorUpdater>();
    }

    void OnTriggerEnter(Collider other)
    {
        _colorUpdater.SetColor(HitColor);
    }
}
