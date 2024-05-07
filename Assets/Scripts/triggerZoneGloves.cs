using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Playables;

public class triggerZoneGloves : MonoBehaviour
{
    public string targetTag;
    public UnityEvent<GameObject> OnEnterEvent;
    public Material newMaterial; // Reference to the new material to be applied
    private bool done = false;
    public AudioClip audioClip;
    public AudioClip audioClip1;
    public PlayableDirector timeline;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(targetTag) && !done)
        {
            OnEnterEvent.Invoke(other.gameObject);
            done = true;
        } else
        {
            if (!other.gameObject.CompareTag("Untagged") && !other.gameObject.CompareTag("Human") && timeline.state == PlayState.Paused && other.gameObject.CompareTag("gloveLeft"))
            {
                AudioSource.PlayClipAtPoint(audioClip1, new Vector3(9.36299992f, 1.10899997f, -0.841000021f));
            }
            else if (!other.gameObject.CompareTag("Untagged") && !other.gameObject.CompareTag("Human") && timeline.state == PlayState.Paused)
            {
                AudioSource.PlayClipAtPoint(audioClip, new Vector3(9.36299992f, 1.10899997f, -0.841000021f));
            } 
        }
    }

    // Method to change the material of the collided GameObject
    public void ChangeMaterial(GameObject obj)
    {
        Renderer rend = obj.GetComponent<Renderer>();
        if (rend != null && newMaterial != null)
        {
            rend.material = newMaterial;
        }
    }
}
