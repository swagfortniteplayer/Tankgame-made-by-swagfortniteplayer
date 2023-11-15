using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tankcontroller : MonoBehaviour
{
    public float rspeed = 0.5f;
    
    public float speed = 1f;

    public GameObject BulletPrefab;
    public Transform BulletSpawnPoint;

    public KeyCode shoot;
    public KeyCode forward;
    public KeyCode backward;
    public KeyCode right;
    public KeyCode left;

    private void OnDestroy()
    {
        SceneManager.LoadScene(0);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(forward))
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }

        if (Input.GetKey(backward))
        {
            GetComponent<Rigidbody>().AddForce(-transform.forward * rspeed);
        }

        if (Input.GetKey(right))
        {
            transform.Rotate(0f, 40f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(left))
        {
            transform.Rotate(0f, -40f * Time.deltaTime, 0f);
        }
        if (Input.GetKeyDown(shoot))
        {
            Shoot();
        }
    }


        void Shoot() {
           GameObject bullet = Instantiate(BulletPrefab, BulletSpawnPoint.position, BulletSpawnPoint.rotation);
        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
    }



    }




