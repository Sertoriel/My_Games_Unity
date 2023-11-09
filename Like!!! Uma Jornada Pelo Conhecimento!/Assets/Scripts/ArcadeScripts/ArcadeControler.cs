using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArcadeControler : MonoBehaviour
{
    public ParticleSystem JumpEfx;
    public ParticleSystem RunEfx;
    public ParticleSystem Dead;

    private AudioSource playerAudio; //executa os sons do player pulo andar e hit
    public AudioClip jumpAud;
    public AudioClip hitAud;
    public AudioClip pointAud;


    private Rigidbody playerRG; //Corpo rigido player.
    private Animator animaLike; //Animador do Persona.
    public Animator transition; //Animação de transição.

    public float jumpForce = 10f; //força do pulo.
    public float gravityModifier = 1f; //Grav do Game.
    public bool isonGround = true; //Verifica is on ground.
    public int JumpCount = 0; //quantidade de Pulos.
    public static int WonlevelC = 0;
    public float transitionTime = 1f;// tempo da transição.

    //variaveis para touch

    private Touch tocou;

    // Start is called before the first frame update
    void Start() // COMPONENTE START DO PLAYER INICIALIZANDO O PERSONA COLETANDO SEUS COMPONENTES E SETANDO FISICAS E TAMBEM IVOCANDO A REPETIÇÃO DE SOMA DE VELOCIDADE. 
    {

        playerRG = GetComponent<Rigidbody>();
        animaLike = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update() // CONTROLE DE PULO.
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonGround && !GameControler.gameOver)
        {
            playerAudio.PlayOneShot(jumpAud);
            JumpEfx.Play();
            RunEfx.Stop();
            animaLike.SetBool("Jump", true);
            playerRG.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            JumpCount++;
        }

        if (JumpCount == 2)
        {
            isonGround = false;
        }
// CONTROLE DE PULO tOUCH.
        if (Input.touchCount > 0 && isonGround)
        {
            tocou = Input.GetTouch(0);
            if (tocou.phase == TouchPhase.Began)
            {
                playerAudio.PlayOneShot(jumpAud);
                JumpEfx.Play();
                RunEfx.Stop();
                animaLike.SetBool("Jump", true);    
                playerRG.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                JumpCount++;
            }
        }

        if (JumpCount == 2)
        {
            
            isonGround = false;

        }

    }

    private void OnCollisionEnter(Collision collision) //CONTROLE DE COLIISÕES, E SEUS ESTADOS ANTES E DEPOIS.
    {

        if(collision.gameObject.CompareTag("Ground"))
        {

            animaLike.SetBool("Jump", false );
            isonGround = true;
            JumpCount = 0;
            RunEfx.Play();

        }else if (collision.gameObject.CompareTag("Points"))
        {
            
            GameControler.score += 10;
            playerAudio.PlayOneShot(pointAud);
            
        }else if (collision.gameObject.CompareTag("Obstacles"))
        {

            RunEfx.Stop();
            Dead.Play();
            Destroy(animaLike);
            GameControler.gameOver = true;// Game Over
            //anima dead
            animaLike.SetBool("Dead",true);
            //go game over scr
            playerAudio.PlayOneShot(hitAud);
            Invoke("GoGameover", 5f);
            
        }else if (collision.gameObject.CompareTag("Boss"))
        {

            RunEfx.Stop();
            Dead.Play();
            Destroy(animaLike);
            GameControler.gameOver = true;
            animaLike.SetBool("Dead",true);
            playerAudio.PlayOneShot(hitAud);
            Invoke("GoGameover", 5f);

        }
        
    }

    void GoGameover()
    {

        SceneManager.LoadScene("GameOver");

    }

}
