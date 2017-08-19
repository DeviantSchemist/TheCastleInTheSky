using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Castle : MonoBehaviour {

	public Text text;
    public Rigidbody2D whale;

		private List<Civilian> civilians;		// List of civilians (or units) in the castle 
		private int civiliansCount;				// Amount of citizens in the castle
		private float castleWeight;				// Castle's current weight 
		private int maxWeightCapacity;			// Maximum capacity of citizens to keep castle floating 
		private float castleHeightDist; 		// Castle's current distance off the ground
		private int maxHeightDist;				// Maximum distance castle can be frrom the ground in feet
		private int deathHeight;				// When the castle reach this distance off the ground in feet than gameover
		private int dayCounter;					// Keeps track of the amount of days that pass by 
		private int neededEngr;					// Number of engineers needed to keep the castle in the sky 
		private int timeCounter;
        

		// Constructor (Numbers are placeholders atm)
        // Constructor still works with no explicit object declaration, I'm assuming Unity auto detects constructors
		public Castle(){
			civilians = new List<Civilian>();

			// For every new game when a castle is created it will always come with 2 citizens and a engineer 
			civilians.Add(new Engineer());
			for(int i = 0; i < 2 ; i++){
				civilians.Add( new Civilian());
			}

			civiliansCount = civilians.Count;
			//print(civiliansCount); 

			// For loop access all the civilians weight and add them together to get Castle Weight 
			for(int i = 0; i < civilians.Count; i++){
				castleWeight += civilians[i].getWeight();
			}

			maxWeightCapacity = 100;				
			castleHeightDist = 50000;			// Starting off castle height distance in ft
			maxHeightDist = 50000;				// The max height the castle can be from the ground 
			deathHeight = 10000;				// Once castle reaches 10,000 ft off the ground then gameover  
			dayCounter = 1;						// Game starts off in day 1 
			neededEngr = 3;						// Castle needs 3 engineers to keep the castle from decending 
			timeCounter = 0;
		}

		// Overloaded constructor *MIGHT NOT BE NEEDED*
		public Castle(int citzC, float cW, int mWC, float cHD, int mHD, int dH, int dC){
			civilians = new List<Civilian>();
			civiliansCount = citzC;
			castleWeight = cW;
			maxWeightCapacity = mWC;
			castleHeightDist = cHD;
			maxHeightDist = mHD;
			deathHeight = dH;
			dayCounter = dC;
		}

		public int getEngrCount(){
			int engrCount = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (civilians [i].getUnitType () == 2)
					engrCount++;
			}
			return engrCount;
		}

		public int getCivCount(){
			int civCount = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (civilians [i].getUnitType () == 1)
					civCount++;
			}
			return civCount;
		}

		public int getScrapCount(){
			int engrCount = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (civilians [i].getUnitType () == 4)
					engrCount++;
			}
			return engrCount;
		}

		public int getSoldierCount(){
			int engrCount = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (civilians [i].getUnitType () == 3)
					engrCount++;
			}
			return engrCount;
		}
			
		// Getter function for citizen count 
		public int getCitizenCount(){
			return civiliansCount;
		}

		// Setter function for the Castle height distance off the ground in ft
		public void setCastleHeightDist(int cHD){
			castleHeightDist = cHD;
		}

		// Getter function for Castle height distance 
		public float getCastleHeightDist(){
			return castleHeightDist;
		}

		// Setter function for the day counter 
		public void setDayCounter(int dC){
			dayCounter = dC;
		}

		// Getter function for the day counter 
		public int getDayCounter(){
			return dayCounter;
		}

		// Function updates the civilian count by counting all the units in the castle that are not scraps 
		public void updateCivilianCount(){
			int unitCount = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (civilians [i].getUnitType() != 4) {
					unitCount++;
				}
			}
		}

		// Function updates the castle weight 
		public void updateCastleWeight(){
			// For loop access all the civilians weight and add them together to get Castle Weight 
			for(int i = 0; i < civilians.Count; i++){
				castleWeight += civilians[i].getWeight() * Time.deltaTime;
			}
		}

		// Function will determine the decending or acending rate of the castle depending on the castle's distance of the ground and the castle's weight 
		// This function will run every frame and the decending/acending rate is about 10,000 ft per day which is 10,000 ft every 3 min in real time 
		public void decending_Ascending_Rate(){
			int engrCount = 0;
			bool unstableCastle = false;

			// For loop counts the amount of engineers in the castle 
			for(int i = 0; i < civilians.Count; i++){

				if(civilians[i].getUnitType() == 2){
					engrCount += 1;
				}
			}

			if(engrCount < 3){
				unstableCastle = true;
			}

			// if else statements determine if the castle will descend depnding on certain requirements based on castle distance off the ground and the castle weight 
			if (castleHeightDist > 40000 && castleHeightDist < 50000 && castleWeight >= 20 && castleWeight < 40)
				unstableCastle = true;
			else if (castleHeightDist > 30000 && castleHeightDist < 40000 && castleWeight >= 40 && castleWeight < 60)
				unstableCastle = true;
			else if (castleHeightDist > 20000 && castleHeightDist < 30000 && castleWeight >= 60 && castleWeight < 80)
				unstableCastle = true;
			else if (castleHeightDist > 10000 && castleHeightDist < 20000 && castleWeight >= 80 && castleWeight < 100)
				unstableCastle = true;

			if (unstableCastle == true){
				castleHeightDist -= 0.926f;
			}

			if( unstableCastle == false && castleHeightDist != maxHeightDist){
				castleHeightDist += 0.926f;
			}
		}

		// updateTime function will run every frame in the update function and will incremnt every frame, since the game will run 
		// 60 frames per second and a day in the game is 3 min in real time. Day counter will increment every 10,800 frames or 3 mins 
		public void updateTime(){
			timeCounter++;
			// print (timeCounter); - Debugging tool 
			if (timeCounter == 10800) {
				dayCounter++;
				timeCounter = 0;
			}
		}
			
		// Function will update population growth every in game day based on the equation (unit population/2) 
		public void populationGrowth(){
			if (timeCounter == 10799) {
				int populationGrowth = (civilians.Count / 2);
				for (int i = 0; i < populationGrowth; i++) {
					civilians.Add (new Civilian ());
				}

			}
		}

		// This function converts civilians in the castle into engineers 
		public void convertCivToEngr(){
			bool foundCitz = false;
			int unitPlacement = 0;
			int unitType = 1;
			for (int i = 0; i < civilians.Count; i++) {
				if (unitType == civilians[i].getUnitType()) {
					foundCitz = true;
					unitPlacement = i;
				}
			}

			if (foundCitz == true) {
				civilians.RemoveAt (unitPlacement);
				civilians.Add (new Engineer ());
			}

		}

		// This function converts civilians in the castle into soldiers 
		public void convertCivToSoldr(){
			bool foundCitz = false;
			int unitPlacement = 0;
			int unitType = 1;
			for (int i = 0; i < civilians.Count; i++) {
				if (unitType == civilians[i].getUnitType()) {
					foundCitz = true;
					unitPlacement = i;
				}
			}
			if (foundCitz == true) {
				civilians.RemoveAt (unitPlacement);
				civilians.Add (new Soldier ());
			}

		}

		// This function converts a certain unit type from the castle into a scrap 
		public void convertUnitToScrap(int unitType){
			int unitPlacement = 0;
			for (int i = 0; i < civilians.Count; i++) {
				if (unitType == civilians [i].getUnitType()) {
					unitPlacement = i;
				}
			}
			civilians.RemoveAt (unitPlacement);
			civilians.Add (new Scrap ());

		}

		public void checkDecayUnits(){
			List<int> decayLocation = new List<int>();
			for(int i = 0; i < civilians.Count; i++){
				if (civilians[i].unitDecay() == true) {
					decayLocation.Add (i);
				}
			}
				
			if (decayLocation.Count != 0 ) {
				for (int i = 0; i < decayLocation.Count; i++) {
					civilians.RemoveAt (decayLocation [i]);
					// print ("Unit turned into scrap"); - Debugging tool 
					civilians.Add (new Scrap ());
				}
			}


		}

		// This function will act as the kill switch to determine when the game is over 
		// If the castle height reaches a distance of 10000 than it is gameover 
		// Need to figure out how to make this function acts as the kill switch 
		public void gameover(){
			if (castleHeightDist <= 10000)
				print ("GAMEOVER");
		}
			
        




	//public Castle castle;

    public void increaseWeight()
    {
        // have to make whale.gravityScale increase and decrease by 0.926f
        whale.gravityScale += 0.926f;
        //whale.gravityScale = castleWeight * .000001f;
    }

    // Use this for initialization
    void Start () {
        whale = GetComponent<Rigidbody2D>();
        //Debug.Log("Civilian numbers: " + civilians.Count);
        //castle = new Castle ();
		gameover();
		updateCastleWeight();
		updateCivilianCount();
		decending_Ascending_Rate();
		updateTime();
		populationGrowth();
		checkDecayUnits();
		int con = getDayCounter();
		//string convert = con.ToString();
		//text.text = convert;
	}
	
	// Update is called once per frame
	void Update () {
		gameover();
		updateCastleWeight();
		updateCivilianCount();
		decending_Ascending_Rate();
		updateTime();
		populationGrowth();
		checkDecayUnits();
		int con = getDayCounter();
        //string convert = con.ToString();
        //text.text = convert;
        if (castleWeight > 2000)
        {
            increaseWeight();
        }
        //Debug.Log("Gravity scale: " + whale.gravityScale);
        Debug.Log("Weight: " + castleWeight);
	}
}
