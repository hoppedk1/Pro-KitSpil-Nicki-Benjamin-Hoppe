using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour // Det her er vores straight up baneskifter som vi bruger til at skifte fra hovedmenu til selveste spillet, ville også haft blevet brugt som en slags system til at skifte til blandt andet bane 2.
{
        public void PlayGame () // Så snart at spilleren i hovedmenuen klikker på start så vil den skifte hen til bane nr 1.
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Her sker bane skiftet som skifter os hen til selveste spillet.
        }

       //Aflsut knap
       public void QuitGame () // klikkede man på afslut spil, så burde den her lukke det ned.
       {
           Debug.Log("Afslut");
           Application.Quit(); // lukker spillet.
       }
}
