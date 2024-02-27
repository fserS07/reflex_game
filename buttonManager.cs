using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{

	public void backMenu()
	{
		SceneManager.LoadScene(0);
	}

	public void uno()
	{
		SceneManager.LoadScene(1);
	}

	public void dos()
	{
		SceneManager.LoadScene(2);
	}

	public void tres()
	{
		SceneManager.LoadScene(3);
	}

	public void cuatro()
	{
		SceneManager.LoadScene(4);
	}

	public void cinco()
	{
		SceneManager.LoadScene(5);
	}
}
