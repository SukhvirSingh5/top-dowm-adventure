using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour

{
    public float speed = 0.5f;
    public bool hasApple = false;

    public GameObject apple;

    public static PlayerController instance;

    // Start is called before the first frame update
    void Start()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        GameObject.DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPostion =  transform.position;

        if (Input.GetKey("w"))
        {
            newPostion.y += speed;
        }
       
        if (Input.GetKey("s"))
        {
            newPostion.y -= speed;
        }
       
        if (Input.GetKey("a"))
        {
            newPostion.x -= speed;
        }
        
        if (Input.GetKey("d"))
        {
            newPostion.x += speed;
        }

        transform.position = newPostion;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag.Equals("door"))
        {
            Debug.Log("hit");
            SceneManager.LoadScene(1);

        }

        if (collision.gameObject.tag.Equals("apple"))
        {
            Debug.Log("obtained Apple");
            apple.SetActive(false);
            hasApple= true;
        }

        if (collision.gameObject.tag.Equals("exit"))
        {
            Debug.Log("Hit");
            SceneManager.LoadScene(0);
        }
    }
}
 ///start game screen and add dilogs after add code for 5 apples and drop them in chest to open door and sleep and end game