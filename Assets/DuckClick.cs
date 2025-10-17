using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DuckClick : MonoBehaviour
{
    [SerializeField] private AudioSource clickSound; // Assign your sound in the Inspector

    // Called when the object is clicked / selected
    public void OnDuckClicked(SelectEnterEventArgs args)
    {
        if (clickSound != null)
        {
            clickSound.Play();
        }
        else
        {
            Debug.LogWarning("No AudioSource assigned to DuckClick script on " + gameObject.name);
        }
    }
}
