using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// kode som vi havde tidligere arbejdet med i design i et 3D projekt.

	public class RockSlide : MonoBehaviour { // Det her er hvad som var meningen skulle være spillets fjende skript. Som de sten som faldt ned skulle ramme spilleren og gøre lidt forskelligt.

        public GameObject RockShatter; // Har vil man kunne ligge endnu et sprite ind, som ville bytte det tidligere ud når det ramte.
        public Rigidbody2D rb; // ligesom med movement så er det vigtigt at rigidbodyen er fundet.

// her skulle spillet gerne haft fungeret, men af en eller anden grund gjorde det ikke vi har prøvet flere gange med forskellige metoder, men intet fungerede.
       void OnCollider2DEnter(Collider2D other){ // her skulle spillet tjekke om når det ramte noget så ville det gå deres tag igennem, og afhænig af tag vil næste del gå i gang.
           print ("Hjælp"); // test om at selveste kollisionen rent faktisk virkede
            if (other.gameObject.CompareTag ("Player")) { // Her tjekker stenen om den har ramt noget med tagget "Player" som spilleren nu har, hvis det er true så aktivere funktionen nedeunder.
                Explode(); // her kalder vi funktionen, som aktiveres når spilleren skal dræbes
              // psudokode = fjernelse af liv
            }
        }

        void Explode(){ // Her er funktionen som ville aktivere når spilleren blev ramt af en sten.
            var ildkugle = (GameObject)Instantiate( // Først og fremmest vil der blive lavet en klon af vores sten, her bruger den 3 forskellige varibler som bruges
                RockShatter, // først her så tager den variblen fra starten og laver ville her bruge den ødelagte sten sprite
                transform.position, // så tager den stenens position
                transform.rotation); // og til sidst så tjekker den stenens rotation
                        // alt dette bruges til at når spilleren rammes så skifter spriten til en ødelagt sten, som bliver lagt på toppen af den orignale sten.

// her kommer så delen som burde teleport vores sten til et nyt sted, det ville bruges til at stenen ville konstant falde fra toppen, efter de ville kunne teleport når de ramte bunden.
                 int x = Random.Range(0,5);  // Her bliver der fundet en random position på x aksen, som gemmes og bruges senere, talne ville være fra venstre til højre af banden, det ville gøre at sten faldt randomly.
            int y = Random.Range(5,10);      // her ville der komme en random højde på stenen, den er dog lidt mindre vigtig da den skulle helst spawne i toppen.
            float z = 1; // den her er ligegyldig siden vi har et 2D spil, men af en eller anden grund skulle være med af grunde ude af min forstand.
            transform.position = new Vector3(x, y, z);  // Her sker selveste teleportet, hvor den tager de forskellige værdier og rykker den orginale sten hen der. Vi har prøvet at bruge Vector2 men det hjalp ikke og stoppede spillet fra at virke.
            rb.velocity = new Vector3(0,0,0);       // Her sikre spillet sig at stenen ikke beholder nogen hastighed den måske har fået i det den ramte spilleren, da det alt bliver sat til 0.  
                        // som sagt virkede den her del ikke og derfor hart vi spildt en stor mængde af tid på det.
                        // Det var også meningen at huset skulle have en type af det her script som ville teleportere spilleren hen til en lille område som en slags for goal.
        }

    }
