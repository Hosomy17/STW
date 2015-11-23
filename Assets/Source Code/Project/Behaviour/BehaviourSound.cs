using UnityEngine;
using System.Collections;

public static class BehaviourSound
{
	private static SoundManager soundManager = SoundManager.Instance;

	public static void Play(string audio)
	{
		soundManager.Play(audio);
	}

}
