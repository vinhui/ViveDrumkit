using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]
public class OnCollision : MonoBehaviour
{
    public CollisionEvent onCollisionEnter = new CollisionEvent();
    [Tooltip("Leave empty to match any")]
    public string requiredTag;

    public void OnCollisionEnter(Collision collision)
    {
            Debug.Log(collision.gameObject.name+"sdfsdfsdf");
        if (string.IsNullOrEmpty(requiredTag) || collision.gameObject.tag == requiredTag)
        {
            onCollisionEnter.Invoke(collision);
        }
    }

    [System.Serializable]
    public class CollisionEvent : UnityEvent<Collision> { }
}
