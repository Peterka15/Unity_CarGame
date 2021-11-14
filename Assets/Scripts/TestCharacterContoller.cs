using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TestCharacterContoller: MonoBehaviour
{
        public float movementSpeed = 20f;
        public SpawnManager spawnManager;
        public GameManager gameManager;
        public bool isFlat = true;
        private Rigidbody rigid;

    // Start is called before the first frame update
        void Start()
            {
                rigid = GetComponent<Rigidbody>();
            }

    // Update is called once per frame
        void Update()
            {
        float hMovement =Input.acceleration.x * movementSpeed / 2;
        

        Vector3 tilt = Input.acceleration;
        transform.Translate(new Vector3(hMovement,0,movementSpeed) * Time.deltaTime);
         if(transform.position.x > -4)
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
        if (transform.position.x <-21)
            transform.position = new Vector3(-21, transform.position.y, transform.position.z);
            }

        

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="SpawnTrigger"){
            spawnManager.SpawnTriggerEntered();
        }
        
        if (other.tag == "Coin"){
            gameManager.CoinCollected();
            Destroy(other.gameObject);
        }

        if (other.tag == "Traffic"){
            
            gameManager.GameOver();
            Time.timeScale = 0;
           
        }

    }

    


}
