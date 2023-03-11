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
        Debug.Log(other.gameObject.name + "‚ÆÚGŠJn");
    }

    private void OnCollisionStay(Collision other)
    {
        Debug.Log(other.gameObject.name + "‚ÆÚG’†");
    }

    private void OnCollisionExit(Collision other)
    {
        Debug.Log(other.gameObject.name + "‚ÆÚGI—¹");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + "‚ÆÚGŠJn(“§‰ß)");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + "‚ÆÚG’†(“§‰ß)");
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + "‚ÆÚGI—¹(“§‰ß)");
    }
}
