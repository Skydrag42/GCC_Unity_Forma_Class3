using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
	public Animator animator;

	public void Interact()
	{
		animator.SetBool("isOpen", true);
	}

}
