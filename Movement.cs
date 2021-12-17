using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
 // stor del af movement scripted er lånt fra https://craftgames.co/unity-2d-platformer-movement/ 
public class Movement : MonoBehaviour {

    public float speed; // en konstant hastighed venstre og højre, (ingen slowdown på hastighed det er instant)
    public float jumpForce; // styrke på hopped
    Rigidbody2D rb; // finder player rigidbody og giver den rb som bliver brugt senere
    bool isGrounded = false; 
    public Transform isGroundedChecker; 
    public float checkGroundRadius; 
    public LayerMask groundLayer;
   
void Start() {  // kører så snart spillet er startet
    rb = GetComponent<Rigidbody2D>(); 
} 
    void Update() {  // Update bliver kørt igennem her gang der kører en frame
    Move(); 
    Jump();
    CheckIfGrounded();
} 
void Move() { 
    float x = Input.GetAxisRaw("Horizontal"); 
    float moveBy = x * speed; 
    rb.velocity = new Vector2(moveBy, rb.velocity.y); 
}
void Jump() { 
    if (Input.GetKeyDown(KeyCode.Space) && isGrounded) { 
        rb.velocity = new Vector2(rb.velocity.x, jumpForce); 
    } 
}

void CheckIfGrounded() { // for at undgå at spilleren bare kan flyve ved med at blive ved med at hoppe, har vi tilføjet en "Groundchecker" som ligger på spilleren. og det "ground" layer vi har lagt på ting man skal kunne hoppe fra. 
    Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer); //
    if (collider != null) { 
        isGrounded = true; 
    } else { 
        isGrounded = false; 
    } 
}

void Flip(){
    if (rb.velocity.x < 0){
    // her burde der være en kode som flipper player spriten når personen bevæger sig mod højre eller mod venstre.
    }
}

}