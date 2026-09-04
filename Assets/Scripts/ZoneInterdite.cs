using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        // filtrer l'objet touché.
        if (!autre.CompareTag("Player"))
        {
            return;
        }
        // empêcher le déplacement si PointDepart est absent.
        if (pointDepart == null)
        {
            Debug.LogError("Le point de départ n'est pas assigné.");
        }

        // retourner le joueur à sa position initiale.
        autre.transform.position = pointDepart.position;
        Debug.Log("Le robot retourne au point de départ.");
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * La ligne return; doit être utilisée aux deux endroits appropriés.
     *
     * 
     * 
     * 
     * 
     * 
     * 
     */
}
