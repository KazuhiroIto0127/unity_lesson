using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TestScript : MonoBehaviour
{
    public GameObject TestObject;
    public BoxCollider A;
    public TestTest Z;
    [SerializeField] private Text Text;
    public RectTransform RT;
    public Image PenguinImage;
    public Sprite ImageSprite;
    public AudioSource Bgm;
    public AudioClip ShakinSound;
    public GameObject CubeBoxB;
    private int i = 0;

    private void Awake()
    {
        Debug.Log("Awake �Ăяo��");
        enabled = false; // �X�N���v�g���̖̂�����
        enabled = true; // �X�N���v�g���̗̂L����

        Slime slime = new Slime("�X���C������", 100, 200, 300);
        slime.printDetail();
        Slime slahyon = new Slime("�X���q����", 300, 100, 500);
        slahyon.printDetail();
        slahyon.SetHp(-10);
        slahyon.Lucky = 100;
        Debug.Log($"{slahyon.title} {slahyon.GetHp()} {slahyon.Lucky}");

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
        AudioOperation();
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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("�E���L�[��������Ă��܂��B");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("�����L�[��������Ă��܂��B");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("����L�[��������Ă��܂��B");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("�����L�[��������Ă��܂��B");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Space�L�[��������Ă��܂��B");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("���N���b�N�B");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("�E�N���b�N�B");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("���N���b�N�B");
        }
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
        Debug.Log(i);
        GameObject sphereObj = GameObject.Find("Sphere");
        //sphereObj.SetActive(false);
        GameObject sphereObjCopied = Instantiate(
            sphereObj, 
            new Vector3(getRandomPosition(), getRandomPosition(), getRandomPosition()),
            Quaternion.identity);
        sphereObjCopied.name = $"Sphere{i++}";
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

    private float getRandomPosition()
    {
        return Random.Range(0.0f, 10.0f);
    }
    /*
    * Text
    */
    void TextOperation()
    {
        int val = Random.Range(0, 10);
        Text.text = $"{val}AB\nCD\nEF";
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
        Invoke("PlayBgm", 3.0f);
    }

    private void PlayBgm()
    {
        Bgm.Play();
    }

    void ClickButtonAction()
    {
        //Debug.Log("button clicked");
        //Bgm.Play();
        Bgm.PlayOneShot(ShakinSound);
        ObjectOperation();
    }

    public void ButtonOperation()
    {
        GameObject Button = GameObject.Find("SoundPlayButton");
        Button b = Button.GetComponent<Button>();
        b.onClick.AddListener(ClickButtonAction);
        b.onClick.Invoke();
    }
}
