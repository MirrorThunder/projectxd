using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

	public float velocidad = 5f;
	public InputAction moverPersonaje;
	public GameObject proyectil;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

	void OnEnable(){
		moverPersonaje.Enable();
	}

	void OnDisable(){
		moverPersonaje.Disable();
	}

    // Update is called once per frame
    void Update()
    {

		if(Keyboard.current.spaceKey.wasPressedThisFrame && proyectil != null){
			Instantiate(proyectil, transform.position + transform.forward, transform.rotation);
		}

        Vector2 input = moverPersonaje.ReadValue<Vector2>();

		Vector3 movimiento = new Vector3(input.x, 0, input.y);

		transform.Translate(movimiento * velocidad * Time.deltaTime);

		// Limites

		if(transform.position.x > 5){
			transform.position = new Vector3(5, transform.position.y, transform.position.z);
		}

		if(transform.position.z > 5){
			transform.position = new Vector3(transform.position.x, transform.position.y, 5);
		}

    }
}
