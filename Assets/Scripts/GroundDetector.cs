using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.name == "Ground")
        {
            transform.parent.GetComponent<Player>().isground = true;
        }
    }
    private void OnTriggerExit2D(Collider2D obj)
    {
        if (obj.name == "Ground")
        {
            transform.parent.GetComponent<Player>().isground = false;
        }
    }
}
