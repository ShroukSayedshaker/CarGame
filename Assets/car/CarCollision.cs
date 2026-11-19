using UnityEngine;

public class CarCollision : MonoBehaviour
{
    public AudioClip crashSound;

    void OnCollisionEnter(Collision theCollision)
    {
        Debug.Log("Hit: " + theCollision.gameObject.name);

        if (theCollision.gameObject.name == "Wall")
        {
            GetComponent<AudioSource>().PlayOneShot(crashSound);
        }
    }
}