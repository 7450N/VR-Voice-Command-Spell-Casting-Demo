using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created  
    [SerializeField] private float shieldDuration = 5f;

    void Start()
    {
        StartCoroutine(ShieldLifespan(shieldDuration));
    }

    IEnumerator ShieldLifespan(float duration)
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }
}
