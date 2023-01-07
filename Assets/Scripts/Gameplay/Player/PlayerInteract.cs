using UnityEngine;
public class PlayerInteract : MonoBehaviour
{
    Transform _rayCastTransform;
    [SerializeField] float InteractRange = 1.2f;

    void Awake() => _rayCastTransform = transform.GetChild(0).transform;
    void Interact()
    {
        RaycastHit hit;
        if(Physics.Raycast(_rayCastTransform.position, Vector3.right, out hit, InteractRange))
            hit.transform.GetComponent<Interact>()?.OnInteract();
    }

    void OnDrawGizmos()
    {
        if(_rayCastTransform == null)
            return;
            
        //DrawRay does not have a max length parameter so just multiply it by direction
        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(_rayCastTransform.position, Vector3.right * InteractRange);
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E))
            Interact();
    }
}
