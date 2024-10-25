using UnityEngine;

public class Vehicles : MonoBehaviour
{
    public float speed; // Vitesse actuelle du véhicule
    public float maxSpeed = 100f; // Vitesse maximale autorisée
    public int boosts = 3; // Nombre de boosts disponibles
    public bool isBoosting = false; // Indique si le véhicule est en train de booster
    private float boostDuration = 6f; // Durée d'un boost en secondes
    private float boostEndTime; // Temps auquel le boost se termine

    void Update()
    {
        // Appeler les fonctions pour gérer le mouvement et les boosts
        HandleMovement();
        HandleBoost();
    }

    // Méthode pour gérer le déplacement du véhicule
    protected virtual void HandleMovement()
    {
        // Obtenir les entrées du joueur pour avancer et tourner
        float move = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(Vector3.forward * move); // Déplacer vers l'avant

        float turn = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Rotate(Vector3.up, turn); // Tourner le véhicule

        // Limiter la vitesse du véhicule pour qu'elle ne dépasse pas la vitesse maximale
        speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

    // Méthode pour activer le boost
    public void ActivateBoost()
    {
        if (boosts > 0 && !isBoosting) // Vérifier s'il reste des boosts et si le véhicule ne booste pas déjà
        {
            isBoosting = true; // Activer le boost
            boosts--; // Réduire le nombre de boosts disponibles
            boostEndTime = Time.time + boostDuration; // Définir le moment où le boost se termine
            speed = maxSpeed; // Augmenter la vitesse au maximum pendant le boost
        }
    }

    // Méthode pour gérer la fin du boost
    private void HandleBoost()
    {
        if (isBoosting && Time.time > boostEndTime) // Vérifier si le boost est actif et a expiré
        {
            isBoosting = false; // Désactiver le boost
            speed = maxSpeed / 2; // Réduire la vitesse à une valeur normale
        }
    }
}
