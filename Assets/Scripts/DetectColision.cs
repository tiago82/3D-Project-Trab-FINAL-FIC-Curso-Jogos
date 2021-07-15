using UnityEngine;
using UnityEngine.SceneManagement;

public class DetectColision : MonoBehaviour
{
    public Animator _anim;
    public float contagem;
    public float tempo = 1f;
    public bool morreu = false;
    void Update()
    {
        if (morreu == true)
        {
            contagem += UnityEngine.Time.deltaTime;
            if (contagem >= tempo)
            {
                contagem = 0;
                morreu = false;
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.transform.tag == "obstaculo")
        {
            Debug.Log("Fim de jogo");
            _anim.SetTrigger("morte");
            morreu = true;
        }
    }
}
