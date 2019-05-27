using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ColorUpdater), typeof(BoxCollider))]
public class TargetHitDetector : MonoBehaviour
{
    public Color HitColor = Color.red;

    private ColorUpdater _colorUpdater;
    private GameManager _gameManager;

    private bool _isHit = false;

    void Start()
    {
        _colorUpdater = GetComponent<ColorUpdater>();
        _gameManager = FindObjectOfType<GameManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!_isHit)
        {
            _colorUpdater.SetColor(HitColor);
            _gameManager.AddScore();
            _isHit = true;
        }
    }
}
