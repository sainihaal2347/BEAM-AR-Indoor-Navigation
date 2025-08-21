using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

namespace MyGameNamespace
{
    [System.Serializable]
    public class Target
    {
        public string Name;
        public GameObject PositionObject;
    }
}

public class SetNavigationTarget : MonoBehaviour
{
    [SerializeField]
    private TMP_Dropdown navigationTargetDropDown;
    [SerializeField]
    private List<MyGameNamespace.Target> navigationTargetObjects = new List<MyGameNamespace.Target>();

    private NavMeshPath path; // current calculated path
    private LineRenderer line; // linerenderer to display path
    private Vector3 targetPosition = Vector3.zero; // current target position
    private bool lineToggle = false;

    private void Start()
    {
        path = new NavMeshPath();
        line = GetComponent<LineRenderer>();

        if (line == null)
        {
            Debug.LogError("LineRenderer component not found.");
            return;
        }

        line.enabled = lineToggle;

        if (navigationTargetDropDown != null)
        {
            navigationTargetDropDown.onValueChanged.AddListener(SetCurrentNavigationTarget);
        }
        else
        {
            Debug.LogError("Dropdown not assigned.");
        }
    }

    private void Update()
    {
        if (lineToggle && targetPosition != Vector3.zero && path != null)
        {
            NavMesh.CalculatePath(transform.position, targetPosition, NavMesh.AllAreas, path);
            if (path.corners.Length > 0)
            {
                line.positionCount = path.corners.Length;
                line.SetPositions(path.corners);
            }
        }
    }

    public void SetCurrentNavigationTarget(int selectedValue)
    {
        targetPosition = Vector3.zero;

        if (navigationTargetDropDown == null)
        {
            Debug.LogError("Dropdown not assigned.");
            return;
        }

        string selectedText = navigationTargetDropDown.options[selectedValue].text;
        var currentTarget = navigationTargetObjects.Find(x => x.Name.Equals(selectedText));

        if (currentTarget != null && currentTarget.PositionObject != null)
        {
            targetPosition = currentTarget.PositionObject.transform.position;
        }
        else
        {
            Debug.LogWarning("Selected target or target position is null.");
        }
    }

    public void ToggleVisibility()
    {
        lineToggle = !lineToggle;
        if (line != null)
        {
            line.enabled = lineToggle;
        }
        else
        {
            Debug.LogError("LineRenderer component not found.");
        }
    }
}
