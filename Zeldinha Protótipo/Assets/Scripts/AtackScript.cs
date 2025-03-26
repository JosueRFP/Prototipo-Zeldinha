using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackScript : MonoBehaviour
{
    [SerializeField] float damege = -1;
    [SerializeField] PlayerController playerMov;
    [SerializeField] EnemyController enemyController;
    public LayerMask layerMask;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMov = GetComponent<PlayerController>();
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
