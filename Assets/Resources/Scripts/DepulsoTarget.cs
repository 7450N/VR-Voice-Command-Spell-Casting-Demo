using UnityEngine;

public class DepulsoTarget : MonoBehaviour
{
    public float impulseForce = 10f;
    public ParticleSystem depulsoBurst;

    [SerializeField] private AudioClip depulsoSoundClip; // Reference to the depulso sound effect

    private AudioSource depulsoSound;
    private Rigidbody rb;

   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        depulsoSound = GetComponent<AudioSource>();
    }

    public void CastDepulso(Transform wandTransform)
    {
        Vector3 direction = (transform.position - wandTransform.position).normalized;

        rb.AddForce(direction * impulseForce, ForceMode.Impulse);

        if (depulsoBurst != null)
        {
            depulsoBurst.transform.position = transform.position;
            depulsoBurst.Play();
        }

        if (depulsoSound != null)
        {
            depulsoSound.PlayOneShot(depulsoSoundClip); // Play the depulso sound effect
        }
    }
}