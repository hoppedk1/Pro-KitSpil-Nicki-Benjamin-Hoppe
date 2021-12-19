using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Denne pakke bruges til at skifte mellem scener/baner
using TMPro;  // TextMeshPro pakken - giver mange flere muligheder for at shine teksterne op


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
 // Planen var at det her script skulle blive brugt til at kontrollere en helt masse ting udre fra. Såsom mængden af liv, og score hvis spilleren skulle evt samle coins eller noget andet op. Desværre blev den del aldrig til noget.
	}
