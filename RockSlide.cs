using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class RockSlide : MonoBehaviour {

        public GameObject RockShatter;
        public Rigidbody2D rb;
        //public int LivValue = -1;
        /*private GameControl script;/*

        /*void Start(){ // fjern for at spillet viker.
            script = FindObjectOfType<GameControl>();
        }*/

       void OnCollider2DEnter(Collider2D other){
           print ("Hjælp");
            if (other.gameObject.CompareTag ("Player")) {
                Explode();
              
            }
        }

        void Explode(){
            print ("Boom");
             //transform.localScale *= 0; // hvis den bliver ganged med 0 så forsvinder de bare, hvilket nok ikke er den bedste løsning
            //Destroy(gameObject, 1); // fjerner det som den er lagt på, efter 1 sekundt i dette tilfælde.
            var ildkugle = (GameObject)Instantiate(
                RockShatter,
                transform.position,
                transform.rotation);

                 int x = Random.Range(0,5); // Banen er -50 til 50 (var det gælder alle baner)
            int y = Random.Range(5,10);            // 5.2 Det her er banes højde 
            float z = 1;
            transform.position = new Vector3(x, y, z);  // Den her teleporter den til et nyt sted når den rammes
            rb.velocity = new Vector3(0,0,0);           // Den her sørger for at hastigheden fjernes    
                        
           // script.FjernLiv(LivValue);           // Ændre addscore til at istedet være en remove HP, or something.
        }

    }
