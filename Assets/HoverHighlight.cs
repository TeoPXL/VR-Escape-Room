using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HoverHighlight : MonoBehaviour
{
    [SerializeField] public Material hoverMaterial; // Assign a highlight material in the Inspector
    private Material originalMaterial;
    private Renderer objectRenderer;

    void Awake()
    {
        objectRenderer = GetComponent<Renderer>();
        originalMaterial = objectRenderer.material;
    }

    // Called from the Hover Entered event
    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        if (hoverMaterial != null)
        {
            objectRenderer.material = hoverMaterial;
        }
    }

    // Called from the Hover Exited event
    public void OnHoverExited(HoverExitEventArgs args)
    {
        objectRenderer.material = originalMaterial;
    }
}