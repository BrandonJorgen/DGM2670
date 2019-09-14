using TMPro;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
	public GameAction action;
	public FloatData data;
	private TextMeshProUGUI scoreText;

	private void Start()
	{
		scoreText = GetComponent<TextMeshProUGUI>();
		action.action += UpdateScore;
	}

	private void UpdateScore()
	{
		scoreText.text = data.value.ToString();
		Debug.Log("Updated Score");
	}
}
