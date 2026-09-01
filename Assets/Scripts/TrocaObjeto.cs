using UnityEngine;

[ExecuteAlways]
public class TrocaObjeto : MonoBehaviour
{
    [SerializeField] private GameObject object1;
    [SerializeField] private GameObject object2;

    private bool ultimoEstadoObject1;

    private void OnValidate()
    {
        if (Application.isPlaying)
            return;

        if (object1 == null || object2 == null)
            return;

        if (object1.activeSelf) { object1.SetActive(true); object1.SetActive(false); };
        if (object2.activeSelf) { object1.SetActive(true); object2.SetActive(false); };
    }
}