using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public class GameControl : MonoBehaviour {

    private ThirdPersonCharacter player;

public static float power;
public static float money;

public delegate void EventMoney(float m, float p);
public static event EventMoney updateMoney;

    // Events handler 
    public delegate void EventController();
    public static event EventController events;

public delegate void EventIncrease(float f);
public static event EventIncrease increaseSize;

public delegate void EventDecrease(float f);
public static event EventDecrease decreaseSize;

public delegate void EventColor();
public static event EventColor changeColor;

/*
    public delegate void DoorsEvents();
    public static event DoorsEvents door;

    public delegate void PlayerHandler(ThirdPersonCharacter player);
    public static PlayerHandler playerEvents;
*/
    // Singleton patter, avoid multiple controllers
    public static GameControl instance;


    public static bool doors = false;

    // Use this for initialization
    void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {// If it's not this, destroy it
            Destroy(gameObject);
        }
    }

    void Start() {
        // Find the player
	power = 0;
	money = 0;
        GameObject temp = GameObject.FindGameObjectWithTag("Player");
        player = temp.GetComponent<ThirdPersonCharacter>();
    }

	public static void buyPower () {
		if (money > 10) {
			power += 0.1f;
			money -= 10;
		}
		updateMoney(money, power);
	}

    // Update is called once per frame
    void Update() {
        // Check always it's not null befor invoking it
	/*
        if (events != null)
            events();

        if (playerEvents != null) {
            playerEvents(player);
            // We just want that the event excecute one time
            playerEvents = null;
        }

        if (doors) {
            door();
            doors = false;
        }
	*/
	if (Input.GetKeyDown(KeyCode.T))
        {
		decreaseSize(power);
        }

	if (Input.GetKeyDown(KeyCode.Y))
        {
		money += 10;
		updateMoney(money, power);
		changeColor();
        }
	
    }	

	public static void emitIncreaseSize() {
		increaseSize(power);
	}
}
