using System;
using System.Collections;
using System.Collections.Generic;
using Platformer.Scripts;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Serialization;

public class CameraMovement : MonoBehaviour
{
    public TextMeshProUGUI coinText;
    public GameObject cam;

    private int coins = 0;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            cam.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            cam.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
        }
    }

    private void Update()
    {
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.name == "Brick(Clone)")
                {
                    Destroy(hit.transform.gameObject);
                }

                if (hit.transform.name == "Question(Clone)")
                {
                    coins++;
                    coinText.text = $"Coins: {coins}";
                }
            }
        }
    }
}
