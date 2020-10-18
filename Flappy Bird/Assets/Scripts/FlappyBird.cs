using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FlappyBird : MonoBehaviour
{
    public int score = 0;
    public float jumpForce = 5;
    public Text scoreText;
    public Canvas gameOver;
    public Button startOver;
    public GameObject projectile;
    //public Text scoreText2;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.enabled = false;
        startOver.onClick.AddListener(() => {
            SceneManager.LoadScene(0);
        });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            Vector3 oldVelocity = GetComponent<Rigidbody>().velocity;
            GetComponent<Rigidbody>().velocity = new Vector3(oldVelocity.x, jumpForce, 0);
        }

        if(Input.GetKeyDown(KeyCode.V)){
            GameObject newProjectile = Instantiate(projectile, this.transform.position + new Vector3(1, 0, 0), projectile.transform.rotation);
            newProjectile.GetComponent<Rigidbody>().velocity = new Vector3(2, 0, 0);
        }
    }


    private void OnCollisionEnter(Collision pipePair){
        gameOver.enabled = true;
        scoreText.text += score.ToString();
    }

    private void OnTriggerEnter(Collider pass){
        score++;
        //scoreText2.text = "Score: " + score.ToString();
    }
}
