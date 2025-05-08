using UnityEngine;

public class Cell : MonoBehaviour
{
    public Vector2Int gridPos;   // Se guarda su posici�n dentro del grid (no es su posici�n en el mundo).
    public bool isAlive = false; // Estado de la celda: viva (true) o muerta (false).

    private SpriteRenderer _sr;  // El componente visual que nos permite cambiar el color.

    private void Awake()
    {
        // Se guarda la referencia al SpriteRenderer que est� en el mismo objeto.
        _sr = GetComponent<SpriteRenderer>();

        // Se establece el color inicial (seg�n si est� viva o no).
        UpdateColor();
    }

    // Se cambia el estado de la celda y actualiza el color.
    public void SetAlive(bool alive)
    {
        isAlive = alive;
        UpdateColor();
    }

    // Se invierte el estado actual (para cuando se da clic).
    public void Toggle()
    {
        isAlive = !isAlive;
        UpdateColor();
    }

    // Se cambia el color visual dependiendo del estado.
    private void UpdateColor()
    {
        _sr.color = isAlive ? Color.black : Color.white;
    }

    // Este m�todo se ejecuta autom�ticamente cuando hacemos clic en la celda.
    private void OnMouseDown()
    {
        Toggle(); // Alternamos entre viva y muerta.
    }
}