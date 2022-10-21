using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class V_Absoltion : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    Transform targetTransform;
    public void OnTriggerStay(Collider other)
    {
        if (other.transform.TryGetComponent(out IInteraction target))
        {
            Vector3 direction = (targetTransform.position - other.transform.position - Physics.gravity).normalized;
            target.rigi.AddForce(direction * speed);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.TryGetComponent(out IInteraction target))
        {
            target.MoveStop();
        }
    }
}
