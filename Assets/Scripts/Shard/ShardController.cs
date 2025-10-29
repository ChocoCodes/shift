using UnityEngine;

public class ShardMovement : MonoBehaviour
{
    [SerializeField] private Transform playerFollowPos;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerFollowPos.position;
    }
}
