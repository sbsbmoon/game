using UnityEngine;
using System.Collections.Generic;

public abstract class AINode{

	public string commandName;
	public GameObject target;

	public abstract void RunAction();

}

public class AINodeManager{

	public Dictionary<string,AINode> mNodeMap = new Dictionary<string, AINode>();

	protected static AINodeManager instance;
	
	public static AINodeManager Instance{
		get{
			if( instance == null ){
				instance = new AINodeManager();
			}
			return instance;
		}
	}

	public void AddAINode( string commandName , AINode node ){
		mNodeMap [commandName] = node;
	} 

	public void RemoveAINode( string commandName ){
		mNodeMap.Remove (commandName);
	}

	public AINode FindAINode( string commandName ){
		return mNodeMap[commandName];
	}
	public void Clear(){
		mNodeMap.Clear ();
	}
}

public class AICase : AINode{
	public delegate bool Check( GameObject go );
	public Check OnCheck;
	public bool unLock = false;
	public override void RunAction ()
	{
		if( OnCheck != null ){
			unLock = OnCheck(target);
		}
	}
}

public class AIBehaviour : AINode{
	public delegate void Action( GameObject go );
	public GameObject target;
	public Action OnAction;
	
	public override void RunAction ()
	{
		if( OnAction != null ){
			OnAction (target);
		}
	}
}