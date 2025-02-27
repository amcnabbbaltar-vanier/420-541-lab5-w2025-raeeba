using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
    }

public void GotHit()
    {
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();
        GameManager.Instance.IncrementScore();
    }
}