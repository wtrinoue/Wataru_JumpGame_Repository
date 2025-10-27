using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Playerタグのオブジェクトと接触したら
        if (other.name == "Goal")
        {
            Debug.Log("Goal reached!");
        }
    }
}