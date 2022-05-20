using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

public class SnakeController : MonoBehaviour

{
    public int timeBeforeMove;// int = chiffre entier 
    private Vector2 currentInput;
    private bool isAlive = true;
    public Rigidbody2D MovePosition;



    public void Start()
    {
        StartCoroutine(Move());
    }
    private IEnumerator Move()
    {
        while (isAlive)
        {
            isAlive = true;
            Debug.Log("ça marche");
            yield return new WaitForSeconds(timeBeforeMove); //null
        }
       
        
    }


    public void Update()
    {
       
    }

    public void Awake()
    {
        MovePosition = gameObject.AddComponent<Rigidbody2D>();
    }
    public void OnMove(InputAction.CallbackContext context)

    {
        if (!context.performed)// si context n'est pas utiliser 
            return;
        var roundPosition = Vector2Int.RoundToInt(currentInput);
        MovePosition = GetComponent<Rigidbody2D>();


        //j'appelle ma fonction MovePosition dans celle-ci



        //var move = context.ReadValue<Vector2>();
        //currentInput = move;

    }
    void FixedUpdate()
    {
        MovePosition.MovePosition(MovePosition.position + velocity * Time.fixedDeltaTime);
    }
}
