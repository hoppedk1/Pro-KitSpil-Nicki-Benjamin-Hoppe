using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 // stor del af movement scripted er lånt og inspireret fra https://craftgames.co/unity-2d-platformer-movement/ , dog så var de ikke meningen at bevægelsen skulle være så stor en del, derfor blev den ikke fuldt helt.
public class Movement : MonoBehaviour {

    public float speed; // en konstant hastighed venstre og højre, (ingen slowdown på hastighed det er instant)
    public float jumpForce; // styrke på hopped
    Rigidbody2D rb; // finder player rigidbody og giver den rb som bliver brugt senere
    bool isGrounded = false; // her starter den ud med at difinere selveste groundcheckeren, da den igen bliver kaldt nede i checkifgrounded.
    public Transform isGroundedChecker; // Her kan vi smide selveste den cirkel som er vores groundchecker.
    public float checkGroundRadius; // her er størrelsen på groundcheckeren
    public LayerMask groundLayer; // Her ligger man selveste "ground" layeret ind, så den ved hvilket tag den skal lede efter.
   
void Start() {  // kører så snart spillet er startet
    rb = GetComponent<Rigidbody2D>(); // finder rigidbody'en på spilleren
} 
    void Update() {  // Update bliver kørt igennem her gang der kører en frame
    Move(); // vores movement script
    Jump(); // evenen til at hoppe
    CheckIfGrounded(); // tjek om vi er grounded
} 
void Move() { // her er selveste movement delen i bevægelsen af venstre og højre.
    float x = Input.GetAxisRaw("Horizontal"); // her tjekker den om den får en negativ eller positiv værdi i forhold til dens bevægelse
    float moveBy = x * speed; // her udregner den selveste hastigheden ved blandt andet ting som 6*1
    rb.velocity = new Vector2(moveBy, rb.velocity.y); // Her bliver selveste spilleren bevæget, i enten positiv eller negativ retning.
}
void Jump() { // her er selveste jump koden, som sender spilleren opad.
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded) { // her i if-statementet tjekker den om space er trykket nede, og at groundchecker er true.
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); // her bevæger den spilleren op med den jumpforce(fx 11).
    } 
}

void CheckIfGrounded() { // for at undgå at spilleren bare kan flyve ved med at blive ved med at hoppe, har vi tilføjet en "Groundchecker" som ligger på spilleren. og det "ground" layer vi har lagt på ting man skal kunne hoppe fra. 
    Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); // her bliver der tjekket om den radius som gorundcheckeren har overlapper et object med ground tagget.
    if (collider != null) {  // hvis det er sandt så bliver isgrounded true
        isGrounded = true; // gør det muligt at kunne hoppe
    } else {  // hvis ikke så kan man ikke hoppe
        isGrounded = false; // gør at man ikke kan hoppe
    } 
}

void Flip(){ // Her burde spillerens sprite blive flipped på x aksen, der burde være en unity includeret script som gør det, men det virkede ikke for en eller anden grund.
    if (rb.velocity.x < 0){
    // her burde der være en kode som flipper player spriten når personen bevæger sig mod højre eller mod venstre.
    }
}

}