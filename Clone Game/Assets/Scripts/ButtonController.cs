using UnityEngine;

public class ButtonController : MonoBehaviour
{
    [SerializeField] private DoorController door;

    private void OnTriggerEnter2D()
    {
        door.OpenDoor();
    }
    private void OnTriggerExit2D()
    {
        door.CloseDoor();
    }
}
