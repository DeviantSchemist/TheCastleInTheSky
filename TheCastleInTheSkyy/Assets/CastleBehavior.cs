using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CastleBehavior : MonoBehaviour {

	//  Castle Class 
	public class Castle{
		private int citizenCount;		// Amount of citizens in the castle
		private int castleWeight;		// Castle's current weight 
		private int maxWeightCapacity;	// Maximum capacity of citizens to keep castle floating 
		private int castleHeightDist; 	// Castle's current distance off the ground
		private int maxHeightDist;		// Maximum distance castle can be frrom the ground in feet
		private int deathHeight;		// When the castle reach this distance off the ground in feet than gameover
		private int dayCounter;			// Keeps track of the amount of days that pass by 

		// Constructor (Numbers are placeholders atm)
		public Castle(){
			citizenCount = 20;
			castleWeight = 30;
			maxWeightCapacity = 50;
			castleHeightDist = 45000;
			maxHeightDist = 45000;
			deathHeight = 5000;
			dayCounter = 1;
		}

		// Overloaded constructor 
		public Castle(int citzC, int cW, int mWC, int cHD, int mHD, int dH, int dC){
			citizenCount = citzC;
			castleWeight = cW;
			maxWeightCapacity = mWC;
			castleHeightDist = cHD;
			maxHeightDist = mHD;
			deathHeight = dH;
			dayCounter = dC;
		}

		/* Setter function for citizen count 
		 * @param citzC - Amo
		 */
		public void setCitizenCount(int citzC){
			citizenCount = citzC;
		}

		// Getter function for citizen count 
		public int getCitizenCount(){
			return citizenCount;
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
			citizenCount += addCitz;
		}

		/* Function is used to subtract citizens from the castle
		 * @param subtrCitz - This is the amount of citizens you want to subtract in the castle 
		 */
		public void subtrCitizenCount(int subtrCitz){
			citizenCount -= subtrCitz;
		}

		public void addCastleWeight(int addWeight){
			castleWeight += addWeight;
		}

		public void subtrCastleWeight(int subtrWeight){
			castleWeight -= subtrWeight;
		}


	}
		




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
