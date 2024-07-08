using UnityEngine;

[ExecuteAlways]
public class BoxColliderVisualizer : MonoBehaviour
{
    private void OnDrawGizmos()
    {
        // Obtiene el BoxCollider adjunto al objeto
        BoxCollider boxCollider = GetComponent<BoxCollider>();
        if (boxCollider != null)
        {
            // Guarda el color original de Gizmos
            Gizmos.color = Color.green;

            // Dibuja el BoxCollider
            Gizmos.matrix = Matrix4x4.TRS(transform.position, transform.rotation, transform.localScale);
            Gizmos.DrawWireCube(boxCollider.center, boxCollider.size);
        }
    }
}
