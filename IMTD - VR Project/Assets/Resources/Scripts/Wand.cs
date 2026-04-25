using UnityEngine;

public class Wand : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private GameObject shield; // Reference to the wand model in the scene
    [SerializeField] private Transform shieldSpawnPlace; // Reference to the spawn place for the shield
    [SerializeField] private AudioSource protegoSound; // Reference to the sound effect for Protego spell

    [SerializeField] private Transform wandTip; // Reference to the tip of the wand for casting spells
    [SerializeField] private float spellRange = 10f; // Range for casting spells
    [SerializeField] private LayerMask layerMask; // Layer mask for floatable objects

    void Start()
    {
        
    }

    public void Alohamora()
    {
        Debug.Log("Alohamora spell casted!");
        // Add your spell casting logic here
    }

    public void Colloportus()
    {
        Debug.Log("Colloportus spell casted!");
        // Add your spell casting logic here
    }

    public void Lumos()
    {
        Debug.Log("Lumos spell casted!");
        // Add your spell casting logic here
    }

    public void Nox()
    {
        Debug.Log("Nox spell casted!");
        // Add your spell casting logic here
    }

    public void Stupefy()
    {
        Debug.Log("Stupefy spell casted!");
        // Add your spell casting logic here
    }

    public void Protego()
    {
        Instantiate(shield, shieldSpawnPlace.position, shieldSpawnPlace.rotation);
        protegoSound.Play(); // Play the sound effect for Protego spell
    }

    public void Expelliarmus()
    {
        Debug.Log("Expelliarmus spell casted!");
        // Add your spell casting logic here
    }

    public void Accio()
    {
        Ray ray = new Ray(wandTip.position, wandTip.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, spellRange, layerMask))
        {
            Accio accio = hit.collider.GetComponent<Accio>();
            if (accio != null)
            {
                accio.CastAccio(wandTip);
            }
        }
    }

    public void WingardiumLeviosa()
    {
        Debug.Log("Wingardium Leviosa spell casted!");
        // Add your spell casting logic here
    }

    public void Depulso()
    {
        Ray ray = new Ray(wandTip.position, wandTip.forward);
        if (Physics.Raycast(ray, out RaycastHit hit, spellRange, layerMask))
        {
            DepulsoTarget depulso = hit.collider.GetComponent<DepulsoTarget>();
            if (depulso != null)
            {
                depulso.CastDepulso(wandTip);
            }
        }
    }

}