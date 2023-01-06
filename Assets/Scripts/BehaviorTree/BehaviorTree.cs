using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorTree : MonoBehaviour
{
    List<BehaviorNode> behaviourNodes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddNode(BehaviorNode node, BehaviorNode parent)
    { 
        behaviourNodes.Add(node);
        node.parent = parent;
    }

}
