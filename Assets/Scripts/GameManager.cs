using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    // We'll have two phases: Player1 builds base, Player2 attacks base
    public enum GamePhase { BaseBuilding, BaseAttack }
    public GamePhase CurrentPhase = GamePhase.BaseBuilding;

	public int StartingGold = 10000;


    // UI
    public Text GamePhaseText;
	public Text StartingGoldText;

    private void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start()
    {
		StartingGoldText.text = StartingGold.ToString();
        StartBaseBuilding();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void PhaseEnd()
    {
        switch (CurrentPhase)
        {
            case GamePhase.BaseBuilding:
				StartBaseAttack();
                break;
            case GamePhase.BaseAttack:
				StartBaseBuilding();
                break;
        }
    }

    public void StartBaseBuilding()
    {
        CurrentPhase = GamePhase.BaseBuilding;
        GamePhaseText.text = CurrentPhase.ToString() + "!";
    }

    public void StartBaseAttack()
    {
        CurrentPhase = GamePhase.BaseAttack;
        GamePhaseText.text = CurrentPhase.ToString() + "!";
    }
}
