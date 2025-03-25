using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackScript : MonoBehaviour
{
    [SerializeField] float damege;
    [SerializeField] PlayerMov playerMov;
    [SerializeField] EnemyController enemyController;

    // Start is called before the first frame update
    void Start()
    {
        playerMov = GetComponent<PlayerMov>();
        enemyController = GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { 

        }
    }
}
