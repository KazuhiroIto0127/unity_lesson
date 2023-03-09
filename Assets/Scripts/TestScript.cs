using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject TestObject;
    private GameObject sphereObj;
    private GameObject sphereObjCopied;
    private GameObject box;
    public BoxCollider A;
    public TestTest Z;
    public Text Text;

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
        A.size = new Vector3(10.0f, 10.0f, 10.0f);
        Debug.Log(TestObject.activeSelf);
        Debug.Log(TestObject.activeInHierarchy);
        Debug.Log(TestObject != null);
        Destroy(TestObject, 4.5f);

        sphereObj = GameObject.Find("Sphere");
        //sphereObj.SetActive(false);
        sphereObjCopied = Instantiate(sphereObj, new Vector3(1.5f, 0.0f, 0.0f), Quaternion.identity);
        sphereObjCopied.name = "Sphere2";

        /*
         *  コンポーネント（機能）の操作
         */
        Z.B = "変更しました";
        Z.CCC();

        box = GameObject.Find("CubeA");
        BoxCollider b = box.GetComponent<BoxCollider>();
        b.size = new Vector3(3.0f, 3.0f, 3.0f);

        Rigidbody rb = box.AddComponent<Rigidbody>();
        rb.mass = 5.0f;

        Destroy(rb, 2.0f); // コンポーネント削除

        Text.text = "AB\nCD\nEF";
    }

    // Update is called once per frame
    void Update()
    {

    }
}
