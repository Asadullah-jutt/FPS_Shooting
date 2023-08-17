using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    public over a;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "EEEEE")
        {
            // Code to execute when the cube collides with an object tagged as "Player"
            Debug.Log("Cube collided with Wall!");
            // Perform additional actions or logic here

            a.enabled = true;

            Invoke("callend", 3f);

        }
    }

    public void callend()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
