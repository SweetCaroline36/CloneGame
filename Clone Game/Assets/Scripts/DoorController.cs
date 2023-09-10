using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 startingPos, endPos;
    private IEnumerator activeCoroutine;
    
    void Start()
    {
        startingPos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y, 0);
        endPos = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 2.3f, 0);
    }

    public void OpenDoor()
    {
        if (activeCoroutine != null)
        {
            StopCoroutine(activeCoroutine);
        }
        activeCoroutine = DoorSlideUp();
        StartCoroutine(activeCoroutine);
    }
    public void CloseDoor()
    {
        if (activeCoroutine != null)
        {
            StopCoroutine(activeCoroutine);
        }
        activeCoroutine = DoorSlideDown();
        StartCoroutine(activeCoroutine);
    }

    public IEnumerator DoorSlideUp()
    {
        while (this.gameObject.transform.position.y < endPos.y)
        {
            //print(this.gameObject.transform.position.y + " < " + endPos.y);
            this.gameObject.transform.position += new Vector3(0, 0.04f * speed, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
    public IEnumerator DoorSlideDown()
    {
        while (this.gameObject.transform.position.y > startingPos.y)
        {
            this.gameObject.transform.position -= new Vector3(0, 0.04f * speed, 0);
            yield return new WaitForSeconds(0.02f);
        }
    }
}
