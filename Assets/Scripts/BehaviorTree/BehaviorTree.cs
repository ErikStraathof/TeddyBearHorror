using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu()]
public class BehaviorTree : ScriptableObject
{
    public BehaviorNode rootNode;
    private List<BehaviorNode> nodes = new List<BehaviorNode>();
    private BehaviorState state = BehaviorState.Running;

    public BehaviorState Update()
    {
        if (rootNode.state == BehaviorState.Running)
        {
            state = rootNode.Update();
        }
        return state;
    }

    public BehaviorNode CreateNode(System.Type type)
    { 
        BehaviorNode node = ScriptableObject.CreateInstance(type) as BehaviorNode;
        node.name = type.Name;
        node.GUID = GUID.Generate().ToString();
        nodes.Add(node);

        AssetDatabase.AddObjectToAsset(node, this);
        AssetDatabase.SaveAssets();
        return node;
    }

    public void AddNode(BehaviorNode node, BehaviorNode parent)
    { 
        nodes.Add(node);
        node.parent = parent;
    }

    public void RemoveNode(BehaviorNode node)
    {
        nodes.Remove(node);
        AssetDatabase.RemoveObjectFromAsset(node);
        AssetDatabase.SaveAssets();
    }
}
