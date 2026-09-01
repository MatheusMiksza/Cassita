using UnityEngine;

public class AplicadorMaterial : MonoBehaviour
{
    public Material materialParede;
    public Material materialPiso;
    public Material materialForro;

    [ContextMenu("Aplicar Materiais")]
    void AplicarMateriais()
    {
        foreach (Renderer rend in GetComponentsInChildren<Renderer>())
        {
            if (rend.CompareTag("parede"))
                rend.sharedMaterial = materialParede;

            else if (rend.CompareTag("piso"))
                rend.sharedMaterial = materialPiso;

            else if (rend.CompareTag("forro"))
                rend.sharedMaterial = materialForro;
        }
    }
}