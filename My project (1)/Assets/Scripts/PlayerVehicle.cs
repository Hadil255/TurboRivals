using UnityEngine;

public class PlayerVehicle : Vehicles
{
    void Update()
    {
        base.Update(); // Appeler la méthode Update de la classe de base pour gérer le mouvement et les boosts

        // Vérifier si le joueur appuie sur la touche "Espace" pour activer un boost
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateBoost(); // Activer le boost
        }
    }
}
