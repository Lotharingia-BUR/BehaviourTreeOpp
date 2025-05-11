using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class PatrolAT : ActionTask {
        NavMeshAgent NavAgent;
		public BBParameter<List<Transform>> points;
		public BBParameter<Transform> targetPos;
		public BBParameter<int> currentPoint;
        protected override string OnInit() {
            NavAgent = agent.GetComponent<NavMeshAgent>();
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
			targetPos.value = points.value[currentPoint.value];
			Debug.Log(currentPoint.value);
			NavAgent.SetDestination(targetPos.value.position);

            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}