using UnityEngine;
using DG.Tweening;

public class Accio : MonoBehaviour
{
    public float pullDuration = 1.5f;
    public float stopDistance = 0.5f;
    public Ease tweenEase = Ease.OutQuad;

    private Rigidbody rb;
    private bool isBeingPulled = false;

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip accioSound; // Sound to play when Accio is cast
    [SerializeField] private TrailRenderer trailRenderer; 
    public void CastAccio(Transform wandTransform)
    {
        if (isBeingPulled) return;

        isBeingPulled = true;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.linearVelocity = Vector3.zero;

        if (audioSource != null && accioSound != null)
        {
            audioSource.PlayOneShot(accioSound); // Play the Accio sound effect
        }
        Vector3 targetPos = wandTransform.position + wandTransform.forward * stopDistance;
        if (trailRenderer != null)
        {
            trailRenderer.transform.position = transform.position; // Set the trail's start position
            trailRenderer.Clear(); // Clear any previous trail
            trailRenderer.enabled = true; // Enable the trail renderer
        }

        transform.DOMove(targetPos, pullDuration)
            .SetEase(tweenEase)
            .OnComplete(() =>
            {
                rb.useGravity = true;
                isBeingPulled = false;
                if (trailRenderer != null)
                {
                    trailRenderer.enabled = false; // Disable the trail renderer after the pull is complete
                }
            });
    }
}