using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossHP : MonoBehaviour {
    public int starting_Health = 500;
    public int current_Health;
    public int scoreValue = 10000;
    public AudioClip deathClip;
    public GameObject game;
    public GameObject player;
    private Done_GameController g;
    private Done_PlayerController p;

    AudioSource enemyAudio;
    ParticleSystem hitParticles;
    CapsuleCollider capsuleCollider;
    bool isDead;

    void Awake()
    {
        enemyAudio = GetComponent<AudioSource>();
      //  hitParticles = GetComponentInChildern<ParticleSystem>();
        capsuleCollider = GetComponent<CapsuleCollider>();
        current_Health = starting_Health;
    }

    void Update()
    {
        
    }

    public void TakeDamage(int amount, Collider other,Vector3 hitPoint)
    {
        p = player.GetComponent<Done_PlayerController>();

        amount = p.damage;
        enemyAudio.Play();

        current_Health -= amount;

        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if (current_Health <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        capsuleCollider.isTrigger = true;
        enemyAudio.clip = deathClip;
        enemyAudio.Play();
    }

    public void Dying()
    {
        g = game.GetComponent<Done_GameController>();
        g.AddScore(scoreValue);
        Destroy(gameObject, 2f);

    }
}
