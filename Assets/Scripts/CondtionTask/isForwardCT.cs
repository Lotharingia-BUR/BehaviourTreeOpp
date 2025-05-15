using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class isForwardCT : ConditionTask {
		public BBParameter<Transform> selfPos;
        public BBParameter<Transform> targetPos;

        private Vector3 directionToTarget;
        private float angle;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
			return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			directionToTarget = selfPos.value.position - targetPos.value.position;
			angle = Vector3.Angle(selfPos.value.forward, directionToTarget);

			if (Mathf.Abs(angle) < 90)
			{
				Debug.Log("In Front");
                return true;
            }

            return false;
		}
	}
}