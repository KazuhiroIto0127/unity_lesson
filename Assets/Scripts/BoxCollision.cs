using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG�J�n");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG��");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG�I��");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG�J�n(����)");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG��(����)");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "�ƐڐG�I��(����)");
    }
}
