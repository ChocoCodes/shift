using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    // Reset the player back to the level spawn
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")) {
            PlayerController player = other.GetComponent<PlayerController>();

            if (player == null) {
                Debug.Log("Tagged Player has no PlayerController attached.");
                return;
            }

            Debug.Log("Respawning...");
            player.StartCoroutine(player.Respawn());
        }
    }
}
