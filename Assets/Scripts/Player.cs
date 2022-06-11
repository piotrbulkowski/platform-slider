using Assets.Scripts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

    public void Update()
    {
        if (GameManager.Instance.IsGameRunning())
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
