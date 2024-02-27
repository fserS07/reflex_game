using System;
using UnityEngine;
using UnityEngine.UI;

public class NivelDos : MonoBehaviour
{
	private void Start()
	{
		this.contador.text = " " + this.tiempo;
		this.Promedio.text = " " + this.prom;
		base.Invoke("NewButton", 2f);
	}


	private void Update()
	{
		base.Invoke("Conteo", 2f);
		this.contador.text = " " + this.tiempo.ToString("f0");
		this.Promedio.text = " " + this.prom.ToString("f0");
		PlayerPrefs.SetInt("puntaje", this.Cont);
		PlayerPrefs.SetFloat("promedio", this.prom);
		PlayerPrefs.SetFloat("reaccion", this.react);
		PlayerPrefs.Save();
		if (this.tiempo <= 0f && this.fall < 4)
		{
			this.timer = 0f;
			this.time = 0f;
			this.Resultad();
			this.nextButton.SetActive(true);
			this.retryButton.SetActive(false);
			return;
		}
		if (this.time >= this.duracion)
		{
			this.time = 0f;
			this.NormalButton();
			this.NewButton();
			this.Cont -= 10;
			return;
		}
		if (this.fall >= 4)
		{
			this.timer = 0f;
			this.tiempo = 0f;
			this.time = 0f;
			this.Resultad();
			this.nextButton.SetActive(false);
			this.retryButton.SetActive(true);
		}
	}

	public void Conteo()
	{
		this.timer = Time.time;
		this.tiempo -= Time.deltaTime;
		this.time += Time.deltaTime;
	}

	public void NewButton()
	{
		this.activeButton = Random.Range(0, 12);
		this.buttons[this.activeButton].SetActive(false);
	}

	public void NormalButton()
	{
		this.buttons[this.activeButton].SetActive(true);
	}

	public void rightButton()
	{
		this.right = true;
		this.acer++;
		this.Cont += 50;
		this.react = Time.time - this.timer;
		this.prom = (float)this.Cont / this.timer;
		this.NormalButton();
		this.NewButton();
	}

	public void wrongButton()
	{
		this.fall++;
		this.Cont -= 20;
	}

	public void Resultad()
	{
		this.contador.text = "0";
		this.NormalButton();
		this.Resultado.SetActive(true);
		this.Reaccion.text = " " + this.react;
		this.Prom.text = " " + this.prom.ToString("f0") + "%";
		this.Puntaje.text = " " + this.Cont;
		this.Aciertos.text = " " + this.acer;
		this.Fallos.text = " " + this.fall;
	}

	public float timer;

	public GameObject[] buttons;

	public int activeButton;

	public int Cont;

	public Text contador;

	private float tiempo = 15f;

	public float prom;

	public Text Promedio;

	public float react;

	public int acer;

	public int fall;

	public GameObject Resultado;

	public GameObject nextButton;

	public GameObject retryButton;

	public Text Reaccion;

	public Text Prom;

	public Text Puntaje;

	public Text Fallos;

	public Text Aciertos;

	public bool right;

	public float time;

	public float duracion = 1.5f;
}
