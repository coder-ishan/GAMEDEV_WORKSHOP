using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody player;
    public float F=40;
    public Text scoreText;
    private int score ;
    void Start()
    {
        player = GetComponent<Rigidbody>();
        score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W))
        {
            player.AddForce(0, 0, F);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            player.AddForce(0, 0, -1 * F);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            player.AddForce(-1 * F, 0, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            player.AddForce(F, 0, 0);
           
        }
        scoreText.text = score.ToString();
        Debug.Log(score);

    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log(score);
        }
        else if (other.gameObject.CompareTag("ded"))
        {
            Destroy(gameObject);
            score--;
            Debug.Log(score);
            SceneManager.LoadScene("gameOver");
        }

    }
}
