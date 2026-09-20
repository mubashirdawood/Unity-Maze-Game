
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the goal is the player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Congratulations! You reached the goal!");

            // Make the goal disappear
            gameObject.SetActive(false);
        }
    }
}