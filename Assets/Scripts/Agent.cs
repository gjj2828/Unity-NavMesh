using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Agent : MonoBehaviour
{
    public GameObject target;

    private NavMeshAgent mAgent;
    private WaitForSeconds mDelay = new WaitForSeconds(1.0f);
    private Vector3[] mTargets = new Vector3[2];

    // Start is called before the first frame update
    void Start()
    {
        mAgent = GetComponent<NavMeshAgent>();
        mTargets[0] = target.transform.position;
        mTargets[1] = transform.position;
        StartCoroutine(Nav());
    }

    // Update is called once per frame
    //void Update() {

    //}

    IEnumerator Nav() {
        //while(true) {
        //    transform.position = mOrigin;
        //    yield return mDelay;
        //    mAgent.SetDestination(mTarget);
        //    yield return mDelay;
        //    while(mAgent.remainingDistance > 0.01f) yield return mDelay;
        //    yield return mDelay;
        //}

        int targetId = 0;
        while(true) {
            mAgent.SetDestination(mTargets[targetId]);
            yield return mDelay;
            while(mAgent.remainingDistance > 0.01f) yield return mDelay;
            yield return mDelay;
            targetId = 1 - targetId;
        }
    }
}
