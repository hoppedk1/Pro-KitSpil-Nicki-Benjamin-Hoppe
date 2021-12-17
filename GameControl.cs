using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Denne pakke bruges til at skifte mellem scener/baner
using TMPro;  // TextMeshPro pakken - giver mange flere muligheder for at shine teksterne op

//namespace Digiteknik { virkede ikke pga den allerede bliver kaldt.

	// Dette script skal holde styr på fremgangen i spillet og på de forskellige scener
	// Det skal ligge på et tomt GameObject i spil-scenen - kald det GameController
	
	public class GameControl : MonoBehaviour {

		// TextMeshPro objekter
        public TextMeshProUGUI sceneTekst;
		public TextMeshProUGUI pointTekst;
		public TextMeshProUGUI LivText;
		// "Gammeldags" UI Text objekt, blot for sammenligningens skyld
		public Text timeTekst;

		public int tid = 100;
		public int vinderScore = 20;

		private int score;
		private int bane = 0;

		public int liv = 5;


		// Hver gang vi starter en ny scene tjekker vi om der er mere end en "Player"
		// Hvis der er, skal de overskydende fjernes, mens den "rigtige" Player skal 
		// bevares når scenen igen skifter.
		/*void Awake() { // fjernede hele den her del her, efter at hvordan at mit camera script fungere så ville det bug så snart man skiftede scene.
			GameObject[] objs = GameObject.FindGameObjectsWithTag("Player");
			for (int i = objs.Length-1; i > 0; i--)
			{
				Destroy(objs[i]);
			}
			bane = SceneManager.GetActiveScene().buildIndex;
			DontDestroyOnLoad(objs[0]);//(this.gameObject);
		}
*/
		// Brug Start() til initialisering - her startes tiden og nulstilles scoren på skærmen
		// Hvis man løber tør for tid har man tabt
		// Hvis score er større end VinderScore har man vundet
		//void Start () {
			//score = 0;
			// xUpdateScore ();			
			// sceneTekst.enabled = false;
			// Coroutines er metoder som kan køre uafhængigt af selve scenen. 
			//StartCoroutine (showTime());
			// UpdateLiv ();
			// psudo code = Lampen skal tændes.
		//}
 /*
		// Viser resterende antal sekunder (dvs. health), samt tjekker om man har tabt
		IEnumerator showTime(){
			while (tid >= 0) {
				timeTekst.text = tid.ToString() + " Sek";
				yield return new WaitForSeconds (1); // Venter 1 sekund før tiden igen tælles ned
				tid--;
				if (tid <= 0) {
					Taber();
				}
			}
		}
*/
/*
		// Sætter en ny score, og tjekker om man har vundet 
		public void AddScore (int addScoreValue){
			score += addScoreValue;
			// UpdateScore ();
			// psudo code = Lampen skal blinke gul
			if(score >= vinderScore){				
				Vinder();
				// psudo code = lampen skal blinke grøn // evt placering her
			}
		}
*/
/*
		// Tilføjer ekstra levetid ( = health). Kaldes blandt andet fra "Cheat"
		public void AddHealth (int howMuch){
			print ("Ekstra liv: " + howMuch);
			tid += howMuch;
		}
*/
		// Sætterscore-værdien på skærmen
		/*
		void UpdateScore (){
			pointTekst.text = "Score: " + score;
		}		
 */ /* Fjernet efter fejl i kode
		void UpdateLiv (){
			LivText.text = "Liv: " + liv;
		}
*/
	/*	public void FjernLiv (int LivVærdi){
			liv += LivVærdi;
			// UpdateLiv();
			if(liv == 0){
				Taber();
			}
		}

		// Disse to funktioner kan senere bruges til at skifte scene og meget mere
		void Vinder() {
			StartCoroutine(showEnd("Du Vinder!!", true));
			// psudo code = lampen skal blinke grøn // anden mulig placering
		}

		void Taber(){
			StartCoroutine(BackStart("Du TABER!", true)); 
			// Lukker spillet, eller måske endda skifter tilbage et par baner
			// psudo code = en lampen skal slukkes når man har tabt
		}	

		//Viser sluttekst i et antal sekunder og skifter scene, hvis der er en ny
		IEnumerator showEnd(string t, bool levelUp){
			sceneTekst.text = t;
			sceneTekst.enabled = true;
			yield return new WaitForSeconds (4);
			sceneTekst.enabled = false;
			if (levelUp) {
				bane += 1;
				print ("Skifter scene til " + bane);
				// Scene thisScene = SceneManager.GetActiveScene();
				//Debug.Log("Aktive Scene var: " + thisScene.name + ".");
				// Gør linjen nedenfor aktiv, når du har lavet en ny scene at skifte til
				// SceneManager.LoadScene((thisScene.buildIndex + 1) % 3); // Den her gør at banen kommer hen til den næste, så når man vinder så kommer man til næste bane. (den restarter bare når du klarer den sidste.)
			}
		}	
			IEnumerator BackStart(string t, bool levelUp){ // Det her er en anden variation af vores baneskift som fokusere på at tvinge spilleren tilbage til start hvis de skulle tabe, er næsten en kopi af den ovenfor
			sceneTekst.text = t;
			sceneTekst.enabled = true;
			yield return new WaitForSeconds (4);
			sceneTekst.enabled = false;
			if (levelUp) {
				bane += 0; 
				print ("Skifter scene til " + bane);
				//Scene thisScene = SceneManager.GetActiveScene();
				// Debug.Log("Aktive Scene var: " + thisScene.name + ".");
				// Gør linjen nedenfor aktiv, når du har lavet en ny scene at skifte til
				//SceneManager.LoadScene((thisScene.buildIndex - 2) % -1); // Den her gør at spilleren ryger helt tilbage til start, hvis spilleren er på fx bane 0 eller 1 så er det sat op sådan at man ikke kan komme alt for lavt.
		}
*/
	}
// }}
