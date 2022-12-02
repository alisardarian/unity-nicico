using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    [SerializeField] private ParticleSystem explodeParticle;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameManager.Instance.OnBrickDestroy(this);
        var createdParticle = Instantiate(explodeParticle, transform.position, Quaternion.identity);
        var particleSetting = createdParticle.main;
        particleSetting.startColor = new ParticleSystem.MinMaxGradient(_spriteRenderer.color);
        Destroy(gameObject);
    }
}
