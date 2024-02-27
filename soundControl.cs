using System;
using UnityEngine;

public class ControlSonido : MonoBehaviour
{
	private void Start()
	{
	}

	private void Update()
	{
	}

	public void BotonSonClick()
	{
		Object.Instantiate<GameObject>(this.sonidoClick);
	}

	public GameObject sonidoClick;
}
