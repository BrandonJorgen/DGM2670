using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScoreScript : MonoBehaviour
{

	public FloatData value;
	public UnityEvent ScoreZero, ScoreOne, ScoreTwo, ScoreThree, ScoreFour, ScoreFive, ScoreSix;
	
	// Update is called once per frame
	void Update ()
	{
		if (value.value == 0)
		{
			ScoreZero.Invoke();
		}
		
		if (value.value == 1)
		{
			ScoreOne.Invoke();
		}
		
		if (value.value == 2)
		{
			ScoreTwo.Invoke();
		}
		
		if (value.value == 3)
		{
			ScoreThree.Invoke();
		}
		
		if (value.value == 4)
		{
			ScoreFour.Invoke();
		}
		
		if (value.value == 5)
		{
			ScoreFive.Invoke();
		}
		
		if (value.value == 6)
		{
			ScoreSix.Invoke();
		}
	}
}
