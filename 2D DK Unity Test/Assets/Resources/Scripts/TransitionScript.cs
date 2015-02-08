using UnityEngine;
using System.Collections;

public class TransitionScript : MonoBehaviour
{

		[SerializeField]
		public string
				TransitionLocation;


		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnTriggerEnter (Collider other)
		{
				if (other.tag == "Player")
						Application.LoadLevel ("Test Scene");
		}
	
	
	
	
	
}
