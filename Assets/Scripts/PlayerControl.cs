using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Vector3 vel;
    public Rigidbody _rigidbody;
    public float lado = 8.0f;
    public bool noChao = true;
    public GameObject menupause;
    int pause = 0;
    public AudioSource _sfx;
    public Animator _anim;
    //public float gravidade = -1.0f;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        // Physics.gravity = Physics.gravity * 4.7f;
        //Physics.gravity = new Vector3(0.0f, gravidade,0.0f);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            right();
        }
        //verificar se está no chao para poder pular
        if (noChao == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                noChao = false;
                _rigidbody.velocity = new Vector3(0.0f, vel.y, 0.0f);
                _anim.SetTrigger("jumpa");
                _sfx.Play();

            }
        }
        //pausar game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (pause)
            {
                case 0:
                    Debug.Log("pause");
                    menupause.gameObject.SetActive(true);
                    Time.timeScale = 0;
                    pause = 1;
                    break;
                case 1:
                    Debug.Log("continue");
                    menupause.gameObject.SetActive(false);
                    Time.timeScale = 1;
                    pause = 0;
                    break;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "chao")
        {
            noChao = true;
        }
    }

    public void left()
    {
        transform.Translate(Vector3.left * Time.deltaTime * lado);
    }
    public void right()
    {
        transform.Translate(Vector3.right * Time.deltaTime * lado);
    }
}


