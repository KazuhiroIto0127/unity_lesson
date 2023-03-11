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
        Debug.Log("Awake 呼び出し");
        enabled = false; // スクリプト自体の無効化
        enabled = true; // スクリプト自体の有効化

        Slime slime = new Slime("スライムさん", 100, 200, 300);
        slime.printDetail();
        Slime slahyon = new Slime("スラヒョン", 300, 100, 500);
        slahyon.printDetail();
        slahyon.SetHp(-10);
        slahyon.Lucky = 100;
        Debug.Log($"{slahyon.title} {slahyon.GetHp()} {slahyon.Lucky}");

    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start 呼び出し");
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
        Debug.Log("OnEnable関数が呼び出されました");
    }

    private void OnDisable()
    {
        Debug.Log("OnDisable関数が呼び出されました");
    }

    private void OnDestroy()
    {
        Debug.Log("OnDestroy関数が呼び出されました");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("右矢印キーが押されています。");
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("左矢印キーが押されています。");
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("上矢印キーが押されています。");
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("下矢印キーが押されています。");
        }
        if (Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Spaceキーが押されています。");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("左クリック。");
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("右クリック。");
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("中クリック。");
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
     *  Gameオブジェクトの取得とコピー
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
     *  コンポーネント（機能）の操作
     */
    void ComponentOperation()
    {
        Z.B = "変更しました";
        Z.CCC();

        GameObject box = GameObject.Find("CubeA");
        BoxCollider b = box.GetComponent<BoxCollider>();
        b.size = new Vector3(3.0f, 3.0f, 3.0f);

        Rigidbody rb = box.AddComponent<Rigidbody>();
        rb.mass = 5.0f;

        Destroy(rb, 2.0f); // コンポーネント削除
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
        RT.localPosition = new Vector3(0.0f, 0.0f, 0.0f); // 位置を変更
        RT.sizeDelta = new Vector2(200.0f, 50.0f); // 幅、高さ
    }

    /*
     * 画像
     */
    void ImageOperation()
    {
        PenguinImage.sprite = ImageSprite;
        RectTransform ImageRT = PenguinImage.GetComponent<RectTransform>();
        ImageRT.localPosition = new Vector3(30.0f, 30.0f, 30.0f); // 位置を変更
        ImageRT.sizeDelta = new Vector2(100.0f, 100.0f); // 幅、高さ
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
