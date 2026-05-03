# Projet C# WinForms : SecurIT Memory

## Contexte du projet
Ce projet a été réalisé en binôme dans le cadre de notre évaluation de développement C# et Windows Forms. 
L'objectif était de concevoir un jeu de Memory fonctionnel pour le stand de la start-up fictive "SecurIT" lors du Salon de l'Innovation Tech, en utilisant le thème de la cybersécurité.

## Fonctionnalités implémentées
Conformément au cahier des charges, notre application intègre les fonctionnalités suivantes :
* **Menu principal** : Permet de lancer le jeu, de modifier les options ou de quitter.
* **Options de jeu** : Choix de la taille de la grille (4x4 classique ou 6x6 difficile).
* **Moteur de jeu** : 
  * Génération dynamique de la grille (centrée automatiquement).
  * Mélange aléatoire des cartes en début de partie.
  * Gestion des paires avec un Timer pour le délai de retournement des cartes incorrectes.
  * Suivi en temps réel via un chronomètre et un compteur d'essais.
* **Fin de partie** : Détection automatique de la victoire et affichage du score.

## Architecture Technique (POO)
Le projet respecte les principes de la Programmation Orientée Objet avec une séparation claire entre la logique et l'interface graphique :
* **Classe `Card`** : Encapsulation des données d'une carte (ID, Image) et utilisation d'une énumération (`CardState`) pour gérer ses états (Cachée, Révélée, Trouvée).
* **Composant personnalisé** : Création d'une classe `CardButton` héritant de la classe `Button` de base pour gérer l'affichage spécifique de chaque carte.
* **Collections** : Utilisation de listes dynamiques (`List<Card>`) pour gérer le paquet de cartes.

## Prérequis et Installation
* Microsoft Visual Studio (2019 ou supérieur).
* .NET Framework 4.7.2.

**Pour lancer le projet :**
1. Téléchargez ou clonez le dépôt sur votre ordinateur.
2. Ouvrez le fichier solution `SecurIT-Memory.sln` dans Visual Studio.
3. Assurez-vous que le projet de démarrage est bien défini sur l'interface (View).
4. Cliquez sur "Démarrer" (ou touche F5) pour compiler et exécuter le jeu.

## Auteurs
* Néo Silvertand
* Loulia Tsui-Way-Sagne
