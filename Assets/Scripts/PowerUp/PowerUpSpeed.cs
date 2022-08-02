using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public GameObject obj;

    public void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag =="Player")
        {
            playerMovement.speed = playerMovement.maxSpeed;
            Destroy(obj);
        }
    }
}
