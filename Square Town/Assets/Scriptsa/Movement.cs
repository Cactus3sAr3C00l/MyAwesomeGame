
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float ForwardSpeed= 1400f;
    public float Right = 500f, Left = -500f,  Up= 500f;
    public Transform player;
    public bool AllowJumping=true;
    public float score2 = 0;
    float i = 0;
    // Start is called before the first frame update

    void Start()
    {
        Debug.Log("Test1");
       


    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        
        score2 = int.Parse((Time.timeSinceLevelLoad).ToString("0"));

        
       
        if(SceneManager.GetActiveScene().buildIndex == 1 && (score2%5 == 0) && score2 != 0 && i != score2)
           {

            ForwardSpeed += 250f;
            i = score2;
          Debug.Log(ForwardSpeed);

           }
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);


        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            
            if (rb.position.y < 1.02 && rb.position.y > -1 && player.position.x<9 && player.position.x>-9 )
            {
                AllowJumping = true;
            }
            if (Input.touchCount >= 2 && AllowJumping == true )
            {
                rb.AddForce(0, Up* Time.deltaTime, 0, ForceMode.VelocityChange);
                AllowJumping = false;
            }
            else if (touch.position.x > (Screen.width / 2 ))
                {
                    rb.AddForce(Right * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             
                }
             else
                {
                    rb.AddForce(Left * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
             
            }



        }
       if(rb.position.y < -1f)
        {
            Debug.Log(rb.position.y);
            if(SceneManager.GetActiveScene().buildIndex == 1) {
                FindObjectOfType<GameManagerInf>().EndGame();
            }else
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
