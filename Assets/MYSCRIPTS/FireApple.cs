using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireApple : MonoBehaviour
{

    public float appleSpeed = 5f;
    private bool stop = false;

    public void Start()
    {
        StartCoroutine(go());
    }
    IEnumerator go()
    {
        Destroy(gameObject, 50);

        while (true)
        {
            transform.position += transform.forward * Time.deltaTime * appleSpeed;

            if (stop)
            {
                break;
            }
            yield return null;
        }
    }

    void OnCollisionEnter(Collision col)

    {
        if (col.gameObject.tag == "Snake")
        {
            Debug.Log(col.gameObject.name);
            stop = true;
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.useGravity = true;
            col.gameObject.GetComponent<AudioSource>().Play();
            GetComponent<Collider>().enabled =false;
         
            Instantiate(col.gameObject,Vector3.zero,  Quaternion.identity);
          

        }


    }
}
