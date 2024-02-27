using System;
using UnityEngine;
using UnityEngine.UI;

public class Estadisticas : MonoBehaviour
{
	private void Start()
	{
		this.Punt = PlayerPrefs.GetInt("puntaje");
		this.Prome = PlayerPrefs.GetFloat("promedio");
		this.Reacc = PlayerPrefs.GetFloat("reaccion");
	}

	private void Update()
	{
		if (this.Punt >= this.MaxPunt)
		{
			this.MaxPunt = this.Punt;
		}
		if (this.Reacc >= this.MaxReacc)
		{
			this.MaxReacc = this.Reacc;
		}
		if (this.Prome >= this.MaxProme)
		{
			this.MaxProme = this.Prome;
		}
		this.Reaccion.text = " " + this.MaxReacc;
		this.Promedio.text = " " + this.MaxProme.ToString("f0") + "%";
		this.Puntaje.text = " " + this.MaxPunt;
	}

	public int Punt;

	public int MaxPunt;

	public float Reacc;

	public float MaxReacc;

	public float Prome;

	public float MaxProme;

	public Text Puntaje;

	public Text Reaccion;

	public Text Promedio;
}