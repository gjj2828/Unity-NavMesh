using UnityEngine;
using UnityEngine.AI;

public class NavMeshMgr : MonoBehaviour
{
    public NavMeshData data;

    private NavMeshDataInstance mInstance;

    // Start is called before the first frame update
    void Start()
    {
        mInstance = NavMesh.AddNavMeshData(data);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
