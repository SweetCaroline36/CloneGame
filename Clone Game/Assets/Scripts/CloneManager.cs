using UnityEngine;

public class CloneManager : MonoBehaviour
{
    [SerializeField] private GameObject clonePrefab;

    private GameObject activePlayerClone;

    void Start()
    {
        activePlayerClone = Instantiate(clonePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }

    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            activePlayerClone.GetComponent<PlayerMovement>().killClone();
            activePlayerClone = Instantiate(clonePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
    }
}
