using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject TestObject;
    public BoxCollider A;
    public TestTest Z;
    public Text Text;
    public RectTransform RT;
    public Image PenguinImage;
    public Sprite ImageSprite;
    public AudioSource Bgm;
    public AudioClip ShakinSound;
    public GameObject CubeBoxB;

    private void Awake()
    {
        Debug.Log("Awake �Ăяo��");
        enabled = false; // �X�N���v�g���̖̂�����
        enabled = true; // �X�N���v�g���̗̂L����
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start �Ăяo��");
        BasicOperation();
        ObjectOperation();
        ComponentOperation();
        TextOperation();
        ImageOperation();
        //AudioOperation();
        ButtonOperation();
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable�֐����Ăяo����܂���");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable�֐����Ăяo����܂���");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy�֐����Ăяo����܂���");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void BasicOperation()
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
    }

    /*
     *  Game�I�u�W�F�N�g�̎擾�ƃR�s�[
     */
    void ObjectOperation()
    {
        GameObject sphereObj = GameObject.Find("Sphere");
        //sphereObj.SetActive(false);
        GameObject sphereObjCopied = Instantiate(sphereObj, new Vector3(1.5f, 0.0f, 0.0f), Quaternion.identity);
        sphereObjCopied.name = "Sphere2";
    }

    /*
     *  �R���|�[�l���g�i�@�\�j�̑���
     */
    void ComponentOperation()
    {
        Z.B = "�ύX���܂���";
        Z.CCC();

        GameObject box = GameObject.Find("CubeA");
        BoxCollider b = box.GetComponent<BoxCollider>();
        b.size = new Vector3(3.0f, 3.0f, 3.0f);

        Rigidbody rb = box.AddComponent<Rigidbody>();
        rb.mass = 5.0f;

        Destroy(rb, 2.0f); // �R���|�[�l���g�폜
    }
    
    /*
    * Text
    */  
    void TextOperation()
    {
        Text.text = "AB\nCD\nEF";
        RT.localPosition = new Vector3(0.0f, 0.0f, 0.0f); // �ʒu��ύX
        RT.sizeDelta = new Vector2(200.0f, 50.0f); // ���A����
    }

    /*
     * �摜
     */
    void ImageOperation()
    {
        PenguinImage.sprite = ImageSprite;
        RectTransform ImageRT = PenguinImage.GetComponent<RectTransform>();
        ImageRT.localPosition = new Vector3(30.0f, 30.0f, 30.0f); // �ʒu��ύX
        ImageRT.sizeDelta = new Vector2(100.0f, 100.0f); // ���A����
    }

    void AudioOperation()
    {
        Bgm.Play();
    }

    void PlayShakinSound()
    {
        //Debug.Log("button clicked");
        //Bgm.Play();
        Bgm.PlayOneShot(ShakinSound);
    }

    public void ButtonOperation()
    {
        GameObject Button = GameObject.Find("SoundPlayButton");
        Button b = Button.GetComponent<Button>();
        b.onClick.AddListener(PlayShakinSound);
        b.onClick.Invoke();
    }
}
