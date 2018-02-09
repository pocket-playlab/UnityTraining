using UnityEngine;
using System.Collections;

public class SoundEffectHelper : MonoBehaviour
{

	public static SoundEffectHelper Instance;

	public AudioClip explosionSound;
	public AudioClip playerShotSound;
	public AudioClip enemyShotSound;
	public AudioClip ButtonClickSound;
	public AudioClip ButtonResetSound;

	void Awake()
	{

		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectHelper!");
		}
		Instance = this;
	}

	public void MakeExplosionSound()
	{
		MakeSound(explosionSound);		
	}

	public void MakePlayerShotSound()
	{
		MakeSound(playerShotSound);
	}

	public void MakeEnemyShotSound()
	{
		MakeSound(enemyShotSound);
	}

	public void MakeEButtonClickSound()
	{
		MakeSound(ButtonClickSound);
	}

	public void MakeButtonResetSound()
	{
		MakeSound(ButtonResetSound);		
	}
		
	private void MakeSound(AudioClip originalClip)
	{
		AudioSource.PlayClipAtPoint(originalClip, transform.position);
	}
}