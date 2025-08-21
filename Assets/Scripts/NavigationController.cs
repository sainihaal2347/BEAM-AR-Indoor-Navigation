using UnityEngine;
using UnityEngine.AI;

public class NavigationController : MonoBehaviour
{
    [SerializeField]
    private Transform targetTransform; // Target object to navigate to

    private NavMeshPath calculatedPath;

    public NavMeshPath CalculatedPath
    {
        get
        {
            if (calculatedPath == null || calculatedPath.corners.Length == 0)
            {
                CalculatePath();
            }
            return calculatedPath;
        }
    }

    public Vector3 TargetPosition
    {
        get
        {
            return targetTransform != null ? targetTransform.position : Vector3.zero;
        }
    }

    private void Start()
    {
        calculatedPath = new NavMeshPath();
    }

    public void SetTarget(Transform newTarget)
    {
        targetTransform = newTarget;
        CalculatePath();
    }

    private void CalculatePath()
    {
        if (targetTransform != null)
        {
            NavMesh.CalculatePath(transform.position, targetTransform.position, NavMesh.AllAreas, calculatedPath);
        }
    }
}
