using System;
using UnityEngine;

public class VolumeValueChange : MonoBehaviour
{
	private void Start()
	{
		this.audioSrc = base.GetComponent<AudioSource>();
	}

	private void Update()
	{
		this.audioSrc.volume = this.musicVolume;
	}

	public void SetVolume(float vol)
	{
		this.musicVolume = vol;
	}

	private AudioSource audioSrc;

	private float musicVolume = 1f;
}
