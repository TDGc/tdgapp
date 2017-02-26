using UnityEngine;
using System.Collections;

public class LoadInfoPC : MonoBehaviour {

    private Computer computer;
	void Start () {
        computer = new Computer();
        // Проверка на сохранение
        computer.Ghs = Random.Range(1, 5000);
        Debug.Log("GHS/s : " + computer.Ghs + " | LEVEL PC : " + computer.LevelPC + " | LEVEL UPGRADE : " + computer.LevelUpgade);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public Computer getComputerObject()
    {
        return computer;
    }
}
