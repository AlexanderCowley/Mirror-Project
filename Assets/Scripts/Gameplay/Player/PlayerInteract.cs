using UnityEngine;

[SelectionBase]
public class PlayerInteract : MonoBehaviour
{
    Transform _rayCastTransform;
    [SerializeField] float InteractRange = 1.2f;
    Move _playerMovement;
    Vector3 FacingDirection;

    void Awake()
    {
        _rayCastTransform = transform.GetChild(0).transform;
        _playerMovement = GetComponent<Move>();
    }

    void Interact()
    {
        RaycastHit hit;
        if(Physics.Raycast(_rayCastTransform.position, FacingDirection, out hit, InteractRange))
            hit.transform.GetComponent<Interact>()?.OnInteract(true);
            
    }

    void OnDrawGizmos()
    {
        if(_rayCastTransform == null)
            return;
            
        //DrawRay does not have a max length parameter so just multiply it by direction
        Gizmos.color = Color.cyan;
        Gizmos.DrawRay(_rayCastTransform.position, FacingDirection * InteractRange);
    }

    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.E))
            Interact();

        if(_playerMovement != null && _playerMovement.FacingDirection != Vector3.zero)
            FacingDirection = _playerMovement.FacingDirection;
    }
}
