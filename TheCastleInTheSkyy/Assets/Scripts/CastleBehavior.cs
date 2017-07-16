using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CastleBehavior : MonoBehaviour {

	//  Castle Class 
	public class Castle{
		private List<Civilian> civilians;		// List of civilians (or units) in the castle 
		private int civiliansCount;				// Amount of citizens in the castle
		private int castleWeight;				// Castle's current weight 
		private int maxWeightCapacity;			// Maximum capacity of citizens to keep castle floating 
		private int castleHeightDist; 			// Castle's current distance off the ground
		private int maxHeightDist;				// Maximum distance castle can be frrom the ground in feet
		private int deathHeight;				// When the castle reach this distance off the ground in feet than gameover
		private int dayCounter;					// Keeps track of the amount of days that pass by 

		// Constructor (Numbers are placeholders atm)
		public Castle(){
			civilians = new List<Civilian>();

			for(int i = 0; i < 10 ; i++){
				civilians.Add( new Civilian());
			}
		
			civiliansCount = civilians.Capacity;
			castleWeight = 30;
			maxWeightCapacity = 50;
			castleHeightDist = 45000;
			maxHeightDist = 45000;
			deathHeight = 5000;
			dayCounter = 1;
		}

		// Overloaded constructor (Not sure if needed)
		public Castle(int citzC, int cW, int mWC, int cHD, int mHD, int dH, int dC){
			civilians = new List<Civilian>();
			civiliansCount = citzC;
			castleWeight = cW;
			maxWeightCapacity = mWC;
			castleHeightDist = cHD;
			maxHeightDist = mHD;
			deathHeight = dH;
			dayCounter = dC;
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
		public int getCastleHeightDist(){
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

		/* Function is used to add citizens in the castle 
		 * @param addCitz - This is the amount of citizens you want to add in the castle 
		 */
		public void addCitizenCount(int addCitz){
			civiliansCount += addCitz;
		}

		/* Function is used to subtract citizens from the castle
		 * @param subtrCitz - This is the amount of citizens you want to subtract in the castle 
		 */
		public void subtrCitizenCount(int subtrCitz){
			civiliansCount -= subtrCitz;
		}

		public void addCastleWeight(int addWeight){
			castleWeight += addWeight;
		}

		public void subtrCastleWeight(int subtrWeight){
			castleWeight -= subtrWeight;
		}

		public void decendingRate(){

		}

		public void acendingRate(){

		}

		public void populationGrowth


	}
	// Growth Rate: Total units/2 (rounded down) 




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
