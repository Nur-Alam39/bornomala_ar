using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class buttonmanager : MonoBehaviour {

	// Use this for initialization
	public void paly()
	{
		SceneManager.LoadScene ("scene1");
	}
	public void instuction()
	{
		SceneManager.LoadScene ("instruction");
	}
	public void about()
	{
		SceneManager.LoadScene ("about");
	}
	public void backmenu()
	{
		SceneManager.LoadScene ("menu");
	}
	// Update is called once per frame

}
