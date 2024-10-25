# TurboRivals
![image](https://github.com/user-attachments/assets/6586ebd0-acf8-4a86-b029-4abcd20a9284)

***Description des Classes***
-------1. GameManager---------
 La classe GameManager est responsable de la gestion de la course.
 **Attributs** :
circuits : une liste de circuits disponibles pour les courses.
vehicles : une liste des véhicules participants à la course.
remainingLaps : le nombre de tours restants à compléter dans la course.

-------2. Circuit-------------
La classe Circuit définit un circuit de course
 **Attributs** :
name : le nom du circuit.
length : la longueur totale du circuit.
obstacles : une liste d'obstacles présents sur le circuit.
checkpoints : les positions des checkpoints à franchir durant la course.

---------3. Obstacle-----------
 la classe Obstacle définit les obstacles sur le circuit :
**Attributs** :
position : la position de l'obstacle sur le circuit.
size : la taille de l'obstacle.
isDestructible : un booléen qui indique si l'obstacle peut être détruit.

--------4. Vehicle-------------
La classe Vehicle représente un véhicule de course
**Attributs** :
speed : la vitesse actuelle du véhicule.
maxSpeed : la vitesse maximale que le véhicule peut atteindre.
boosts : le nombre de boosts disponibles pour le véhicule.
position : la position actuelle du véhicule sur le circuit.
isBoosting : un booléen qui indique si le véhicule utilise un boost.

-----------5. PlayerVehicle (hérite de Vehicle)---------
La classe PlayerVehicle est une sous-classe de Vehicle

------------6. AIVehicle (hérite de Vehicle)------------
La classe AIVehicle, également dérivée de Vehicle, représente un véhicule contrôlé par l'IA
**Attributs** :
aiDifficulty : un entier qui détermine le niveau de difficulté de l'intelligence artificielle.
targetCheckpoint : la position du prochain checkpoint que l'IA doit atteindre.

------------7.Powers--------------------
La classe PowerUp est la base pour tous les types de bonus disponibles dans le jeu
**Attributs** :
type : le type de power-up, par exemple, un boost.
duration : la durée de l'effet du power-up, exprimée en secondes.
isActive : un booléen qui indique si le power-up est actuellement actif.

------------8. SpeedBoost (hérite de Powers)--------------
La classe SpeedBoost, qui hérite de PowerUp, représente un boost de vitesse
**Attributs** :
speedMultiplier : un facteur qui augmente la vitesse du véhicule lorsqu'il utilise ce power-up.

--------------9. Shield (hérite de Powers)---------------
La classe Shield, aussi dérivée de PowerUp, offre une protection au véhicule
**Attributs** :
remainingHits : le nombre de collisions que le bouclier peut absorber avant de se désactiver.

----------------10. Missile (hérite de Powers)-----------------
La classe Missile est un type de power-up qui attaque les adversaires
**Attributs** :
arget : le véhicule ciblé par le missile.
damage : la quantité de dégâts que le missile inflige à sa cible.

----------------11. OilSlick (hérite de Powers)--------------
La classe OilSlick représente une traînée d'huile sur le circuit :
**Attributs** :
slowingEffect : le facteur de réduction de vitesse appliqué aux véhicules qui passent sur l'huile.

---------------12. EMP (hérite de Powers)-----------------
La classe EMP, qui est également une sous-classe de PowerUp, provoque une onde de choc
**Attributs** :
range : le rayon d'effet de l'onde de choc produite par l'EMP.

---------------13. MenuManager------------------
La classe MenuManager est responsable de la gestion des interfaces utilisateur liées aux menus du jeu.
**Attributs** :
circuitSelection : une structure qui gère la sélection des circuits par le joueur.
scoreboard : une structure qui affiche le classement et les scores des joueurs.
Méthodes :
DisplayCircuitSelection() : affiche les circuits disponibles pour sélection.
DisplayScoreboard() : affiche les résultats et les scores des joueurs à la fin de la course.

---------------14. RaceInterface------------------
La classe RaceInterface gère les informations affichées pendant la course.
**Attributs** 
currentLap : un entier représentant le tour actuel du joueur.
playerPosition : la position actuelle du joueur dans la course.
miniMap : une représentation graphique simplifiée du circuit.
speed : la vitesse actuelle du véhicule du joueur.
availablePowers : une liste des pouvoirs disponibles pour le joueur.
Méthodes :
UpdateRaceInfo() : met à jour les informations de course affichées, comme le tour actuel et la position du joueur.
DisplayMiniMap() : affiche la mini-carte du circuit pendant la course.


### Patrons de conception
j:ai chosis ces deux patrons 
- **Patron de création** : Singleton pour `GameManager` afin de garantir une seule instance.
Cela assure une gestion centralisée de tout ce qui concerne la course (comme les véhicules et les tours restants). Cela évite les conflits entre plusieurs instances et facilite l'accès à GameManager depuis n'importe quel autre script.
//Avantages :
Accès unique et simplifié aux fonctionnalités du jeu.
Facilite la gestion de l'état du jeu.
- **Patron structurel** : Composite pour les véhicules et leurs power-ups.
Cela permet aux véhicules de posséder plusieurs power-ups de manière flexible, sans avoir besoin de modifier le code chaque fois qu'un nouveau power-up est ajouté.
//Avantages :
Flexibilité pour ajouter ou retirer des power-ups.
Uniformité dans la gestion des véhicules et de leurs effets.

  ### Algorithme de déplacement de l'IA
L'IA utilisera un algorithme de suivi de chemin ( Dijkstra) pour naviguer vers les checkpoints, permettant une prise de décision efficace.
{Il a pour but de trouver le chemin le plus court entre deux points, ce qui est essentiel pour diriger l'IA vers le prochain checkpoint tout en évitant les obstacles. En utilisant cet algorithme, l'IA peut prendre des décisions intelligentes et naviguer de manière efficace sur le circuit. De plus, il lui permet de s'adapter rapidement aux changements en recalculant son itinéraire si nécessaire, garantissant ainsi une performance optimale durant la course.}
