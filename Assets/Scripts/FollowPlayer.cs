using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Vector3 offsets = new Vector3(0, 4, -10);
     
     

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position +offsets;

    }
}
