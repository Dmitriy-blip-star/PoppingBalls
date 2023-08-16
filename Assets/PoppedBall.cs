using UnityEngine;

public class PoppedBall : MonoBehaviour
{
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
