using UnityEngine;

public class CarCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Wall")
        {
            Debug.Log("Hit the wall");
        }
    }
}