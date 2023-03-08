using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject TestObject;
    private GameObject sphereObj;
    private GameObject sphereObjCopied;
    public BoxCollider A;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(TestObject.name);
        // TestObject.transform.Translate(1.0f, 10.0f, 100.0f);
        //TestObject.transform.localPosition = new Vector3(1.0f, 10.0f, 10.0f);
        //TestObject.transform.Rotate(1.0f, 10.0f, 100.0f);
        //TestObject.transform.localEulerAngles = new Vector3(1.0f, 10.0f, 10.0f);
        TestObject.transform.localScale = new Vector3(1.0f, 10.0f, 10.0f);
        TestObject.SetActive(true);
        Debug.Log(TestObject.activeSelf);
        Debug.Log(TestObject.activeInHierarchy);
        Debug.Log(TestObject != null);
        Destroy(TestObject, 4.5f);

        sphereObj = GameObject.Find("Sphere");
        //sphereObj.SetActive(false);
        sphereObjCopied = Instantiate(sphereObj, new Vector3(1.5f, 0.0f, 0.0f), Quaternion.identity);
        sphereObjCopied.name = "Sphere2";


    }

    // Update is called once per frame
    void Update()
    {

    }
}
